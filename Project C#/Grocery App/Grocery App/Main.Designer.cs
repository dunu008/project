namespace Grocery_App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.btnFinancial = new System.Windows.Forms.Button();
            this.btnLoyalty = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStocs = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.lblPOS = new System.Windows.Forms.Label();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.pnlLoyalty = new System.Windows.Forms.Panel();
            this.lblLoyalty = new System.Windows.Forms.Label();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.lblStocks = new System.Windows.Forms.Label();
            this.pnlFinancial = new System.Windows.Forms.Panel();
            this.lblFinancial = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlPOS.SuspendLayout();
            this.pnlSuppliers.SuspendLayout();
            this.pnlLoyalty.SuspendLayout();
            this.pnlStocks.SuspendLayout();
            this.pnlFinancial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.pnlTop.Controls.Add(this.btnLock);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.lblUsername);
            this.pnlTop.Controls.Add(this.picAvatar);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.btnExpand);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1365, 72);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.Location = new System.Drawing.Point(1225, 1);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(70, 72);
            this.btnLock.TabIndex = 8;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(229, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 72);
            this.panel1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Deniyaya Stores - Kaldemulla, Moratuwa";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(126, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "UserAcc01";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(73, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1294, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.Location = new System.Drawing.Point(0, 0);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(59, 73);
            this.btnExpand.TabIndex = 3;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1332, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlIndicator);
            this.pnlLeft.Controls.Add(this.btnFinancial);
            this.pnlLeft.Controls.Add(this.btnLoyalty);
            this.pnlLeft.Controls.Add(this.btnSuppliers);
            this.pnlLeft.Controls.Add(this.btnPOS);
            this.pnlLeft.Controls.Add(this.btnDashboard);
            this.pnlLeft.Controls.Add(this.btnStocs);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(229, 701);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pnlIndicator.Location = new System.Drawing.Point(218, 0);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(10, 119);
            this.pnlIndicator.TabIndex = 2;
            // 
            // btnFinancial
            // 
            this.btnFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnFinancial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinancial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancial.Image")));
            this.btnFinancial.Location = new System.Drawing.Point(0, 594);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Size = new System.Drawing.Size(228, 107);
            this.btnFinancial.TabIndex = 0;
            this.btnFinancial.Text = "Financial Accounts";
            this.btnFinancial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinancial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinancial.UseVisualStyleBackColor = false;
            this.btnFinancial.Click += new System.EventHandler(this.btnFinancial_Click);
            // 
            // btnLoyalty
            // 
            this.btnLoyalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnLoyalty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoyalty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnLoyalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoyalty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoyalty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoyalty.Image = ((System.Drawing.Image)(resources.GetObject("btnLoyalty.Image")));
            this.btnLoyalty.Location = new System.Drawing.Point(0, 357);
            this.btnLoyalty.Name = "btnLoyalty";
            this.btnLoyalty.Size = new System.Drawing.Size(228, 119);
            this.btnLoyalty.TabIndex = 0;
            this.btnLoyalty.Text = "Loyalty Customers";
            this.btnLoyalty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoyalty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoyalty.UseVisualStyleBackColor = false;
            this.btnLoyalty.Click += new System.EventHandler(this.btnLoyalty_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Image")));
            this.btnSuppliers.Location = new System.Drawing.Point(0, 238);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(228, 119);
            this.btnSuppliers.TabIndex = 0;
            this.btnSuppliers.Text = "Supplier Accounts";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.Location = new System.Drawing.Point(0, 119);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(228, 119);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "Point of Sales";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 119);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStocs
            // 
            this.btnStocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnStocs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnStocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStocs.Image = ((System.Drawing.Image)(resources.GetObject("btnStocs.Image")));
            this.btnStocs.Location = new System.Drawing.Point(0, 473);
            this.btnStocs.Name = "btnStocs";
            this.btnStocs.Size = new System.Drawing.Size(228, 122);
            this.btnStocs.TabIndex = 3;
            this.btnStocs.Text = "Stocks";
            this.btnStocs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStocs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStocs.UseVisualStyleBackColor = false;
            this.btnStocs.Click += new System.EventHandler(this.btnStocs_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDashboard.Location = new System.Drawing.Point(21, 22);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(113, 22);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(232, 72);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1133, 702);
            this.pnlDashboard.TabIndex = 2;
            // 
            // pnlPOS
            // 
            this.pnlPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlPOS.Controls.Add(this.lblPOS);
            this.pnlPOS.Location = new System.Drawing.Point(232, 72);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1121, 702);
            this.pnlPOS.TabIndex = 2;
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPOS.Location = new System.Drawing.Point(20, 22);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(127, 22);
            this.lblPOS.TabIndex = 0;
            this.lblPOS.Text = "Point of Sales";
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlSuppliers.Controls.Add(this.lblSuppliers);
            this.pnlSuppliers.Location = new System.Drawing.Point(232, 72);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(1130, 702);
            this.pnlSuppliers.TabIndex = 2;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuppliers.Location = new System.Drawing.Point(20, 22);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(175, 22);
            this.lblSuppliers.TabIndex = 0;
            this.lblSuppliers.Text = "Supplier Accounts";
            // 
            // pnlLoyalty
            // 
            this.pnlLoyalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlLoyalty.Controls.Add(this.lblLoyalty);
            this.pnlLoyalty.Location = new System.Drawing.Point(232, 72);
            this.pnlLoyalty.Name = "pnlLoyalty";
            this.pnlLoyalty.Size = new System.Drawing.Size(1127, 702);
            this.pnlLoyalty.TabIndex = 2;
            // 
            // lblLoyalty
            // 
            this.lblLoyalty.AutoSize = true;
            this.lblLoyalty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoyalty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLoyalty.Location = new System.Drawing.Point(20, 22);
            this.lblLoyalty.Name = "lblLoyalty";
            this.lblLoyalty.Size = new System.Drawing.Size(176, 22);
            this.lblLoyalty.TabIndex = 0;
            this.lblLoyalty.Text = "Loyalty Customers";
            // 
            // pnlStocks
            // 
            this.pnlStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlStocks.Controls.Add(this.lblStocks);
            this.pnlStocks.Location = new System.Drawing.Point(232, 72);
            this.pnlStocks.Name = "pnlStocks";
            this.pnlStocks.Size = new System.Drawing.Size(1124, 702);
            this.pnlStocks.TabIndex = 2;
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStocks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStocks.Location = new System.Drawing.Point(20, 22);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(67, 22);
            this.lblStocks.TabIndex = 0;
            this.lblStocks.Text = "Stocks";
            // 
            // pnlFinancial
            // 
            this.pnlFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.pnlFinancial.Controls.Add(this.lblFinancial);
            this.pnlFinancial.Location = new System.Drawing.Point(229, 72);
            this.pnlFinancial.Name = "pnlFinancial";
            this.pnlFinancial.Size = new System.Drawing.Size(1124, 702);
            this.pnlFinancial.TabIndex = 2;
            // 
            // lblFinancial
            // 
            this.lblFinancial.AutoSize = true;
            this.lblFinancial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFinancial.Location = new System.Drawing.Point(23, 22);
            this.lblFinancial.Name = "lblFinancial";
            this.lblFinancial.Size = new System.Drawing.Size(184, 22);
            this.lblFinancial.TabIndex = 0;
            this.lblFinancial.Text = "Financial Accounts";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1365, 773);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlFinancial);
            this.Controls.Add(this.pnlStocks);
            this.Controls.Add(this.pnlLoyalty);
            this.Controls.Add(this.pnlSuppliers);
            this.Controls.Add(this.pnlPOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlPOS.ResumeLayout(false);
            this.pnlPOS.PerformLayout();
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlSuppliers.PerformLayout();
            this.pnlLoyalty.ResumeLayout(false);
            this.pnlLoyalty.PerformLayout();
            this.pnlStocks.ResumeLayout(false);
            this.pnlStocks.PerformLayout();
            this.pnlFinancial.ResumeLayout(false);
            this.pnlFinancial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnFinancial;
        private System.Windows.Forms.Button btnLoyalty;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnStocs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlPOS;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Panel pnlLoyalty;
        private System.Windows.Forms.Label lblLoyalty;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.Panel pnlFinancial;
        private System.Windows.Forms.Label lblFinancial;
        private System.Windows.Forms.Button btnLock;
    }
}

