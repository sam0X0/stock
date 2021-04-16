namespace Stock
{
    partial class frmviewbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmviewbill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.d_btm = new System.Windows.Forms.Panel();
            this.d_right = new System.Windows.Forms.Panel();
            this.dleft = new System.Windows.Forms.Panel();
            this.dtop = new System.Windows.Forms.Panel();
            this.pnlname = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mrkcontact = new System.Windows.Forms.MaskedTextBox();
            this.btndelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtsearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnview = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mrkto = new System.Windows.Forms.MaskedTextBox();
            this.mrkfrm = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.billno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosstot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // d_btm
            // 
            this.d_btm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_btm.Location = new System.Drawing.Point(5, 458);
            this.d_btm.Name = "d_btm";
            this.d_btm.Size = new System.Drawing.Size(897, 5);
            this.d_btm.TabIndex = 16;
            // 
            // d_right
            // 
            this.d_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.d_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_right.Location = new System.Drawing.Point(902, 10);
            this.d_right.Name = "d_right";
            this.d_right.Size = new System.Drawing.Size(5, 453);
            this.d_right.TabIndex = 15;
            // 
            // dleft
            // 
            this.dleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft.Location = new System.Drawing.Point(0, 10);
            this.dleft.Name = "dleft";
            this.dleft.Size = new System.Drawing.Size(5, 453);
            this.dleft.TabIndex = 14;
            // 
            // dtop
            // 
            this.dtop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtop.Location = new System.Drawing.Point(0, 0);
            this.dtop.Name = "dtop";
            this.dtop.Size = new System.Drawing.Size(907, 10);
            this.dtop.TabIndex = 13;
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
            this.pnlname.Size = new System.Drawing.Size(897, 36);
            this.pnlname.TabIndex = 17;
            this.pnlname.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlname_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Stock.Properties.Resources.web_close;
            this.pictureBox1.Location = new System.Drawing.Point(865, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bills";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mrkcontact);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.mrkto);
            this.panel1.Controls.Add(this.mrkfrm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 72);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mrkcontact
            // 
            this.mrkcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mrkcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrkcontact.Location = new System.Drawing.Point(645, 26);
            this.mrkcontact.Mask = "(999) 000-0000";
            this.mrkcontact.Name = "mrkcontact";
            this.mrkcontact.Size = new System.Drawing.Size(121, 26);
            this.mrkcontact.TabIndex = 92;
            this.mrkcontact.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mrkcontact_MaskInputRejected);
            this.mrkcontact.Enter += new System.EventHandler(this.mrkcontact_Enter);
            this.mrkcontact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mrkcontact_KeyDown);
            this.mrkcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrkcontact_KeyPress);
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
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 20;
            this.btndelete.IdleFillColor = System.Drawing.Color.White;
            this.btndelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Location = new System.Drawing.Point(770, 20);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 38);
            this.btndelete.TabIndex = 91;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(464, 4);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 16);
            this.lblresult.TabIndex = 89;
            this.lblresult.Text = "Find -Us";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderColor = System.Drawing.Color.Black;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(458, 25);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(178, 26);
            this.txtsearch.TabIndex = 90;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "To";
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
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnview.IdleBorderThickness = 1;
            this.btnview.IdleCornerRadius = 20;
            this.btnview.IdleFillColor = System.Drawing.Color.White;
            this.btnview.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnview.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnview.Location = new System.Drawing.Point(348, 19);
            this.btnview.Margin = new System.Windows.Forms.Padding(5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(93, 38);
            this.btnview.TabIndex = 87;
            this.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // mrkto
            // 
            this.mrkto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrkto.Location = new System.Drawing.Point(233, 22);
            this.mrkto.Mask = "00-00-0000";
            this.mrkto.Name = "mrkto";
            this.mrkto.Size = new System.Drawing.Size(100, 29);
            this.mrkto.TabIndex = 86;
            // 
            // mrkfrm
            // 
            this.mrkfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrkfrm.Location = new System.Drawing.Point(89, 22);
            this.mrkfrm.Mask = "00-00-0000";
            this.mrkfrm.Name = "mrkfrm";
            this.mrkfrm.Size = new System.Drawing.Size(100, 29);
            this.mrkfrm.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 84;
            this.label2.Text = "From";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblnet);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblamount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 44);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Company";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(141, 16);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(26, 18);
            this.lblto.TabIndex = 4;
            this.lblto.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Net Pay";
            // 
            // lblnet
            // 
            this.lblnet.AutoSize = true;
            this.lblnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnet.Location = new System.Drawing.Point(551, 14);
            this.lblnet.Name = "lblnet";
            this.lblnet.Size = new System.Drawing.Size(67, 18);
            this.lblnet.TabIndex = 2;
            this.lblnet.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Pay";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(345, 14);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(67, 18);
            this.lblamount.TabIndex = 0;
            this.lblamount.Text = "0000.00";
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 118);
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
            this.dataGridView1.Size = new System.Drawing.Size(897, 296);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.customer.Visible = false;
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
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmviewbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlname);
            this.Controls.Add(this.d_btm);
            this.Controls.Add(this.d_right);
            this.Controls.Add(this.dleft);
            this.Controls.Add(this.dtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmviewbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmviewbill";
            this.Load += new System.EventHandler(this.frmviewbill_Load);
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel d_btm;
        private System.Windows.Forms.Panel d_right;
        private System.Windows.Forms.Panel dleft;
        private System.Windows.Forms.Panel dtop;
        private System.Windows.Forms.Panel pnlname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billno;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mob;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosstot;
        private System.Windows.Forms.DataGridViewTextBoxColumn billpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtype;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuThinButton2 btnview;
        private System.Windows.Forms.MaskedTextBox mrkto;
        private System.Windows.Forms.MaskedTextBox mrkfrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresult;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsearch;
        private System.Windows.Forms.Timer timer1;
        public Bunifu.Framework.UI.BunifuThinButton2 btndelete;
        public System.Windows.Forms.MaskedTextBox mrkcontact;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblto;
    }
}