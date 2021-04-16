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
    public partial class frminvoice : Form
    {
        
        public frminvoice()
        {
            InitializeComponent();
        }

        private void frminvoice_Load(object sender, EventArgs e)
        {

            
           // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
          //  frmsale sale = new frmsale();
            //this.DataTable1TableAdapter.FillBy(this.DataSet1.DataTable1, ((int)(System.Convert.ChangeType(sale.lbbillno.Text, typeof(int)))));
            
           this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

          this.reportViewer1.RefreshReport();
            try
            {
               this.DataTable1TableAdapter.FillBy(this.DataSet1.DataTable1, ((int)(System.Convert.ChangeType(txts.Text, typeof(int)))));

                this.reportViewer1.RefreshReport();
            }
            catch
            {

            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
               this.DataTable1TableAdapter.FillBy(this.DataSet1.DataTable1, ((int)(System.Convert.ChangeType(txtsearch.Text, typeof(int)))));

               this.reportViewer1.RefreshReport();
            }
            catch
            {

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
