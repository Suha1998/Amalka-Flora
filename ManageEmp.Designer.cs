namespace AmalkaFlora
{
    partial class ManageEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmp));
            this.btnaddEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddEmp
            // 
            this.btnaddEmp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnaddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddEmp.Location = new System.Drawing.Point(176, 116);
            this.btnaddEmp.Name = "btnaddEmp";
            this.btnaddEmp.Size = new System.Drawing.Size(306, 55);
            this.btnaddEmp.TabIndex = 0;
            this.btnaddEmp.Text = "Add Employee";
            this.btnaddEmp.UseVisualStyleBackColor = false;
            this.btnaddEmp.Click += new System.EventHandler(this.btnaddEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.Location = new System.Drawing.Point(359, 202);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(306, 55);
            this.btnEditEmp.TabIndex = 1;
            this.btnEditEmp.Text = "Edit Employee";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(808, 12);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 62;
            this.btmMin.UseVisualStyleBackColor = true;
            this.btmMin.Click += new System.EventHandler(this.btmMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(870, 12);
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
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 34);
            this.btnBack.TabIndex = 64;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 480);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.btnaddEmp);
            this.Name = "ManageEmp";
            this.Text = "ManageEmp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
    }
}