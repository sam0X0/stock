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
    public partial class frmviewbill : Form
    {
        public frmviewbill()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=SERVER1;Initial Catalog=db_stock;Integrated Security=True");
        private void frmviewbill_Load(object sender, EventArgs e)
        {
            loadbill();
        }
        public void loadbill()
        {

            string qry = "select * from tbl_invoice where billno like '%' order by billno asc";
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

                }
            }
            catch
            {
                MessageBox.Show("Click Reset Button");
            }
            gross();
            gross1();
            clmtot();
        }
        public void gross()
        {
            try
            {
                decimal Total = 0;
               // decimal Total1 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["grosstot"].Value);
                 //   Total1 += Convert.ToDecimal(dataGridView1.Rows[i].Cells["billpay"].Value);
                }

                lblamount.Text = Total.ToString();
              // lblnet.Text = Total.ToString();


            }
            catch
            {

            }
        }
        public void clmtot()
        {
            try
            {


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //Total = Convert.ToDecimal(dataGridView.Rows[i].Cells["stk_id"].Value);
                    lblto.Text = dataGridView1.Rows.Count.ToString();
                }

                //  lblamt.Text = Total.ToString();


            }
            catch
            {

            }
        }
        public void gross1()
        {
            
            try
            {

                decimal Total = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                    Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["billpay"].Value);
                    lblnet.Text = Total.ToString();
                }


                


            }
            catch
            {
                
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {

            string qry = "select * from tbl_invoice where billdate between '" + mrkfrm.Text + "' and '" + mrkto.Text + "' ";
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
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["customer1"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["mob"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["billdate"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["grosstot"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i]["billpay"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i]["billtype"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Click Reset Button");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.Text, "^[a-zA-z]"))
            {
                string qry = "select * from tbl_invoice where billno like '" + txtsearch.Text.Trim() + "%'";
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


                    }
                    else if (txtsearch.Text == string.Empty)
                    {
                        lblresult.Visible = false;
                        lblresult.Text = "Text box is Empty !";

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
            gross();
            gross1();
            clmtot();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("If you Delete this product then delete both product(Purchase & Pricing database) ", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cn.Close();
                    cn.Open();
                    string qry = "delete from tbl_invoice where billno='" + txtsearch.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, cn);


                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("deleted Successfully");
                        loadbill();
                        txtsearch.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete");
                    }

                }

                else
                {

                    MessageBox.Show("Abort");
                }
                cn.Close();

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsearch.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mrkcontact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

            }

        private void mrkcontact_Enter(object sender, EventArgs e)
        {
            
        }

        private void mrkcontact_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mrkcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            string qry = "select * from tbl_invoice where mob like '" + mrkcontact.Text.Trim() + "%'";
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


                }
                else if (txtsearch.Text == string.Empty)
                {
                    lblresult.Visible = false;
                    lblresult.Text = "Text box is Empty !";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlname_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    

        }
    }

