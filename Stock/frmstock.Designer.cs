namespace Stock
{
    partial class frmstock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstock));
            this.d_btm = new System.Windows.Forms.Panel();
            this.d_right = new System.Windows.Forms.Panel();
            this.dleft = new System.Windows.Forms.Panel();
            this.dtop = new System.Windows.Forms.Panel();
            this.pnlname = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.txtsize = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtunit = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdis = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtsupid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblsup = new System.Windows.Forms.Label();
            this.txtpart = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cmbunit = new System.Windows.Forms.ComboBox();
            this.pnlbtm = new System.Windows.Forms.Panel();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtserach = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblamt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlfll = new System.Windows.Forms.Panel();
            this.dataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squarft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlact = new System.Windows.Forms.Panel();
            this.btnreset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnview = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btndelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltop.SuspendLayout();
            this.pnlbtm.SuspendLayout();
            this.pnlfll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlact.SuspendLayout();
            this.SuspendLayout();
            // 
            // d_btm
            // 
            this.d_btm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_btm.Location = new System.Drawing.Point(5, 396);
            this.d_btm.Name = "d_btm";
            this.d_btm.Size = new System.Drawing.Size(800, 5);
            this.d_btm.TabIndex = 17;
            // 
            // d_right
            // 
            this.d_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_right.Location = new System.Drawing.Point(805, 10);
            this.d_right.Name = "d_right";
            this.d_right.Size = new System.Drawing.Size(5, 391);
            this.d_right.TabIndex = 16;
            // 
            // dleft
            // 
            this.dleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft.Location = new System.Drawing.Point(0, 10);
            this.dleft.Name = "dleft";
            this.dleft.Size = new System.Drawing.Size(5, 391);
            this.dleft.TabIndex = 15;
            // 
            // dtop
            // 
            this.dtop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtop.Location = new System.Drawing.Point(0, 0);
            this.dtop.Name = "dtop";
            this.dtop.Size = new System.Drawing.Size(810, 10);
            this.dtop.TabIndex = 14;
            this.dtop.Paint += new System.Windows.Forms.PaintEventHandler(this.dtop_Paint);
            // 
            // pnlname
            // 
            this.pnlname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlname.Controls.Add(this.pictureBox1);
            this.pnlname.Controls.Add(this.label1);
            this.pnlname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlname.Location = new System.Drawing.Point(5, 10);
            this.pnlname.Name = "pnlname";
            this.pnlname.Size = new System.Drawing.Size(800, 36);
            this.pnlname.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Stock.Properties.Resources.web_close;
            this.pictureBox1.Location = new System.Drawing.Point(768, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Adding";
            // 
            // pnltop
            // 
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltop.Controls.Add(this.txtsize);
            this.pnltop.Controls.Add(this.txtunit);
            this.pnltop.Controls.Add(this.label2);
            this.pnltop.Controls.Add(this.label5);
            this.pnltop.Controls.Add(this.txtdis);
            this.pnltop.Controls.Add(this.txtsupid);
            this.pnltop.Controls.Add(this.lblsup);
            this.pnltop.Controls.Add(this.txtpart);
            this.pnltop.Controls.Add(this.cmbunit);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(259, 308);
            this.pnltop.TabIndex = 57;
            this.pnltop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltop_Paint);
            // 
            // txtsize
            // 
            this.txtsize.BorderColor = System.Drawing.Color.Black;
            this.txtsize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsize.Location = new System.Drawing.Point(12, 125);
            this.txtsize.Name = "txtsize";
            this.txtsize.ReadOnly = true;
            this.txtsize.Size = new System.Drawing.Size(221, 26);
            this.txtsize.TabIndex = 56;
            this.txtsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsize.TextChanged += new System.EventHandler(this.txtsize_TextChanged);
            // 
            // txtunit
            // 
            this.txtunit.BorderColor = System.Drawing.Color.Black;
            this.txtunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunit.Location = new System.Drawing.Point(13, 125);
            this.txtunit.Name = "txtunit";
            this.txtunit.ReadOnly = true;
            this.txtunit.Size = new System.Drawing.Size(110, 26);
            this.txtunit.TabIndex = 60;
            this.txtunit.Text = "1";
            this.txtunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Sqare Feet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Discription";
            // 
            // txtdis
            // 
            this.txtdis.BorderColor = System.Drawing.Color.Black;
            this.txtdis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdis.Location = new System.Drawing.Point(16, 186);
            this.txtdis.Multiline = true;
            this.txtdis.Name = "txtdis";
            this.txtdis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdis.Size = new System.Drawing.Size(220, 49);
            this.txtdis.TabIndex = 4;
            // 
            // txtsupid
            // 
            this.txtsupid.BorderColor = System.Drawing.Color.Black;
            this.txtsupid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupid.Location = new System.Drawing.Point(15, 6);
            this.txtsupid.Name = "txtsupid";
            this.txtsupid.ReadOnly = true;
            this.txtsupid.Size = new System.Drawing.Size(67, 26);
            this.txtsupid.TabIndex = 51;
            this.txtsupid.Visible = false;
            // 
            // lblsup
            // 
            this.lblsup.AutoSize = true;
            this.lblsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsup.Location = new System.Drawing.Point(13, 41);
            this.lblsup.Name = "lblsup";
            this.lblsup.Size = new System.Drawing.Size(104, 16);
            this.lblsup.TabIndex = 47;
            this.lblsup.Text = "Particular Name";
            this.lblsup.Click += new System.EventHandler(this.lblsup_Click);
            // 
            // txtpart
            // 
            this.txtpart.BorderColor = System.Drawing.Color.Black;
            this.txtpart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpart.Location = new System.Drawing.Point(13, 67);
            this.txtpart.Name = "txtpart";
            this.txtpart.Size = new System.Drawing.Size(220, 26);
            this.txtpart.TabIndex = 0;
            this.txtpart.TextChanged += new System.EventHandler(this.txtpart_TextChanged);
            // 
            // cmbunit
            // 
            this.cmbunit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbunit.FormattingEnabled = true;
            this.cmbunit.Items.AddRange(new object[] {
            "Kg",
            "Ltr"});
            this.cmbunit.Location = new System.Drawing.Point(130, 123);
            this.cmbunit.Name = "cmbunit";
            this.cmbunit.Size = new System.Drawing.Size(103, 28);
            this.cmbunit.TabIndex = 61;
            this.cmbunit.Visible = false;
            // 
            // pnlbtm
            // 
            this.pnlbtm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbtm.Controls.Add(this.lblsearch);
            this.pnlbtm.Controls.Add(this.txtserach);
            this.pnlbtm.Controls.Add(this.lblamt);
            this.pnlbtm.Controls.Add(this.label4);
            this.pnlbtm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbtm.Location = new System.Drawing.Point(5, 354);
            this.pnlbtm.Name = "pnlbtm";
            this.pnlbtm.Size = new System.Drawing.Size(800, 42);
            this.pnlbtm.TabIndex = 58;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(565, 12);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(55, 16);
            this.lblsearch.TabIndex = 63;
            this.lblsearch.Text = "Find-Us";
            // 
            // txtserach
            // 
            this.txtserach.BorderColor = System.Drawing.Color.Black;
            this.txtserach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtserach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserach.Location = new System.Drawing.Point(339, 7);
            this.txtserach.Name = "txtserach";
            this.txtserach.Size = new System.Drawing.Size(220, 26);
            this.txtserach.TabIndex = 62;
            this.txtserach.TextChanged += new System.EventHandler(this.txtserach_TextChanged);
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamt.Location = new System.Drawing.Point(276, 12);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(22, 16);
            this.lblamt.TabIndex = 59;
            this.lblamt.Text = "00";
            this.lblamt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total Particular Available ";
            // 
            // pnlfll
            // 
            this.pnlfll.Controls.Add(this.dataGridView);
            this.pnlfll.Controls.Add(this.pnlact);
            this.pnlfll.Controls.Add(this.pnltop);
            this.pnlfll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfll.Location = new System.Drawing.Point(5, 46);
            this.pnlfll.Name = "pnlfll";
            this.pnlfll.Size = new System.Drawing.Size(800, 308);
            this.pnlfll.TabIndex = 59;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stk_id,
            this.particular,
            this.squarft,
            this.unit,
            this.unitsym,
            this.part_desc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.DoubleBuffered = true;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.Location = new System.Drawing.Point(259, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(541, 262);
            this.dataGridView.TabIndex = 59;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // stk_id
            // 
            this.stk_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stk_id.HeaderText = "Stock-ID";
            this.stk_id.Name = "stk_id";
            this.stk_id.ReadOnly = true;
            this.stk_id.Width = 81;
            // 
            // particular
            // 
            this.particular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.particular.HeaderText = "Particular";
            this.particular.Name = "particular";
            this.particular.ReadOnly = true;
            // 
            // squarft
            // 
            this.squarft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.squarft.HeaderText = "Sqft";
            this.squarft.Name = "squarft";
            this.squarft.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.HeaderText = "Qty";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Visible = false;
            // 
            // unitsym
            // 
            this.unitsym.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.unitsym.HeaderText = "Unit";
            this.unitsym.Name = "unitsym";
            this.unitsym.ReadOnly = true;
            this.unitsym.Visible = false;
            // 
            // part_desc
            // 
            this.part_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.part_desc.HeaderText = "Description";
            this.part_desc.Name = "part_desc";
            this.part_desc.ReadOnly = true;
            // 
            // pnlact
            // 
            this.pnlact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlact.Controls.Add(this.btnreset);
            this.pnlact.Controls.Add(this.btnview);
            this.pnlact.Controls.Add(this.btnupdate);
            this.pnlact.Controls.Add(this.btndelete);
            this.pnlact.Controls.Add(this.btnsave);
            this.pnlact.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlact.Location = new System.Drawing.Point(259, 0);
            this.pnlact.Name = "pnlact";
            this.pnlact.Size = new System.Drawing.Size(541, 46);
            this.pnlact.TabIndex = 58;
            // 
            // btnreset
            // 
            this.btnreset.ActiveBorderThickness = 1;
            this.btnreset.ActiveCornerRadius = 20;
            this.btnreset.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnreset.ActiveForecolor = System.Drawing.Color.White;
            this.btnreset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreset.BackgroundImage")));
            this.btnreset.ButtonText = "Reset";
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnreset.IdleBorderThickness = 1;
            this.btnreset.IdleCornerRadius = 20;
            this.btnreset.IdleFillColor = System.Drawing.Color.White;
            this.btnreset.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnreset.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnreset.Location = new System.Drawing.Point(408, 2);
            this.btnreset.Margin = new System.Windows.Forms.Padding(5);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 41);
            this.btnreset.TabIndex = 5;
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnview
            // 
            this.btnview.ActiveBorderThickness = 1;
            this.btnview.ActiveCornerRadius = 20;
            this.btnview.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnview.ActiveForecolor = System.Drawing.Color.White;
            this.btnview.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnview.BackgroundImage")));
            this.btnview.ButtonText = "View";
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnview.IdleBorderThickness = 1;
            this.btnview.IdleCornerRadius = 20;
            this.btnview.IdleFillColor = System.Drawing.Color.White;
            this.btnview.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnview.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnview.Location = new System.Drawing.Point(310, 3);
            this.btnview.Margin = new System.Windows.Forms.Padding(5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(94, 41);
            this.btnview.TabIndex = 4;
            this.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ActiveBorderThickness = 1;
            this.btnupdate.ActiveCornerRadius = 20;
            this.btnupdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.IdleBorderThickness = 1;
            this.btnupdate.IdleCornerRadius = 20;
            this.btnupdate.IdleFillColor = System.Drawing.Color.White;
            this.btnupdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnupdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnupdate.Location = new System.Drawing.Point(209, 3);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 41);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btndelete.ActiveForecolor = System.Drawing.Color.White;
            this.btndelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.ButtonText = "Delete";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 20;
            this.btndelete.IdleFillColor = System.Drawing.Color.White;
            this.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Location = new System.Drawing.Point(112, 3);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "Save";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 20;
            this.btnsave.IdleFillColor = System.Drawing.Color.White;
            this.btnsave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsave.Location = new System.Drawing.Point(5, 3);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 41);
            this.btnsave.TabIndex = 1;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 401);
            this.Controls.Add(this.pnlfll);
            this.Controls.Add(this.pnlbtm);
            this.Controls.Add(this.pnlname);
            this.Controls.Add(this.d_btm);
            this.Controls.Add(this.d_right);
            this.Controls.Add(this.dleft);
            this.Controls.Add(this.dtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmstock";
            this.Load += new System.EventHandler(this.frmstock_Load);
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlbtm.ResumeLayout(false);
            this.pnlbtm.PerformLayout();
            this.pnlfll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel d_btm;
        private System.Windows.Forms.Panel d_right;
        private System.Windows.Forms.Panel dleft;
        private System.Windows.Forms.Panel dtop;
        private System.Windows.Forms.Panel pnlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label label5;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtdis;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtsupid;
        private System.Windows.Forms.Label lblsup;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtpart;
        private System.Windows.Forms.Panel pnlbtm;
        private System.Windows.Forms.Panel pnlfll;
        private System.Windows.Forms.Label label2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtsize;
        private System.Windows.Forms.Panel pnlact;
        public Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        public Bunifu.Framework.UI.BunifuThinButton2 btndelete;
        public Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        public Bunifu.Framework.UI.BunifuThinButton2 btnview;
        public Bunifu.Framework.UI.BunifuThinButton2 btnreset;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtunit;
        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox cmbunit;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtserach;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn particular;
        private System.Windows.Forms.DataGridViewTextBoxColumn squarft;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsym;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_desc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}