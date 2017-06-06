namespace Shop
{
    partial class OrderForm
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
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddProductToCart = new System.Windows.Forms.Button();
            this.lb_Customers = new System.Windows.Forms.Label();
            this.lb_products = new System.Windows.Forms.Label();
            this.lb_ShoppingCart = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.BtnDeleteProductFromShoppingCart = new System.Windows.Forms.Button();
            this.LV_Products = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_ShoppingCart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_Customers = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(138, 683);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(124, 42);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 683);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 42);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQuantity.Location = new System.Drawing.Point(364, 314);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(103, 29);
            this.nmQuantity.TabIndex = 5;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddProductToCart
            // 
            this.btnAddProductToCart.Location = new System.Drawing.Point(473, 314);
            this.btnAddProductToCart.Name = "btnAddProductToCart";
            this.btnAddProductToCart.Size = new System.Drawing.Size(85, 28);
            this.btnAddProductToCart.TabIndex = 6;
            this.btnAddProductToCart.Text = "Add to cart";
            this.btnAddProductToCart.UseVisualStyleBackColor = true;
            this.btnAddProductToCart.Click += new System.EventHandler(this.btnAddProductToCart_Click);
            // 
            // lb_Customers
            // 
            this.lb_Customers.AutoSize = true;
            this.lb_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Customers.Location = new System.Drawing.Point(12, 20);
            this.lb_Customers.Name = "lb_Customers";
            this.lb_Customers.Size = new System.Drawing.Size(100, 24);
            this.lb_Customers.TabIndex = 7;
            this.lb_Customers.Text = "Customers";
            // 
            // lb_products
            // 
            this.lb_products.AutoSize = true;
            this.lb_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_products.Location = new System.Drawing.Point(360, 20);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(84, 24);
            this.lb_products.TabIndex = 8;
            this.lb_products.Text = "Products";
            // 
            // lb_ShoppingCart
            // 
            this.lb_ShoppingCart.AutoSize = true;
            this.lb_ShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShoppingCart.Location = new System.Drawing.Point(360, 356);
            this.lb_ShoppingCart.Name = "lb_ShoppingCart";
            this.lb_ShoppingCart.Size = new System.Drawing.Size(130, 24);
            this.lb_ShoppingCart.TabIndex = 9;
            this.lb_ShoppingCart.Text = "Shopping Cart";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(713, 683);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 42);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // BtnDeleteProductFromShoppingCart
            // 
            this.BtnDeleteProductFromShoppingCart.Location = new System.Drawing.Point(364, 683);
            this.BtnDeleteProductFromShoppingCart.Name = "BtnDeleteProductFromShoppingCart";
            this.BtnDeleteProductFromShoppingCart.Size = new System.Drawing.Size(124, 42);
            this.BtnDeleteProductFromShoppingCart.TabIndex = 11;
            this.BtnDeleteProductFromShoppingCart.Text = "Delete from cart";
            this.BtnDeleteProductFromShoppingCart.UseVisualStyleBackColor = true;
            this.BtnDeleteProductFromShoppingCart.Click += new System.EventHandler(this.BtnDeleteProductFromShoppingCart_Click);
            // 
            // LV_Products
            // 
            this.LV_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName,
            this.colPrice,
            this.colWeight,
            this.colQuantity});
            this.LV_Products.FullRowSelect = true;
            this.LV_Products.GridLines = true;
            this.LV_Products.HideSelection = false;
            this.LV_Products.Location = new System.Drawing.Point(364, 47);
            this.LV_Products.MultiSelect = false;
            this.LV_Products.Name = "LV_Products";
            this.LV_Products.Size = new System.Drawing.Size(475, 261);
            this.LV_Products.TabIndex = 12;
            this.LV_Products.UseCompatibleStateImageBehavior = false;
            this.LV_Products.View = System.Windows.Forms.View.Details;
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
            // LV_ShoppingCart
            // 
            this.LV_ShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.LV_ShoppingCart.FullRowSelect = true;
            this.LV_ShoppingCart.GridLines = true;
            this.LV_ShoppingCart.HideSelection = false;
            this.LV_ShoppingCart.Location = new System.Drawing.Point(364, 393);
            this.LV_ShoppingCart.MultiSelect = false;
            this.LV_ShoppingCart.Name = "LV_ShoppingCart";
            this.LV_ShoppingCart.Size = new System.Drawing.Size(475, 284);
            this.LV_ShoppingCart.TabIndex = 13;
            this.LV_ShoppingCart.UseCompatibleStateImageBehavior = false;
            this.LV_ShoppingCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 125;
            // 
            // LV_Customers
            // 
            this.LV_Customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.colLname});
            this.LV_Customers.FullRowSelect = true;
            this.LV_Customers.GridLines = true;
            this.LV_Customers.LabelWrap = false;
            this.LV_Customers.Location = new System.Drawing.Point(12, 47);
            this.LV_Customers.MultiSelect = false;
            this.LV_Customers.Name = "LV_Customers";
            this.LV_Customers.Size = new System.Drawing.Size(330, 630);
            this.LV_Customers.TabIndex = 14;
            this.LV_Customers.UseCompatibleStateImageBehavior = false;
            this.LV_Customers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Firstname";
            this.columnHeader9.Width = 125;
            // 
            // colLname
            // 
            this.colLname.Text = "Lastname";
            this.colLname.Width = 125;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 737);
            this.Controls.Add(this.LV_Customers);
            this.Controls.Add(this.LV_ShoppingCart);
            this.Controls.Add(this.LV_Products);
            this.Controls.Add(this.BtnDeleteProductFromShoppingCart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lb_ShoppingCart);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.lb_Customers);
            this.Controls.Add(this.btnAddProductToCart);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelectCustomer);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Button btnAddProductToCart;
        private System.Windows.Forms.Label lb_Customers;
        private System.Windows.Forms.Label lb_products;
        private System.Windows.Forms.Label lb_ShoppingCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button BtnDeleteProductFromShoppingCart;
        private System.Windows.Forms.ListView LV_Products;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ListView LV_ShoppingCart;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView LV_Customers;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader colLname;
    }
}