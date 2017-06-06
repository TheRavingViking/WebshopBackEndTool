namespace Shop
{
    partial class SupplierForm
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
            this.LB_Phone = new System.Windows.Forms.Label();
            this.LB_Adress = new System.Windows.Forms.Label();
            this.LB_name = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Phone
            // 
            this.LB_Phone.AutoSize = true;
            this.LB_Phone.Location = new System.Drawing.Point(12, 61);
            this.LB_Phone.Name = "LB_Phone";
            this.LB_Phone.Size = new System.Drawing.Size(73, 13);
            this.LB_Phone.TabIndex = 20;
            this.LB_Phone.Text = "Phonenumber";
            // 
            // LB_Adress
            // 
            this.LB_Adress.AutoSize = true;
            this.LB_Adress.Location = new System.Drawing.Point(12, 35);
            this.LB_Adress.Name = "LB_Adress";
            this.LB_Adress.Size = new System.Drawing.Size(39, 13);
            this.LB_Adress.TabIndex = 21;
            this.LB_Adress.Text = "Adress";
            // 
            // LB_name
            // 
            this.LB_name.AutoSize = true;
            this.LB_name.Location = new System.Drawing.Point(12, 9);
            this.LB_name.Name = "LB_name";
            this.LB_name.Size = new System.Drawing.Size(35, 13);
            this.LB_name.TabIndex = 22;
            this.LB_name.Text = "Name";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(25, 84);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 32);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.Location = new System.Drawing.Point(180, 84);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(149, 32);
            this.btnSaveClose.TabIndex = 17;
            this.btnSaveClose.Text = "Save/Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 20);
            this.tbName.TabIndex = 11;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(91, 32);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(256, 20);
            this.tbAdress.TabIndex = 23;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(91, 58);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(256, 20);
            this.tbPhoneNumber.TabIndex = 24;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 126);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.LB_Phone);
            this.Controls.Add(this.LB_Adress);
            this.Controls.Add(this.LB_name);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.tbName);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_Phone;
        private System.Windows.Forms.Label LB_Adress;
        private System.Windows.Forms.Label LB_name;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
    }
}