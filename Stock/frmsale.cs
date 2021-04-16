using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;

namespace Stock
{
    public partial class frmsale : Form
    {
       
        public frmsale()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=SERVER1;Initial Catalog=db_stock;Integrated Security=True");
        private void pnlproduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlpro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx.Checked == true)
            {
                try
                {
                    cn.Close();
                    cmbcust.DropDownStyle = ComboBoxStyle.DropDownList;
                    DataTable dt1 = new DataTable();
                    string qry = "select cust_id,company from tbl_cust ";
                    SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                    sda.Fill(dt1);
                    if (dt1.Rows.Count > 0)
                    {
                        cmbcust.DataSource = dt1;
                        cmbcust.ValueMember = "cust_id";
                        cmbcust.DisplayMember = "company";
                    }

                    else
                    {
                        MessageBox.Show("Data not Found");
                    }


                    // dt1.Rows.Clear();
                }
                catch
                {

                    //dt1.Rows.Clear();
                }

            }
            if (chkbx.Checked == false)
            {
                cmbcust.Text = "--Select Customer--";
                mrkcontact.Text = "";

            }
        }

        private void frmsale_Load(object sender, EventArgs e)
        {
            loaddata();
            loadbill();
            clmtot();
            txtpart.Select();
           
            
        }
       
       
        public void gross()
        {
            try
            {
                decimal Total = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["amount"].Value);
                }

                lblamount.Text = Total.ToString();


            }
            catch
            {

            }
        }
        public void loadbill()
        {
            try
            {
                SqlDataReader dr;
                SqlCommand cmd;
                int Num1 = 0;
                cn.Open();
                string qry = " select Max(billno) from tbl_invoice";
                cmd = new SqlCommand(qry, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Num1 = int.Parse(dr[0].ToString());
                }
                dr.Close();
                lbbillno.Text = (Num1 + 1).ToString();
            }
            catch
            { 
            
            }
             cn.Close();
        }

        public void clmtot()
        {
            try
            {
                //decimal Total = 0;

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    //Total = Convert.ToDecimal(dataGridView.Rows[i].Cells["stk_id"].Value);
                    lblamt.Text = dataGridView.Rows.Count.ToString();
                }

                //  lblamt.Text = Total.ToString();


            }
            catch
            {

            }
        }
        public void loaddata()
        {

            string qry = "select * from tbl_stock where stk_id like '%' order by stk_id asc";
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                dataGridView.Rows.Clear();
                sda.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[i].Cells[0].Value = i + 1;

                    dataGridView.Rows[i].Cells[0].Value = dt.Rows[i]["stk_id"].ToString();
                    dataGridView.Rows[i].Cells[1].Value = dt.Rows[i]["particular"].ToString();
                    dataGridView.Rows[i].Cells[2].Value = dt.Rows[i]["squarft"].ToString();
                    dataGridView.Rows[i].Cells[3].Value = dt.Rows[i]["unit"].ToString();
                    dataGridView.Rows[i].Cells[4].Value = dt.Rows[i]["unitsym"].ToString();
                    dataGridView.Rows[i].Cells[5].Value = dt.Rows[i]["part_desc"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                string qry = "select * from tbl_cust where cust_id='" + cmbcust.SelectedValue + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    mrkcontact.Text = dt.Rows[0]["contact"].ToString();
                }
                dt.Rows.Clear();

            }
            catch
            {


                dt.Rows.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {

            txtserach.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtserach.Text);
            txtserach.Select(txtserach.Text.Length, 0);

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtserach.Text, "^[a-zA-z]"))
            {
                string qry = "select * from tbl_stock where particular like '" + txtserach.Text.Trim() + "%'";
                try
                {

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                    dataGridView.Rows.Clear();
                    sda.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        dataGridView.Rows.Add();
                        dataGridView.Rows[i].Cells[0].Value = i + 1;

                        dataGridView.Rows[i].Cells[0].Value = dt.Rows[i]["stk_id"].ToString();
                        dataGridView.Rows[i].Cells[1].Value = dt.Rows[i]["particular"].ToString();
                        dataGridView.Rows[i].Cells[2].Value = dt.Rows[i]["squarft"].ToString();
                        dataGridView.Rows[i].Cells[3].Value = dt.Rows[i]["unit"].ToString();
                        dataGridView.Rows[i].Cells[4].Value = dt.Rows[i]["unitsym"].ToString();
                        dataGridView.Rows[i].Cells[5].Value = dt.Rows[i]["part_desc"].ToString();

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblsearch.Text = "OOPS Record Not Found !";
                        // lblreslt.BackColor = Color.Red;



                    }
                    else if (txtserach.Text == string.Empty)
                    {

                        lblsearch.Text = "Text box is Empty !";
                        loaddata();
                        clmtot();

                    }
                    else
                    {


                        lblsearch.Text = "Record Found !";

                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clmtot();
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblsearch.ForeColor = Color.FromArgb(one, two, three, four);
            lbldate.Text = DateTime.Now.ToString("dd-MM-yyyy");

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtrate.Text == "")
                {

                }
                else
                {
                    txtwt.ReadOnly = false;
                    txtqty.ReadOnly = false;
                    double a, b, c;

                    double.TryParse(txtsize.Text, out a);
                    double.TryParse(txtrate.Text, out b);


                    c = a * b;

                    if (c > 0)
                        txttotal.Text = c.ToString("c").Remove(0, 1);


                }
            }
            catch
            {
                MessageBox.Show("ERROR !");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtwt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;

                double.TryParse(txtwt.Text, out a);
                double.TryParse(txtrate.Text, out b);

                c = a * b;
                if (c > 0)
                    txttotal.Text = c.ToString("c").Remove(0, 1);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void pnlrecord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void pnlsearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;

                double.TryParse(txtqty.Text, out a);
                double.TryParse(txtrate.Text, out b);

                c = a * b;
                if (c > 0)
                    txttotal.Text = c.ToString("c").Remove(0, 1);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncart_Click(object sender, EventArgs e)
        {

            int row = 0;
            if (txtpart.Text == "")
            {
                MessageBox.Show("Enter product");
            }
            else
            {
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 1;
                // dataGridView1["sr", row].Value = txtserial.Text;
                dataGridView1["particulars", row].Value = txtpart.Text;
                dataGridView1["size", row].Value = txtwt.Text;
                dataGridView1["wgt", row].Value = txtwt.Text;
                dataGridView1["unit1", row].Value = lblunit.Text;
                dataGridView1["amount", row].Value = txttotal.Text;
                dataGridView1["bill", row].Value = lbbillno.Text;
                dataGridView1["rate", row].Value = txtrate.Text;
                dataGridView1["qty", row].Value = txtqty.Text;
                dataGridView1["nos", row].Value = lblnos.Text;
                gross();
                txtpart.Text = "";
                txtqty.Text = "";
                txtsize.Text = "";
                txtwt.Text = "";
                txtrate.Text = "";
                txttotal.Text = "";

                

            }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 10)// created column index (delete button)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                //commit the changes!
            }
        }
        

        private void btnview_Click(object sender, EventArgs e)
        {
          
             frminvoice invoice = new frminvoice();

            try
            {
               
               // cn.Close();
                cn.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(@"SELECT * FROM tbl_invoice where billno='" + lbbillno.Text + "' ", cn);
               
                DataTable dt = new DataTable();
                
                
               //cn.Close();
               // cn.Open();
                myReader = myCommand.ExecuteReader();
                
                if (myReader.Read())
                {
                    invoice.txts.Text = (myReader["billno"].ToString());



                    btnsave_Click(sender, e);
                    invoice.Show();
                }
               // invoice.Show();
               
            }
            catch
            {

            }
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd;
                SqlCommand cmd1;
                // SqlCommand cmd2;


                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Add Minimum one Product to Cart");
                }
                else
                {
                    //save billdata//

                    cn.Close();
                    cn.Open();

                    string qry = "insert into tbl_invoice(billno,customer,mob,billdate,grosstot,billpay,billtype) values('" + lbbillno.Text + "','" + cmbcust.Text + "','" + mrkcontact.Text + "','" + lbldate.Text + "','" + lblamount.Text + "','" + txtnetpay.Text + "','" + cmbilltype.Text + "')";

                    cmd = new SqlCommand(qry, cn);
                    cmd.ExecuteNonQuery();

                    //save grid data

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        string qry1 = "insert into tbl_prodata(sr,particulars,size,wgt,unit1,qty,nos,rate,amount,bill) values('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[8].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[9].Value.ToString() + "')";
                        cmd1 = new SqlCommand(qry1, cn);
                        cmd1.ExecuteNonQuery();

                    }
                    //ddddsavedata


                    MessageBox.Show("Bill Save Successfully !");
                    btnprint.Visible = true;
                    txtpart.Text = "";
                    txtqty.Text = "";
                    txtsize.Text = "";
                    txtwt.Text = "";
                    txtrate.Text = "";
                    txttotal.Text = "";
                    

                    cn.Close();
                }

            }
            catch
            {

            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtpart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Close();
                cn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter();
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("select particular from tbl_stock where particular like @particular", cn);
                cmd.Parameters.Add(new SqlParameter("@particular", "%" + txtpart.Text + "%"));
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));

                }
                txtpart.AutoCompleteCustomSource = col;
                cal();
                cn.Close();
            }
        
            
            catch
            {
               MessageBox.Show("Record Not Found");
            }
        }
        public void cal()
        { 
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtpart.Text, "^[a-zA-z]"))
            {
                float n1, n2;
                try
                {
                    if (txtpart.Text.Contains('x'))
                    {
                      string[] nos = txtpart.Text.Split('x');
                      
                        n1 = float.Parse(nos[0]);
                        n2 = float.Parse(nos[1]);
                          float ans = n1 * n2/144;
                        // dblSlabResult = Math.Round(dblSlabResult , 2);

                          txtsize.Text = ans.ToString();
                         
                      
                      

                    }
                    else
                    {
                        txtsize.Text = "";
                        
                    }


                }
                catch
                {

                }

         
        }
        
        }

        private void lblamount_Click(object sender, EventArgs e)
        {

        }

        private void pnlcustomeer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblunit_Click(object sender, EventArgs e)
        {

        }

        private void pnlname_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmcustomer customer = new frmcustomer();
            customer.Show();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void txtnetpay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnup_Click(object sender, EventArgs e)
        {
           
        

        }

        private void frmsale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {

                int row = 0;
                if (txtpart.Text == "")
                {
                    MessageBox.Show("Enter product");
                }
                else
                {
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 1;
                    // dataGridView1["sr", row].Value = txtserial.Text;
                    dataGridView1["particulars", row].Value = txtpart.Text;
                    dataGridView1["size", row].Value = txtwt.Text;
                    dataGridView1["wgt", row].Value = txtwt.Text;
                    dataGridView1["unit1", row].Value = lblunit.Text;
                    dataGridView1["amount", row].Value = txttotal.Text;
                    dataGridView1["bill", row].Value = lbbillno.Text;
                    dataGridView1["rate", row].Value = txtrate.Text;
                    dataGridView1["qty", row].Value = txtqty.Text;
                    dataGridView1["nos", row].Value = lblnos.Text;
                    gross();
                    txtpart.Text = "";
                    txtqty.Text = "";
                    txtsize.Text = "";
                    txtwt.Text = "";
                    txtrate.Text = "";
                    txttotal.Text = "";



                }
                

            }
            else if (e.KeyCode == Keys.F2)
            {
                btnsave_Click(sender, e);
            }
            else
            {

            }
        }
      
        
    }
    }


