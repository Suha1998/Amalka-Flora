namespace AmalkaFlora
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnupload = new System.Windows.Forms.Button();
            this.pbpic = new System.Windows.Forms.PictureBox();
            this.tbsal = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbaddr = new System.Windows.Forms.TextBox();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblempType = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSelectEmp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNIC = new System.Windows.Forms.Label();
            this.tbnic = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Admin",
            "Delivery Employee",
            "Decorator",
            "Boquets Creater"});
            this.comboBox1.Location = new System.Drawing.Point(391, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.Olive;
            this.btnupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.Location = new System.Drawing.Point(511, 484);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(84, 37);
            this.btnupload.TabIndex = 33;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // pbpic
            // 
            this.pbpic.Location = new System.Drawing.Point(391, 462);
            this.pbpic.Name = "pbpic";
            this.pbpic.Size = new System.Drawing.Size(100, 111);
            this.pbpic.TabIndex = 32;
            this.pbpic.TabStop = false;
            // 
            // tbsal
            // 
            this.tbsal.Location = new System.Drawing.Point(391, 436);
            this.tbsal.Name = "tbsal";
            this.tbsal.Size = new System.Drawing.Size(344, 20);
            this.tbsal.TabIndex = 30;
            this.tbsal.TextChanged += new System.EventHandler(this.tbsal_TextChanged);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(391, 349);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(344, 20);
            this.tbemail.TabIndex = 29;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // tbaddr
            // 
            this.tbaddr.Location = new System.Drawing.Point(391, 307);
            this.tbaddr.Name = "tbaddr";
            this.tbaddr.Size = new System.Drawing.Size(344, 20);
            this.tbaddr.TabIndex = 28;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(391, 259);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(344, 20);
            this.tbcontact.TabIndex = 27;
            this.tbcontact.TextChanged += new System.EventHandler(this.tbcontact_TextChanged);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(391, 215);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(344, 20);
            this.tbname.TabIndex = 26;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(197, 487);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(56, 16);
            this.lblPhoto.TabIndex = 24;
            this.lblPhoto.Text = "Picture";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(197, 440);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(53, 16);
            this.lblSal.TabIndex = 23;
            this.lblSal.Text = "Salary";
            // 
            // lblempType
            // 
            this.lblempType.AutoSize = true;
            this.lblempType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempType.Location = new System.Drawing.Point(197, 397);
            this.lblempType.Name = "lblempType";
            this.lblempType.Size = new System.Drawing.Size(118, 16);
            this.lblempType.TabIndex = 22;
            this.lblempType.Text = "Employee Type";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(203, 353);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 16);
            this.lblemail.TabIndex = 21;
            this.lblemail.Text = "Email";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.Location = new System.Drawing.Point(197, 311);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(66, 16);
            this.lbladdr.TabIndex = 20;
            this.lbladdr.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(197, 263);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(118, 16);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(203, 220);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // btnSelectEmp
            // 
            this.btnSelectEmp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEmp.Location = new System.Drawing.Point(589, 170);
            this.btnSelectEmp.Name = "btnSelectEmp";
            this.btnSelectEmp.Size = new System.Drawing.Size(186, 31);
            this.btnSelectEmp.TabIndex = 38;
            this.btnSelectEmp.Text = "Select Employee";
            this.btnSelectEmp.UseVisualStyleBackColor = false;
            this.btnSelectEmp.Click += new System.EventHandler(this.btnSelectEmp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Olive;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(518, 642);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 51);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(243, 642);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 51);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(898, 12);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 62;
            this.btmMin.UseVisualStyleBackColor = true;
            this.btmMin.Click += new System.EventHandler(this.btmMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(960, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(197, 580);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(33, 16);
            this.lblNIC.TabIndex = 25;
            this.lblNIC.Text = "NIC";
            // 
            // tbnic
            // 
            this.tbnic.Location = new System.Drawing.Point(391, 579);
            this.tbnic.Name = "tbnic";
            this.tbnic.Size = new System.Drawing.Size(344, 20);
            this.tbnic.TabIndex = 31;
            this.tbnic.TextChanged += new System.EventHandler(this.tbnic_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(389, 170);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(81, 20);
            this.tbID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(8, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 34);
            this.btnBack.TabIndex = 64;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 65;
            this.label2.Text = "Edit Employees";
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 717);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectEmp);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.pbpic);
            this.Controls.Add(this.tbnic);
            this.Controls.Add(this.tbsal);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbaddr);
            this.Controls.Add(this.tbcontact);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblempType);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbladdr);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblempType;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSelectEmp;
        private System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.PictureBox pbpic;
        internal System.Windows.Forms.TextBox tbsal;
        internal System.Windows.Forms.TextBox tbemail;
        internal System.Windows.Forms.TextBox tbaddr;
        internal System.Windows.Forms.TextBox tbcontact;
        internal System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNIC;
        internal System.Windows.Forms.TextBox tbnic;
        internal System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}