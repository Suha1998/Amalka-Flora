namespace AmalkaFlora
{
    partial class OrderFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFlower));
            this.lblName = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblFlower = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.cbFlower = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(94, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(232, 189);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(274, 20);
            this.tbemail.TabIndex = 3;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(94, 189);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 16);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email";
            // 
            // lblFlower
            // 
            this.lblFlower.AutoSize = true;
            this.lblFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlower.Location = new System.Drawing.Point(96, 277);
            this.lblFlower.Name = "lblFlower";
            this.lblFlower.Size = new System.Drawing.Size(54, 16);
            this.lblFlower.TabIndex = 4;
            this.lblFlower.Text = "Flower";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(96, 324);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(94, 370);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(94, 424);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(96, 468);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(56, 16);
            this.lblBranch.TabIndex = 8;
            this.lblBranch.Text = "Branch";
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(232, 324);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(274, 20);
            this.tbquantity.TabIndex = 9;
            this.tbquantity.TextChanged += new System.EventHandler(this.tbquantity_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(232, 365);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(274, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // cbname
            // 
            this.cbname.FormattingEnabled = true;
            this.cbname.Items.AddRange(new object[] {
            "Flower Heaven (PVT)Ltd, Kandy",
            "PETALS  (PVT)Ltd, Nuwara Eliya",
            "Blooming  (PVT)Ltd, Mathale"});
            this.cbname.Location = new System.Drawing.Point(232, 134);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(274, 21);
            this.cbname.TabIndex = 11;
            // 
            // cbFlower
            // 
            this.cbFlower.FormattingEnabled = true;
            this.cbFlower.Items.AddRange(new object[] {
            "Red Roses",
            "White Roses",
            "Yellow Roses",
            "Red Tulips",
            "White Tulips",
            "Yellow Tulips",
            "Purple Orchids",
            "Red Gebera",
            "White Gebera",
            "Yellow Gebera"});
            this.cbFlower.Location = new System.Drawing.Point(232, 272);
            this.cbFlower.Name = "cbFlower";
            this.cbFlower.Size = new System.Drawing.Size(274, 21);
            this.cbFlower.TabIndex = 12;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "4.00 A.M.",
            "4.30 A.M.",
            "5.00 A.M.",
            "5.30 A.M.",
            "6.00 A.M.",
            "6.30 A.M.",
            "7.00 A.M.",
            "7.30 A.M.",
            "8.00 A.M.",
            "8.30 A.M.",
            "9.00 A.M.",
            "9.30 A.M.",
            "10.00 A.M.",
            "10.30 A.M.",
            "11.00 A.M.",
            "11.30 A.M.",
            "12.00 P.M",
            "12.30 P.M",
            "13.00 P.M",
            "13.30 P.M",
            "14.00 P.M",
            "14.30 P.M",
            "15.00 P.M",
            "15.30 P.M",
            "16.00 P.M",
            "16.30 P.M",
            "17.00 P.M",
            "17.30 P.M",
            "18.00 P.M",
            "18.30 P.M",
            "19.00 P.M"});
            this.cbTime.Location = new System.Drawing.Point(232, 424);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(274, 21);
            this.cbTime.TabIndex = 13;
            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Items.AddRange(new object[] {
            "Colombo",
            "Kelaniya",
            "Gampaha",
            "Negambo",
            "Kandy"});
            this.cbBranch.Location = new System.Drawing.Point(232, 468);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(274, 21);
            this.cbBranch.TabIndex = 14;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.Color.Olive;
            this.btnOrderNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.Location = new System.Drawing.Point(345, 522);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(180, 48);
            this.btnOrderNow.TabIndex = 15;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(232, 235);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(274, 20);
            this.tbcontact.TabIndex = 17;
            this.tbcontact.TextChanged += new System.EventHandler(this.tbcontact_TextChanged);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(94, 235);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(118, 16);
            this.lblcontact.TabIndex = 16;
            this.lblcontact.Text = "Contact Number";
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Olive;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(543, 134);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(180, 32);
            this.btnload.TabIndex = 18;
            this.btnload.Text = "Show Comany Details";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(876, 10);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 62;
            this.btmMin.UseVisualStyleBackColor = true;
            this.btmMin.Click += new System.EventHandler(this.btmMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(938, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 34);
            this.btnBack.TabIndex = 64;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 65;
            this.label1.Text = "Order Flowers";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // OrderFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.tbcontact);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbFlower);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbquantity);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblFlower);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblName);
            this.Name = "OrderFlower";
            this.Text = "OrderFlower";
            this.Load += new System.EventHandler(this.OrderFlower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbemail;
        internal System.Windows.Forms.Label lblemail;
        internal System.Windows.Forms.Label lblFlower;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.ComboBox cbFlower;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.TextBox tbcontact;
        internal System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}