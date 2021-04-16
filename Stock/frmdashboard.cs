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
namespace Stock
{
    public partial class frmdashboard : Form
    {
        public int val = 0;
        public float n1, n2;
        public frmdashboard()
        {
            InitializeComponent();
        }
        //string str =null;
        SqlConnection cn = new SqlConnection(@"Data Source=SERVER1;Initial Catalog=db_stock;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cust.tbl_cust' table. You can move, or remove it, as needed.
            this.tbl_custTableAdapter.Fill(this.cust.tbl_cust);
            // TODO: This line of code loads data into the 'cust.tbl_cust' table. You can move, or remove it, as needed.
           // this.tbl_custTableAdapter.Fill(this.cust.tbl_cust);
            // TODO: This line of code loads data into the 'cust.tbl_cust' table. You can move, or remove it, as needed.
          //  this.tbl_custTableAdapter.Fill(this.cust.tbl_cust);

            this.reportViewer1.RefreshReport();
            //btnview_Click(sender, e);
             loadbill();
            clmtot();
           
        }
        public void db()
        {

            cn.Close();
            cn.Open();
            String database = cn.Database.ToString();
            try
            {
                

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='D:\\umiyadb\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    //D:\umiyadb
                    SqlCommand scmd = new SqlCommand(q, cn);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");




                    cn.Close();

                
            }
            catch
            {
                MessageBox.Show("Access is Denied !");
            }
        }
        public void clmtot()
        {
            try
            {
                //decimal Total = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //Total = Convert.ToDecimal(dataGridView.Rows[i].Cells["stk_id"].Value);
                    lbltot.Text = dataGridView1.Rows.Count.ToString();
                }

                //  lblamt.Text = Total.ToString();


            }
            catch
            {

            }
        }
        public void loadbill()
        {

            string qry = "select * from tbl_invoice where billtype = 'credit' order by billno asc";
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                dataGridView1.Rows.Clear();
                sda.Fill(dt);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["billno"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["customer"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["customer"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["mob"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["billdate"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["grosstot"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["billpay"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["billtype"].ToString();
                    cn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Click Reset Button");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnuser_MouseHover(object sender, EventArgs e)
        {
            this.btnuser.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btnuser_MouseEnter(object sender, EventArgs e)
        {
            this.btnuser.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btnuser_Click(object sender, EventArgs e)
        {

            frmcustomer customer = new frmcustomer();

            customer.ShowDialog();
        }

        private void btnstock_MouseHover(object sender, EventArgs e)
        {
            this.btnstock.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btnstock_MouseEnter(object sender, EventArgs e)
        {
            this.btnstock.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void pnlmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlfrm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            frmstock stock = new frmstock();

            pnlfrm.Controls.Clear();

           
            stock.Show();
        }

        private void btndashboard_MouseEnter(object sender, EventArgs e)
        {
            this.btnbillview.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btndashboard_MouseHover(object sender, EventArgs e)
        {
            this.btnbillview.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmsale sale = new frmsale();

            
            sale.Show();
        }

        private void btnsale_MouseEnter(object sender, EventArgs e)
        {
            this.btnsale.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btnsale_MouseHover(object sender, EventArgs e)
        {
            this.btnsale.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void pict_Click(object sender, EventArgs e)
        {
            db();
            cn.Close();
           
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlpay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void pnlgrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnldashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlcustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnetpay.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblamount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblbillno.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.Text, "^[a-zA-z]"))
            {
                string qry = "select * from tbl_invoice where billno like '" + txtsearch.Text.Trim() + "'";
                try
                { //select * from tbl_invoice where billtype = 'credit' order by billno asc

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(qry, cn);
                    dataGridView1.Rows.Clear();
                    sda.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["billno"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["customer"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["customer1"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["mob"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["billdate"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["grosstot"].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["billpay"].ToString();
                        dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["billtype"].ToString();


                    }
                    if (dt.Rows.Count <= 0)
                    {
                        lblresult.Text = "OOPS Record Not Found !";
                        loadbill();

                    }
                    else if (txtsearch.Text == string.Empty)
                    {
                        lblresult.Visible = false;
                        lblresult.Text = "Text box is Empty !";
                        loadbill(); 
                    }
                    else
                    {

                        //lblresult.Visible = false;
                        lblresult.Text = "Record Found !";
                        
                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong !");
                }

            }
            else
            {

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblresult.ForeColor = Color.FromArgb(one, two, three, four);
            clmtot();
            loadbill();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Close();
                cn.Open();
                string qry = "update tbl_invoice set billpay='" + txtnetpay.Text + "',billtype='Cash' where billno='" + lblbillno.Text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);


                if (cmd.ExecuteNonQuery() > 0)
                {



                    MessageBox.Show("Update Successfully");
                    txtnetpay.Text = "";
                    lblamount.Text = "";
                    loadbill();



                }
                else
                {
                    MessageBox.Show("Failed to Update");
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }

            cn.Close();
        }

        private void btnbillview_Click(object sender, EventArgs e)
        {
            frmviewbill viewbill = new frmviewbill();
            viewbill.Show();
        }

        private void dtop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void d_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndb_Click(object sender, EventArgs e)
        {
            frmbackup backup = new frmbackup();
            backup.Show();
        }

        private void btndb_MouseEnter(object sender, EventArgs e)
        {
            this.btndb.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void btndb_MouseHover(object sender, EventArgs e)
        {
            this.btndb.BackColor = ColorTranslator.FromHtml("MenuHighlight");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void txtsrch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnlst_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
        }

       

        
    }
}
