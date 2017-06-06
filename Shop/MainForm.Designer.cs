namespace Shop
{
    partial class MainForm
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.Label();
            this.LV_products = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewCustomers = new System.Windows.Forms.Label();
            this.LV_Customers = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_Orders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColShippingAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(495, 181);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(146, 32);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(12, 523);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(152, 32);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(495, 143);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(146, 32);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(492, 341);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(149, 32);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(495, 104);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(146, 33);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(12, 15);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(193, 24);
            this.lbProducts.TabIndex = 6;
            this.lbProducts.Text = "Products low on stock";
            // 
            // LV_products
            // 
            this.LV_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName,
            this.colPrice,
            this.colWeight,
            this.colQuantity});
            this.LV_products.FullRowSelect = true;
            this.LV_products.GridLines = true;
            this.LV_products.HideSelection = false;
            this.LV_products.Location = new System.Drawing.Point(12, 42);
            this.LV_products.MultiSelect = false;
            this.LV_products.Name = "LV_products";
            this.LV_products.Size = new System.Drawing.Size(474, 171);
            this.LV_products.TabIndex = 7;
            this.LV_products.UseCompatibleStateImageBehavior = false;
            this.LV_products.View = System.Windows.Forms.View.Details;
            // 
            // colid
            // 
            this.colid.Text = "ID";
            this.colid.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 100;
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight";
            this.colWeight.Width = 100;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 69;
            // 
            // NewCustomers
            // 
            this.NewCustomers.AutoSize = true;
            this.NewCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomers.Location = new System.Drawing.Point(8, 216);
            this.NewCustomers.Name = "NewCustomers";
            this.NewCustomers.Size = new System.Drawing.Size(168, 24);
            this.NewCustomers.TabIndex = 8;
            this.NewCustomers.Text = "Newest Customers";
            // 
            // LV_Customers
            // 
            this.LV_Customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.colLname,
            this.colAdress,
            this.colPhoneNumber});
            this.LV_Customers.FullRowSelect = true;
            this.LV_Customers.GridLines = true;
            this.LV_Customers.LabelWrap = false;
            this.LV_Customers.Location = new System.Drawing.Point(12, 243);
            this.LV_Customers.MultiSelect = false;
            this.LV_Customers.Name = "LV_Customers";
            this.LV_Customers.Size = new System.Drawing.Size(474, 130);
            this.LV_Customers.TabIndex = 9;
            this.LV_Customers.UseCompatibleStateImageBehavior = false;
            this.LV_Customers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 125;
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
            // LV_Orders
            // 
            this.LV_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ColOrderDate,
            this.ColShippingAdress,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LV_Orders.FullRowSelect = true;
            this.LV_Orders.GridLines = true;
            this.LV_Orders.LabelWrap = false;
            this.LV_Orders.Location = new System.Drawing.Point(12, 403);
            this.LV_Orders.MultiSelect = false;
            this.LV_Orders.Name = "LV_Orders";
            this.LV_Orders.Size = new System.Drawing.Size(629, 114);
            this.LV_Orders.TabIndex = 15;
            this.LV_Orders.UseCompatibleStateImageBehavior = false;
            this.LV_Orders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // ColOrderDate
            // 
            this.ColOrderDate.Text = "Orderdate";
            this.ColOrderDate.Width = 100;
            // 
            // ColShippingAdress
            // 
            this.ColShippingAdress.Text = "Shipping adress";
            this.ColShippingAdress.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firstname";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lastname";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adress";
            this.columnHeader5.Width = 99;
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrders.Location = new System.Drawing.Point(8, 376);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(117, 24);
            this.lbOrders.TabIndex = 16;
            this.lbOrders.Text = "Latest orders";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 565);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.LV_Orders);
            this.Controls.Add(this.LV_Customers);
            this.Controls.Add(this.NewCustomers);
            this.Controls.Add(this.LV_products);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnProducts);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.ListView LV_products;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.Label NewCustomers;
        private System.Windows.Forms.ListView LV_Customers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader colLname;
        private System.Windows.Forms.ColumnHeader colAdress;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.ListView LV_Orders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ColOrderDate;
        private System.Windows.Forms.ColumnHeader ColShippingAdress;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbOrders;
    }
}

