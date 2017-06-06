namespace Shop
{
    partial class SuppliersOverviewForm
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
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.LV_Suppliers = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lb_Search = new System.Windows.Forms.Label();
            this.tb_SupplierSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Location = new System.Drawing.Point(623, 80);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(149, 62);
            this.btnEditSupplier.TabIndex = 13;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(623, 12);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(149, 62);
            this.btnAddSupplier.TabIndex = 14;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // LV_Suppliers
            // 
            this.LV_Suppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName,
            this.colAdress,
            this.colPhoneNumber});
            this.LV_Suppliers.FullRowSelect = true;
            this.LV_Suppliers.GridLines = true;
            this.LV_Suppliers.LabelWrap = false;
            this.LV_Suppliers.Location = new System.Drawing.Point(12, 12);
            this.LV_Suppliers.MultiSelect = false;
            this.LV_Suppliers.Name = "LV_Suppliers";
            this.LV_Suppliers.Size = new System.Drawing.Size(605, 657);
            this.LV_Suppliers.TabIndex = 12;
            this.LV_Suppliers.UseCompatibleStateImageBehavior = false;
            this.LV_Suppliers.View = System.Windows.Forms.View.Details;
            // 
            // colid
            // 
            this.colid.Text = "ID";
            this.colid.Width = 150;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colAdress
            // 
            this.colAdress.Text = "Adress";
            this.colAdress.Width = 150;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phonenumber";
            this.colPhoneNumber.Width = 150;
            // 
            // Lb_Search
            // 
            this.Lb_Search.AutoSize = true;
            this.Lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_Search.Location = new System.Drawing.Point(623, 154);
            this.Lb_Search.Name = "Lb_Search";
            this.Lb_Search.Size = new System.Drawing.Size(122, 20);
            this.Lb_Search.TabIndex = 16;
            this.Lb_Search.Text = "Search Supplier";
            // 
            // tb_SupplierSearch
            // 
            this.tb_SupplierSearch.Location = new System.Drawing.Point(626, 177);
            this.tb_SupplierSearch.Name = "tb_SupplierSearch";
            this.tb_SupplierSearch.Size = new System.Drawing.Size(146, 20);
            this.tb_SupplierSearch.TabIndex = 15;
            this.tb_SupplierSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SupplierSearch_KeyDown);
            // 
            // SuppliersOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 679);
            this.Controls.Add(this.Lb_Search);
            this.Controls.Add(this.tb_SupplierSearch);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.LV_Suppliers);
            this.Name = "SuppliersOverviewForm";
            this.Text = "SuppliersOverviewForm";
            this.Activated += new System.EventHandler(this.SuppliersOverviewForm_Activated);
            this.Load += new System.EventHandler(this.SuppliersOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ListView LV_Suppliers;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAdress;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.Label Lb_Search;
        private System.Windows.Forms.TextBox tb_SupplierSearch;
    }
}