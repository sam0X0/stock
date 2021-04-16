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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void txtpwd_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtuser.Text;
            pass = txtpwd.Text;
            if (user == "umiya" && pass == "umiya")
            {
                txtuser.Text = "";
                txtpwd.Text = "";
               
               
                this.Visible = false;
                frmflash flash = new frmflash();
                flash.ShowDialog();

            }
            else
            {
                
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
          
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Enter)
            {

                string user, pass;
                user = txtuser.Text;
                pass = txtpwd.Text;
                if (user == "umiya" && pass == "umiya")
                {
                    txtuser.Text = "";
                    txtpwd.Text = "";


                    this.Visible = false;
                    frmflash flash = new frmflash();
                    flash.ShowDialog();

                }
                else
                {

                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
