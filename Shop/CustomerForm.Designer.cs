namespace Shop
{
    partial class CustomerForm
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
            this.LB_phonenumber = new System.Windows.Forms.Label();
            this.LB_address = new System.Windows.Forms.Label();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_phonenumber
            // 
            this.LB_phonenumber.AutoSize = true;
            this.LB_phonenumber.Location = new System.Drawing.Point(12, 87);
            this.LB_phonenumber.Name = "LB_phonenumber";
            this.LB_phonenumber.Size = new System.Drawing.Size(73, 13);
            this.LB_phonenumber.TabIndex = 19;
            this.LB_phonenumber.Text = "Phonenumber";
            // 
            // LB_address
            // 
            this.LB_address.AutoSize = true;
            this.LB_address.Location = new System.Drawing.Point(12, 61);
            this.LB_address.Name = "LB_address";
            this.LB_address.Size = new System.Drawing.Size(39, 13);
            this.LB_address.TabIndex = 20;
            this.LB_address.Text = "Adress";
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Location = new System.Drawing.Point(12, 35);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(53, 13);
            this.LB_LastName.TabIndex = 21;
            this.LB_LastName.Text = "Lastname";
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Location = new System.Drawing.Point(12, 9);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(52, 13);
            this.LB_FirstName.TabIndex = 22;
            this.LB_FirstName.Text = "Firstname";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(28, 122);
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
            this.btnSaveClose.Location = new System.Drawing.Point(183, 122);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(149, 32);
            this.btnSaveClose.TabIndex = 17;
            this.btnSaveClose.Text = "Save/Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(92, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(256, 20);
            this.tbFirstName.TabIndex = 11;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(92, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(256, 20);
            this.tbLastName.TabIndex = 23;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(92, 58);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(256, 20);
            this.tbAdress.TabIndex = 24;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(92, 85);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(256, 20);
            this.tbPhoneNumber.TabIndex = 24;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 165);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.LB_phonenumber);
            this.Controls.Add(this.LB_address);
            this.Controls.Add(this.LB_LastName);
            this.Controls.Add(this.LB_FirstName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.tbFirstName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_phonenumber;
        private System.Windows.Forms.Label LB_address;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
    }
}