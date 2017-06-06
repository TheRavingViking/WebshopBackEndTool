namespace Shop
{
    partial class CustomerOverviewForm
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
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.LV_Customers = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lb_Search = new System.Windows.Forms.Label();
            this.tb_CustomerSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(622, 147);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(149, 62);
            this.btnDeleteCustomer.TabIndex = 11;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Location = new System.Drawing.Point(622, 79);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(149, 62);
            this.btnEditCustomer.TabIndex = 7;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(622, 11);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(149, 62);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // LV_Customers
            // 
            this.LV_Customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName,
            this.colLname,
            this.colAdress,
            this.colPhoneNumber});
            this.LV_Customers.FullRowSelect = true;
            this.LV_Customers.GridLines = true;
            this.LV_Customers.LabelWrap = false;
            this.LV_Customers.Location = new System.Drawing.Point(11, 11);
            this.LV_Customers.MultiSelect = false;
            this.LV_Customers.Name = "LV_Customers";
            this.LV_Customers.Size = new System.Drawing.Size(605, 657);
            this.LV_Customers.TabIndex = 5;
            this.LV_Customers.UseCompatibleStateImageBehavior = false;
            this.LV_Customers.View = System.Windows.Forms.View.Details;
            // 
            // colid
            // 
            this.colid.Text = "ID";
            this.colid.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Firstname";
            this.colName.Width = 125;
            // 
            // colLname
            // 
            this.colLname.Text = "Lastname";
            this.colLname.Width = 125;
            // 
            // colAdress
            // 
            this.colAdress.Text = "Adress";
            this.colAdress.Width = 125;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phonenumber";
            this.colPhoneNumber.Width = 125;
            // 
            // Lb_Search
            // 
            this.Lb_Search.AutoSize = true;
            this.Lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_Search.Location = new System.Drawing.Point(622, 224);
            this.Lb_Search.Name = "Lb_Search";
            this.Lb_Search.Size = new System.Drawing.Size(133, 20);
            this.Lb_Search.TabIndex = 13;
            this.Lb_Search.Text = "Search Customer";
            // 
            // tb_CustomerSearch
            // 
            this.tb_CustomerSearch.Location = new System.Drawing.Point(625, 247);
            this.tb_CustomerSearch.Name = "tb_CustomerSearch";
            this.tb_CustomerSearch.Size = new System.Drawing.Size(146, 20);
            this.tb_CustomerSearch.TabIndex = 12;
            this.tb_CustomerSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CustomerSearch_KeyDown);
            // 
            // CustomerOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 681);
            this.Controls.Add(this.Lb_Search);
            this.Controls.Add(this.tb_CustomerSearch);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.LV_Customers);
            this.Name = "CustomerOverviewForm";
            this.Text = "Customer Overview ";
            this.Activated += new System.EventHandler(this.CustomerOverviewForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListView LV_Customers;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLname;
        private System.Windows.Forms.ColumnHeader colAdress;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.Label Lb_Search;
        private System.Windows.Forms.TextBox tb_CustomerSearch;
    }
}