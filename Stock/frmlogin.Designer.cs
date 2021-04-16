namespace Stock
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.pnlname = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.d_btm = new System.Windows.Forms.Panel();
            this.d_right = new System.Windows.Forms.Panel();
            this.dleft = new System.Windows.Forms.Panel();
            this.dtop = new System.Windows.Forms.Panel();
            this.btnlogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pnlname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlname
            // 
            this.pnlname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlname.Controls.Add(this.label1);
            this.pnlname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlname.Location = new System.Drawing.Point(5, 10);
            this.pnlname.Name = "pnlname";
            this.pnlname.Size = new System.Drawing.Size(334, 42);
            this.pnlname.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(129, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // d_btm
            // 
            this.d_btm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_btm.Location = new System.Drawing.Point(5, 207);
            this.d_btm.Name = "d_btm";
            this.d_btm.Size = new System.Drawing.Size(334, 5);
            this.d_btm.TabIndex = 44;
            // 
            // d_right
            // 
            this.d_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_right.Location = new System.Drawing.Point(339, 10);
            this.d_right.Name = "d_right";
            this.d_right.Size = new System.Drawing.Size(5, 202);
            this.d_right.TabIndex = 43;
            // 
            // dleft
            // 
            this.dleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft.Location = new System.Drawing.Point(0, 10);
            this.dleft.Name = "dleft";
            this.dleft.Size = new System.Drawing.Size(5, 202);
            this.dleft.TabIndex = 42;
            // 
            // dtop
            // 
            this.dtop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtop.Location = new System.Drawing.Point(0, 0);
            this.dtop.Name = "dtop";
            this.dtop.Size = new System.Drawing.Size(344, 10);
            this.dtop.TabIndex = 41;
            // 
            // btnlogin
            // 
            this.btnlogin.ActiveBorderThickness = 1;
            this.btnlogin.ActiveCornerRadius = 20;
            this.btnlogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnlogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.IdleBorderThickness = 1;
            this.btnlogin.IdleCornerRadius = 20;
            this.btnlogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnlogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnlogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.Location = new System.Drawing.Point(156, 159);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(80, 41);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.ActiveBorderThickness = 1;
            this.btnclose.ActiveCornerRadius = 20;
            this.btnclose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnclose.ActiveForecolor = System.Drawing.Color.White;
            this.btnclose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnclose.BackColor = System.Drawing.SystemColors.Control;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.ButtonText = "Close";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleBorderThickness = 1;
            this.btnclose.IdleCornerRadius = 20;
            this.btnclose.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnclose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnclose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnclose.Location = new System.Drawing.Point(246, 159);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(80, 41);
            this.btnclose.TabIndex = 3;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtpwd
            // 
            this.txtpwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(164, 116);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(164, 35);
            this.txtpwd.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Control;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(162, 70);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(164, 35);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 212);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pnlname);
            this.Controls.Add(this.d_btm);
            this.Controls.Add(this.d_right);
            this.Controls.Add(this.dleft);
            this.Controls.Add(this.dtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmlogin_KeyDown);
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel d_btm;
        private System.Windows.Forms.Panel d_right;
        private System.Windows.Forms.Panel dleft;
        private System.Windows.Forms.Panel dtop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclose;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
    }
}