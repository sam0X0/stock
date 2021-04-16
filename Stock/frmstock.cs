using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stock
{
    public partial class frmstock : Form
    {
      
        public frmstock()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=SERVER1;Initial Catalog=db_stock;Integrated Security=True");
        
        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpart_TextChanged(object sender, EventArgs e)
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
                         
                      
                        txtunit.ReadOnly = true;
                        cmbunit.Enabled = false;
                      

                    }
                    else
                    {
                        txtsize.Text = "";
                        //txtunit.ReadOnly = false;
                        //cmbunit.Enabled =true;
                    }



                }
                catch
                {
                }

            }
            else
            {
                txtpart.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtpart.Text);
                txtpart.Select(txtpart.Text.Length, 0);
                txtunit.ReadOnly = false;
                cmbunit.Enabled = true;


            }
        }

        private void frmstock_Load(object sender, EventArgs e)
        {
            btnview_Click(sender, e);
            clmtot();
            cmbunit.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void clmtot()
        {
            try
            {
                

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
        private void btnsave_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd;

            try
            {
                if (string.IsNullOrEmpty(txtpart.Text))
                {
                    MessageBox.Show("Please Enter Product");
                }

                else
                {
                    cn.Close();
                    cn.Open();


                    string qry = "insert into tbl_stock(particular,squarft,unit,unitsym,part_desc) values('" + txtpart.Text + "','" + txtsize.Text + "','" + txtunit.Text + "','" + cmbunit.Text + "','" + txtdis.Text + "')";

                    cmd = new SqlCommand(qry, cn);


                    if (cmd.ExecuteNonQuery() > 0)
                    {


                        MessageBox.Show("Insert Successfully");

                        txtpart.Text = "";
                        txtsize.Text = "";
                        txtunit.Text = "";
                        cmbunit.SelectedIndex = 0;
                        txtdis.Text = "";
                        btnview_Click(sender, e);


                    }


                    else
                    {
                        MessageBox.Show("Failed to Insert");
                    }

                }

                cn.Close();

            }

            catch
            {
                MessageBox.Show("Something went wrong");

            }
        }

        private void btnview_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            clmtot();
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblsearch.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtsupid.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                txtpart.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                txtunit.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                cmbunit.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                txtsize.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtdis.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
                txtsupid.Visible = true;
                btnsave.Visible = false;

            }
            catch
            {
                MessageBox.Show("ERROR!!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete record?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    cn.Open();
                    string qry = "delete from tbl_stock where stk_id='" + txtsupid.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, cn);


                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("deleted Successfully");
                        txtpart.Text = "";
                        txtsize.Text = "";
                        txtunit.Text = "";
                        cmbunit.SelectedIndex = 0;
                        txtdis.Text = "";
                        btnview_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete");
                    }
                    cn.Close();
                }

                else
                {

                    MessageBox.Show("Abort");
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string qry = "update tbl_stock set particular='" + txtpart.Text + "',squarft='" + txtsize.Text + "',unit='" + txtunit.Text + "',unitsym='" + cmbunit.Text + "',part_desc='" + txtdis.Text + "' where stk_id='" + txtsupid.Text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);


                if (cmd.ExecuteNonQuery() > 0)
                {



                    MessageBox.Show("Update Successfully");
                    btnview_Click(sender, e);

                    txtpart.Text = "";
                    txtsize.Text = "";
                    txtunit.Text = "";
                    cmbunit.SelectedIndex = 0;
                    txtdis.Text = "";


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
                        btnview_Click(sender, e);

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

        private void txtsize_TextChanged(object sender, EventArgs e)
        {
            
            double ans;
            double.TryParse(txtsize.Text, out ans);
            
            txtsize.Text = Math.Round(ans, 3, MidpointRounding.ToEven).ToString();
            
            
        }

        private void lblsup_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtop_Paint(object sender, PaintEventArgs e)
        {

        }

        
            
       
        


        }
    }

