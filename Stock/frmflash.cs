using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock
{
    public partial class frmflash : Form
    {
        public frmflash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 386)
            {
                timer1.Start();
                timer1.Stop();
                this.Visible = false;
                frmdashboard dashboard = new frmdashboard();
                
                dashboard.ShowDialog();

                
                
            }
           
        }

        private void frmflash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
