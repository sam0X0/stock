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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection(@"Data Source=SERVER1;Initial Catalog=db_stock;Integrated Security=True");
       

        private void txtcompany_TextChanged_1(object sender, EventArgs e)
        {

            txtcompany.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtcompany.Text);
            txtcompany.Select(txtcompany.Text.Length, 0);
        }

        private void txtperson_TextChanged_1(object sender, EventArgs e)
        {
            txtperson.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtperson.Text);
            txtperson.Select(txtperson.Text.Length, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            btnview_Click(sender, e);
            txtcompany.Select();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd;

            try
            {
                if (string.IsNullOrEmpty(txtcompany.Text))
                {
                    MessageBox.Show("Please Enter Company Name");
                }
                else if (string.IsNullOrEmpty(mrkcontact.Text))
                {
                    MessageBox.Show("Please Enter Contact");
                }



                else
                {
                    cn.Close();
                    cn.Open();


                    string qry = "insert into tbl_cust(company,name,contact,email,address) values('" + txtcompany.Text + "','" + txtperson.Text + "','" + mrkcontact.Text + "','" + txtemail.Text + "','" + txtadd.Text + "')";

                    cmd = new SqlCommand(qry, cn);


                    if (cmd.ExecuteNonQuery() > 0)
                    {


                        MessageBox.Show("Insert Successfully");
                        btnview_Click(sender, e);
                        txtcompany.Text = "";
                        txtperson.Text = "";
                        mrkcontact.Text = "";
                        txtemail.Text = "";
                        txtadd.Text = "";
                        lblsup1.Visible = true;
                        txtsupid.Visible = true;
                        txtsupid.Text = "";

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete record?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    cn.Open();
                    string qry = "delete from tbl_cust where cust_id='" + txtsupid.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, cn);


                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("deleted Successfully");
                        btnview_Click(sender, e);
                        txtcompany.Text = "";
                        txtperson.Text = "";
                        mrkcontact.Text = "";
                        txtemail.Text = "";
                        txtadd.Text = "";
                        txtsupid.Text = "";

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
                string qry = "update tbl_cust set company='" + txtcompany.Text + "',name='" + txtperson.Text + "',contact='" + mrkcontact.Text + "',email='" + txtemail.Text + "',address='" + txtadd.Text + "' where cust_id='" + txtsupid.Text + "'";

                SqlCommand cmd = new SqlCommand(qry, cn);


                if (cmd.ExecuteNonQuery() > 0)
                {



                    MessageBox.Show("Update Successfully");
                    btnview_Click(sender, e);
                    
                    txtcompany.Text = "";
                    txtperson.Text = "";
                    mrkcontact.Text = "";
                    txtemail.Text = "";
                    txtadd.Text = "";
                    lblsup1.Visible = true;
                    txtsupid.Visible = true;
                    txtsupid.Text = "";


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

        private void btnview_Click(object sender, EventArgs e)
        {
            string qry = "select * from tbl_cust where cust_id like '%' order by cust_id asc";
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

                    dataGridView.Rows[i].Cells[0].Value = dt.Rows[i]["cust_id"].ToString();
                    dataGridView.Rows[i].Cells[1].Value = dt.Rows[i]["company"].ToString();
                    dataGridView.Rows[i].Cells[2].Value = dt.Rows[i]["name"].ToString();
                    dataGridView.Rows[i].Cells[3].Value = dt.Rows[i]["contact"].ToString();
                    dataGridView.Rows[i].Cells[4].Value = dt.Rows[i]["email"].ToString();
                    dataGridView.Rows[i].Cells[5].Value = dt.Rows[i]["address"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcompany.Text = "";
            txtperson.Text = "";
            mrkcontact.Text = "";
            txtemail.Text = "";
            txtadd.Text = "";
            lblsup1.Visible = false;
            txtsupid.Visible = false;
            txtsupid.Text = "";
            btnsave.Visible = true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtsupid.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                txtcompany.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                txtperson.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                mrkcontact.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                txtadd.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
                lblsup1.Visible = true;
                txtsupid.Visible = true;
                btnsave.Visible = false;

            }
            catch
            {
                MessageBox.Show("Select Blank Record");
            }
        }

        private void txtsupid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsup1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            txtsearch.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtsearch.Text);
            txtsearch.Select(txtcompany.Text.Length, 0);

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsearch.Text, "^[a-zA-z]"))
            {
                string qry = "select * from tbl_cust where cust_id like '" + txtsearch.Text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["cust_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["company"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["name"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["contact"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["email"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["address"].ToString();

                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblsearch.Text = "OOPS Record Not Found !";
                        // lblreslt.BackColor = Color.Red;



                    }
                    else if (txtsearch.Text == string.Empty)
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
            else
            {
                string qry = "select  * from tbl_cust where company like '" + txtsearch.Text.Trim() + "%'";
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

                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i]["cust_id"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i]["company"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i]["name"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i]["contact"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i]["email"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i]["address"].ToString();


                    }
                    if (dt.Rows.Count <= 0)
                    {

                        lblsearch.Text = "OOPS Record Not Found !";



                    }
                    else if (txtsearch.Text == string.Empty)
                    {

                        lblsearch.Text = "Text box is Empty !";
                        //btnview_Click(sender, e);
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
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblsearch.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void dtop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void d_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void d_btm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
