namespace AmalkaFlora
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnSysOp = new System.Windows.Forms.Button();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(130, 319);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 58);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogIn.Location = new System.Drawing.Point(438, 319);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(124, 58);
            this.btnLogIn.TabIndex = 19;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(230, 236);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(366, 20);
            this.textBoxPassword.TabIndex = 18;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(230, 186);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(366, 20);
            this.textBoxUsername.TabIndex = 17;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(56, 239);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(56, 192);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 20);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsignup.Location = new System.Drawing.Point(674, 319);
            this.btnsignup.Margin = new System.Windows.Forms.Padding(5);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(124, 58);
            this.btnsignup.TabIndex = 21;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnSysOp
            // 
            this.btnSysOp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSysOp.Location = new System.Drawing.Point(189, 449);
            this.btnSysOp.Name = "btnSysOp";
            this.btnSysOp.Size = new System.Drawing.Size(491, 23);
            this.btnSysOp.TabIndex = 22;
            this.btnSysOp.Text = "System Operation";
            this.btnSysOp.UseVisualStyleBackColor = false;
            this.btnSysOp.Click += new System.EventHandler(this.btnSysOp_Click);
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(785, 12);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 62;
            this.btmMin.UseVisualStyleBackColor = true;
            this.btmMin.Click += new System.EventHandler(this.btmMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(847, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 484);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSysOp);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "Interface1";
            this.Load += new System.EventHandler(this.Interface1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnSysOp;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
    }
}