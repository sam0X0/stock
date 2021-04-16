namespace Stock
{
    partial class frmbackup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbackup));
            this.dtop = new System.Windows.Forms.Panel();
            this.dleft = new System.Windows.Forms.Panel();
            this.d_right = new System.Windows.Forms.Panel();
            this.d_btm = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblcmp = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.prb = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnbrowe1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnbackup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnbrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtrestore = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BackupTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnlname = new System.Windows.Forms.Panel();
            this.pict = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // dtop
            // 
            this.dtop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtop.Location = new System.Drawing.Point(0, 0);
            this.dtop.Name = "dtop";
            this.dtop.Size = new System.Drawing.Size(454, 10);
            this.dtop.TabIndex = 10;
            this.dtop.Paint += new System.Windows.Forms.PaintEventHandler(this.dtop_Paint);
            // 
            // dleft
            // 
            this.dleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft.Location = new System.Drawing.Point(0, 10);
            this.dleft.Name = "dleft";
            this.dleft.Size = new System.Drawing.Size(5, 261);
            this.dleft.TabIndex = 11;
            this.dleft.Paint += new System.Windows.Forms.PaintEventHandler(this.dleft_Paint);
            // 
            // d_right
            // 
            this.d_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_right.Location = new System.Drawing.Point(449, 10);
            this.d_right.Name = "d_right";
            this.d_right.Size = new System.Drawing.Size(5, 261);
            this.d_right.TabIndex = 12;
            this.d_right.Paint += new System.Windows.Forms.PaintEventHandler(this.d_right_Paint);
            // 
            // d_btm
            // 
            this.d_btm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_btm.Location = new System.Drawing.Point(5, 266);
            this.d_btm.Name = "d_btm";
            this.d_btm.Size = new System.Drawing.Size(444, 5);
            this.d_btm.TabIndex = 13;
            this.d_btm.Paint += new System.Windows.Forms.PaintEventHandler(this.d_btm_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Last  Location";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblcmp
            // 
            this.lblcmp.AutoSize = true;
            this.lblcmp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmp.Location = new System.Drawing.Point(120, 219);
            this.lblcmp.Name = "lblcmp";
            this.lblcmp.Size = new System.Drawing.Size(0, 16);
            this.lblcmp.TabIndex = 37;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Restore DB";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(150, 162);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(114, 41);
            this.bunifuThinButton21.TabIndex = 35;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // prb
            // 
            this.prb.animated = false;
            this.prb.animationIterval = 5;
            this.prb.animationSpeed = 300;
            this.prb.BackColor = System.Drawing.Color.Transparent;
            this.prb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prb.BackgroundImage")));
            this.prb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prb.ForeColor = System.Drawing.Color.SeaGreen;
            this.prb.LabelVisible = true;
            this.prb.LineProgressThickness = 8;
            this.prb.LineThickness = 5;
            this.prb.Location = new System.Drawing.Point(299, 170);
            this.prb.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.prb.MaxValue = 100;
            this.prb.Name = "prb";
            this.prb.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prb.ProgressColor = System.Drawing.Color.SeaGreen;
            this.prb.Size = new System.Drawing.Size(92, 92);
            this.prb.TabIndex = 36;
            this.prb.Value = 0;
            this.prb.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnbrowe1
            // 
            this.btnbrowe1.ActiveBorderThickness = 1;
            this.btnbrowe1.ActiveCornerRadius = 20;
            this.btnbrowe1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.ActiveForecolor = System.Drawing.Color.White;
            this.btnbrowe1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.BackColor = System.Drawing.SystemColors.Control;
            this.btnbrowe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowe1.BackgroundImage")));
            this.btnbrowe1.ButtonText = "Restore Location";
            this.btnbrowe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowe1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.IdleBorderThickness = 1;
            this.btnbrowe1.IdleCornerRadius = 20;
            this.btnbrowe1.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbrowe1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowe1.Location = new System.Drawing.Point(273, 122);
            this.btnbrowe1.Margin = new System.Windows.Forms.Padding(5);
            this.btnbrowe1.Name = "btnbrowe1";
            this.btnbrowe1.Size = new System.Drawing.Size(135, 41);
            this.btnbrowe1.TabIndex = 34;
            this.btnbrowe1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowe1.Click += new System.EventHandler(this.btnbrowe1_Click);
            // 
            // btnbackup
            // 
            this.btnbackup.ActiveBorderThickness = 1;
            this.btnbackup.ActiveCornerRadius = 20;
            this.btnbackup.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.ActiveForecolor = System.Drawing.Color.White;
            this.btnbackup.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.BackColor = System.Drawing.SystemColors.Control;
            this.btnbackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbackup.BackgroundImage")));
            this.btnbackup.ButtonText = "Backup DB";
            this.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.IdleBorderThickness = 1;
            this.btnbackup.IdleCornerRadius = 20;
            this.btnbackup.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbackup.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbackup.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbackup.Location = new System.Drawing.Point(28, 162);
            this.btnbackup.Margin = new System.Windows.Forms.Padding(5);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(112, 41);
            this.btnbackup.TabIndex = 33;
            this.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.ActiveBorderThickness = 1;
            this.btnbrowse.ActiveCornerRadius = 20;
            this.btnbrowse.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnbrowse.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnbrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowse.BackgroundImage")));
            this.btnbrowse.ButtonText = "Backup  Location";
            this.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.IdleBorderThickness = 1;
            this.btnbrowse.IdleCornerRadius = 20;
            this.btnbrowse.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnbrowse.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbrowse.Location = new System.Drawing.Point(273, 66);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(133, 41);
            this.btnbrowse.TabIndex = 32;
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtrestore
            // 
            this.txtrestore.BackColor = System.Drawing.Color.White;
            this.txtrestore.BorderColorFocused = System.Drawing.Color.Black;
            this.txtrestore.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtrestore.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtrestore.BorderThickness = 2;
            this.txtrestore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrestore.ForeColor = System.Drawing.Color.Black;
            this.txtrestore.isPassword = false;
            this.txtrestore.Location = new System.Drawing.Point(29, 127);
            this.txtrestore.Margin = new System.Windows.Forms.Padding(4);
            this.txtrestore.Name = "txtrestore";
            this.txtrestore.Size = new System.Drawing.Size(236, 34);
            this.txtrestore.TabIndex = 31;
            this.txtrestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BackupTextBox
            // 
            this.BackupTextBox.BackColor = System.Drawing.Color.White;
            this.BackupTextBox.BorderColorFocused = System.Drawing.Color.Black;
            this.BackupTextBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.BackupTextBox.BorderColorMouseHover = System.Drawing.Color.Black;
            this.BackupTextBox.BorderThickness = 2;
            this.BackupTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackupTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupTextBox.ForeColor = System.Drawing.Color.Black;
            this.BackupTextBox.isPassword = false;
            this.BackupTextBox.Location = new System.Drawing.Point(28, 70);
            this.BackupTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BackupTextBox.Name = "BackupTextBox";
            this.BackupTextBox.Size = new System.Drawing.Size(236, 34);
            this.BackupTextBox.TabIndex = 30;
            this.BackupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlname
            // 
            this.pnlname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlname.Controls.Add(this.pict);
            this.pnlname.Controls.Add(this.label1);
            this.pnlname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlname.Location = new System.Drawing.Point(5, 10);
            this.pnlname.Name = "pnlname";
            this.pnlname.Size = new System.Drawing.Size(444, 42);
            this.pnlname.TabIndex = 40;
            // 
            // pict
            // 
            this.pict.Dock = System.Windows.Forms.DockStyle.Right;
            this.pict.Image = global::Stock.Properties.Resources.web_close;
            this.pict.Location = new System.Drawing.Point(387, 0);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(55, 40);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict.TabIndex = 9;
            this.pict.TabStop = false;
            this.pict.Click += new System.EventHandler(this.pict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Backup";
            // 
            // frmbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.pnlname);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblcmp);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.btnbrowe1);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtrestore);
            this.Controls.Add(this.BackupTextBox);
            this.Controls.Add(this.d_btm);
            this.Controls.Add(this.d_right);
            this.Controls.Add(this.dleft);
            this.Controls.Add(this.dtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbackup";
            this.Load += new System.EventHandler(this.frmbackup_Load);
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dtop;
        private System.Windows.Forms.Panel dleft;
        private System.Windows.Forms.Panel d_right;
        private System.Windows.Forms.Panel d_btm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblcmp;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prb;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbrowe1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbrowse;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtrestore;
        private Bunifu.Framework.UI.BunifuMetroTextbox BackupTextBox;
        private System.Windows.Forms.Panel pnlname;
        public System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Label label1;
    }
}