namespace Stock
{
    partial class frmdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdashboard));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_custBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cust = new Stock.cust();
            this.dtop = new System.Windows.Forms.Panel();
            this.dleft = new System.Windows.Forms.Panel();
            this.d_right = new System.Windows.Forms.Panel();
            this.d_btm = new System.Windows.Forms.Panel();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btndb = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.btnbillview = new System.Windows.Forms.Button();
            this.btnstock = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.pnlname = new System.Windows.Forms.Panel();
            this.pict = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlfrm = new System.Windows.Forms.Panel();
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.crpt = new System.Windows.Forms.Panel();
            this.btnlst = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlcustomer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.billno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosstot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlpay = new System.Windows.Forms.Panel();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtsearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblamount = new System.Windows.Forms.Label();
            this.btnpay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnetpay = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblbillno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_custTableAdapter = new Stock.custTableAdapters.tbl_custTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_custBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust)).BeginInit();
            this.pnlmenu.SuspendLayout();
            this.pnlname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.pnlfrm.SuspendLayout();
            this.pnldashboard.SuspendLayout();
            this.panel5.SuspendLayout();
            this.crpt.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlcustomer.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlpay.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_custBindingSource
            // 
            this.tbl_custBindingSource.DataMember = "tbl_cust";
            this.tbl_custBindingSource.DataSource = this.cust;
            // 
            // cust
            // 
            this.cust.DataSetName = "cust";
            this.cust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtop
            // 
            this.dtop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtop.Location = new System.Drawing.Point(0, 0);
            this.dtop.Name = "dtop";
            this.dtop.Size = new System.Drawing.Size(1246, 10);
            this.dtop.TabIndex = 1;
            this.dtop.Paint += new System.Windows.Forms.PaintEventHandler(this.dtop_Paint);
            // 
            // dleft
            // 
            this.dleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft.Location = new System.Drawing.Point(0, 10);
            this.dleft.Name = "dleft";
            this.dleft.Size = new System.Drawing.Size(5, 615);
            this.dleft.TabIndex = 2;
            this.dleft.Paint += new System.Windows.Forms.PaintEventHandler(this.dleft_Paint);
            // 
            // d_right
            // 
            this.d_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_right.Location = new System.Drawing.Point(1241, 10);
            this.d_right.Name = "d_right";
            this.d_right.Size = new System.Drawing.Size(5, 615);
            this.d_right.TabIndex = 3;
            this.d_right.Paint += new System.Windows.Forms.PaintEventHandler(this.d_right_Paint);
            // 
            // d_btm
            // 
            this.d_btm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_btm.Location = new System.Drawing.Point(5, 620);
            this.d_btm.Name = "d_btm";
            this.d_btm.Size = new System.Drawing.Size(1236, 5);
            this.d_btm.TabIndex = 4;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmenu.Controls.Add(this.btndb);
            this.pnlmenu.Controls.Add(this.btnsale);
            this.pnlmenu.Controls.Add(this.btnbillview);
            this.pnlmenu.Controls.Add(this.btnstock);
            this.pnlmenu.Controls.Add(this.btnuser);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(5, 52);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(142, 568);
            this.pnlmenu.TabIndex = 7;
            this.pnlmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmenu_Paint);
            // 
            // btndb
            // 
            this.btndb.BackColor = System.Drawing.Color.Transparent;
            this.btndb.BackgroundImage = global::Stock.Properties.Resources.db1;
            this.btndb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndb.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndb.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndb.ForeColor = System.Drawing.Color.White;
            this.btndb.Location = new System.Drawing.Point(3, 444);
            this.btndb.Name = "btndb";
            this.btndb.Size = new System.Drawing.Size(131, 120);
            this.btndb.TabIndex = 14;
            this.btndb.Text = "DBBackup/Restore";
            this.btndb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndb.UseVisualStyleBackColor = false;
            this.btndb.Click += new System.EventHandler(this.btndb_Click);
            this.btndb.MouseEnter += new System.EventHandler(this.btndb_MouseEnter);
            this.btndb.MouseHover += new System.EventHandler(this.btndb_MouseHover);
            // 
            // btnsale
            // 
            this.btnsale.BackColor = System.Drawing.Color.Transparent;
            this.btnsale.BackgroundImage = global::Stock.Properties.Resources.sal;
            this.btnsale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsale.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsale.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsale.ForeColor = System.Drawing.Color.White;
            this.btnsale.Location = new System.Drawing.Point(6, 223);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(128, 112);
            this.btnsale.TabIndex = 13;
            this.btnsale.Text = "Sale";
            this.btnsale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsale.UseVisualStyleBackColor = false;
            this.btnsale.Click += new System.EventHandler(this.button1_Click_1);
            this.btnsale.MouseEnter += new System.EventHandler(this.btnsale_MouseEnter);
            this.btnsale.MouseHover += new System.EventHandler(this.btnsale_MouseHover);
            // 
            // btnbillview
            // 
            this.btnbillview.BackColor = System.Drawing.Color.Transparent;
            this.btnbillview.BackgroundImage = global::Stock.Properties.Resources.blist;
            this.btnbillview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbillview.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbillview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbillview.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillview.ForeColor = System.Drawing.Color.White;
            this.btnbillview.Location = new System.Drawing.Point(4, 341);
            this.btnbillview.Name = "btnbillview";
            this.btnbillview.Size = new System.Drawing.Size(133, 105);
            this.btnbillview.TabIndex = 12;
            this.btnbillview.Text = "Bill List";
            this.btnbillview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbillview.UseVisualStyleBackColor = false;
            this.btnbillview.Click += new System.EventHandler(this.btnbillview_Click);
            this.btnbillview.MouseEnter += new System.EventHandler(this.btndashboard_MouseEnter);
            this.btnbillview.MouseHover += new System.EventHandler(this.btndashboard_MouseHover);
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.Transparent;
            this.btnstock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstock.BackgroundImage")));
            this.btnstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnstock.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.Location = new System.Drawing.Point(8, 118);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(128, 99);
            this.btnstock.TabIndex = 11;
            this.btnstock.Text = "Stock/Product";
            this.btnstock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            this.btnstock.MouseEnter += new System.EventHandler(this.btnstock_MouseEnter);
            this.btnstock.MouseHover += new System.EventHandler(this.btnstock_MouseHover);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.Transparent;
            this.btnuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnuser.BackgroundImage")));
            this.btnuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnuser.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Location = new System.Drawing.Point(3, 7);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(133, 105);
            this.btnuser.TabIndex = 10;
            this.btnuser.Text = " Company/Customer";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            this.btnuser.MouseEnter += new System.EventHandler(this.btnuser_MouseEnter);
            this.btnuser.MouseHover += new System.EventHandler(this.btnuser_MouseHover);
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
            this.pnlname.Size = new System.Drawing.Size(1236, 42);
            this.pnlname.TabIndex = 6;
            // 
            // pict
            // 
            this.pict.Dock = System.Windows.Forms.DockStyle.Right;
            this.pict.Image = global::Stock.Properties.Resources.web_close;
            this.pict.Location = new System.Drawing.Point(1179, 0);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(330, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shree Umiya Doors";
            // 
            // pnlfrm
            // 
            this.pnlfrm.Controls.Add(this.pnldashboard);
            this.pnlfrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfrm.Location = new System.Drawing.Point(147, 52);
            this.pnlfrm.Name = "pnlfrm";
            this.pnlfrm.Size = new System.Drawing.Size(1094, 568);
            this.pnlfrm.TabIndex = 8;
            this.pnlfrm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfrm_Paint);
            // 
            // pnldashboard
            // 
            this.pnldashboard.Controls.Add(this.panel5);
            this.pnldashboard.Controls.Add(this.crpt);
            this.pnldashboard.Controls.Add(this.panel2);
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(0, 0);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(1094, 568);
            this.pnldashboard.TabIndex = 0;
            this.pnldashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldashboard_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.reportViewer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 520);
            this.panel5.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_custBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.cust.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 520);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // crpt
            // 
            this.crpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt.Controls.Add(this.btnlst);
            this.crpt.Dock = System.Windows.Forms.DockStyle.Top;
            this.crpt.Location = new System.Drawing.Point(0, 0);
            this.crpt.Name = "crpt";
            this.crpt.Size = new System.Drawing.Size(680, 48);
            this.crpt.TabIndex = 1;
            // 
            // btnlst
            // 
            this.btnlst.ActiveBorderThickness = 1;
            this.btnlst.ActiveCornerRadius = 20;
            this.btnlst.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnlst.ActiveForecolor = System.Drawing.Color.White;
            this.btnlst.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnlst.BackColor = System.Drawing.SystemColors.Control;
            this.btnlst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlst.BackgroundImage")));
            this.btnlst.ButtonText = "Company List";
            this.btnlst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlst.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnlst.IdleBorderThickness = 1;
            this.btnlst.IdleCornerRadius = 20;
            this.btnlst.IdleFillColor = System.Drawing.Color.White;
            this.btnlst.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnlst.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnlst.Location = new System.Drawing.Point(8, 1);
            this.btnlst.Margin = new System.Windows.Forms.Padding(5);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(148, 43);
            this.btnlst.TabIndex = 73;
            this.btnlst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.pnlcustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(680, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 568);
            this.panel2.TabIndex = 0;
            // 
            // pnlcustomer
            // 
            this.pnlcustomer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlcustomer.Controls.Add(this.panel4);
            this.pnlcustomer.Controls.Add(this.dataGridView1);
            this.pnlcustomer.Controls.Add(this.pnlpay);
            this.pnlcustomer.Controls.Add(this.panel3);
            this.pnlcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlcustomer.Name = "pnlcustomer";
            this.pnlcustomer.Size = new System.Drawing.Size(414, 568);
            this.pnlcustomer.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lbltot);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 80);
            this.panel4.TabIndex = 22;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.Color.Black;
            this.lbltot.Location = new System.Drawing.Point(135, 10);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(24, 18);
            this.lbltot.TabIndex = 15;
            this.lbltot.Text = "00";
            this.lbltot.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billno,
            this.customer,
            this.customer1,
            this.mob,
            this.date,
            this.grosstot,
            this.billpay,
            this.billtype});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 423);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // billno
            // 
            this.billno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.billno.HeaderText = "Bill-No";
            this.billno.Name = "billno";
            this.billno.ReadOnly = true;
            this.billno.Width = 67;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // customer1
            // 
            this.customer1.HeaderText = "Customer1";
            this.customer1.Name = "customer1";
            this.customer1.ReadOnly = true;
            this.customer1.Visible = false;
            // 
            // mob
            // 
            this.mob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mob.HeaderText = "Mobile";
            this.mob.Name = "mob";
            this.mob.ReadOnly = true;
            this.mob.Visible = false;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // grosstot
            // 
            this.grosstot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grosstot.HeaderText = "Total";
            this.grosstot.Name = "grosstot";
            this.grosstot.ReadOnly = true;
            // 
            // billpay
            // 
            this.billpay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billpay.HeaderText = "NetPay";
            this.billpay.Name = "billpay";
            this.billpay.ReadOnly = true;
            // 
            // billtype
            // 
            this.billtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billtype.HeaderText = "Type";
            this.billtype.Name = "billtype";
            this.billtype.ReadOnly = true;
            this.billtype.Visible = false;
            // 
            // pnlpay
            // 
            this.pnlpay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpay.Controls.Add(this.lblresult);
            this.pnlpay.Controls.Add(this.txtsearch);
            this.pnlpay.Controls.Add(this.lblamount);
            this.pnlpay.Controls.Add(this.btnpay);
            this.pnlpay.Controls.Add(this.label12);
            this.pnlpay.Controls.Add(this.txtnetpay);
            this.pnlpay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlpay.Location = new System.Drawing.Point(0, 36);
            this.pnlpay.Name = "pnlpay";
            this.pnlpay.Size = new System.Drawing.Size(414, 109);
            this.pnlpay.TabIndex = 3;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(168, 78);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 16);
            this.lblresult.TabIndex = 91;
            this.lblresult.Text = "Find -Us";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderColor = System.Drawing.Color.Black;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(168, 45);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(204, 26);
            this.txtsearch.TabIndex = 92;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(17, 15);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(75, 24);
            this.lblamount.TabIndex = 75;
            this.lblamount.Text = "0000.00";
            // 
            // btnpay
            // 
            this.btnpay.ActiveBorderThickness = 1;
            this.btnpay.ActiveCornerRadius = 20;
            this.btnpay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnpay.ActiveForecolor = System.Drawing.Color.White;
            this.btnpay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnpay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpay.BackgroundImage")));
            this.btnpay.ButtonText = "Pay";
            this.btnpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnpay.IdleBorderThickness = 1;
            this.btnpay.IdleCornerRadius = 20;
            this.btnpay.IdleFillColor = System.Drawing.Color.White;
            this.btnpay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnpay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnpay.Location = new System.Drawing.Point(5, 44);
            this.btnpay.Margin = new System.Windows.Forms.Padding(5);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(121, 43);
            this.btnpay.TabIndex = 72;
            this.btnpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(165, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Net Pay";
            // 
            // txtnetpay
            // 
            this.txtnetpay.BorderColor = System.Drawing.Color.Black;
            this.txtnetpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetpay.Location = new System.Drawing.Point(254, 13);
            this.txtnetpay.Name = "txtnetpay";
            this.txtnetpay.Size = new System.Drawing.Size(118, 26);
            this.txtnetpay.TabIndex = 73;
            this.txtnetpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblbillno);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 36);
            this.panel3.TabIndex = 2;
            // 
            // lblbillno
            // 
            this.lblbillno.AutoSize = true;
            this.lblbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillno.Location = new System.Drawing.Point(321, 5);
            this.lblbillno.Name = "lblbillno";
            this.lblbillno.Size = new System.Drawing.Size(75, 24);
            this.lblbillno.TabIndex = 93;
            this.lblbillno.Text = "0000.00";
            this.lblbillno.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pending Bills Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(147, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 43);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(876, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "+917559448227";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stock.Properties.Resources.contact;
            this.pictureBox4.Location = new System.Drawing.Point(666, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(725, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Technical Support";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(278, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gandhi Market. Bhalchandra Blood Bank,latur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(208, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stock.Properties.Resources.contact;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "+91-7559448227";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_custTableAdapter
            // 
            this.tbl_custTableAdapter.ClearBeforeFill = true;
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlfrm);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnlname);
            this.Controls.Add(this.d_btm);
            this.Controls.Add(this.d_right);
            this.Controls.Add(this.dleft);
            this.Controls.Add(this.dtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_custBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.pnlfrm.ResumeLayout(false);
            this.pnldashboard.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.crpt.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlcustomer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlpay.ResumeLayout(false);
            this.pnlpay.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dtop;
        private System.Windows.Forms.Panel dleft;
        private System.Windows.Forms.Panel d_right;
        private System.Windows.Forms.Panel d_btm;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Panel pnlname;
        public System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlfrm;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnbillview;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlcustomer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billno;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mob;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosstot;
        private System.Windows.Forms.DataGridViewTextBoxColumn billpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtype;
        private System.Windows.Forms.Panel pnlpay;
        private System.Windows.Forms.Label lblresult;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsearch;
        private System.Windows.Forms.Label lblamount;
        public Bunifu.Framework.UI.BunifuThinButton2 btnpay;
        private System.Windows.Forms.Label label12;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtnetpay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblbillno;
        private System.Windows.Forms.Button btndb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel crpt;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_custBindingSource;
        private cust cust;
        private custTableAdapters.tbl_custTableAdapter tbl_custTableAdapter;
        public Bunifu.Framework.UI.BunifuThinButton2 btnlst;

    }
}

