namespace Shop
{
    partial class ProductOverviewForm
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
            this.LV_products = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.tb_ProductSearch = new System.Windows.Forms.TextBox();
            this.Lb_Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV_products
            // 
            this.LV_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName,
            this.colDescription,
            this.colPrice,
            this.colWeight,
            this.colQuantity});
            this.LV_products.FullRowSelect = true;
            this.LV_products.GridLines = true;
            this.LV_products.HideSelection = false;
            this.LV_products.Location = new System.Drawing.Point(12, 12);
            this.LV_products.MultiSelect = false;
            this.LV_products.Name = "LV_products";
            this.LV_products.Size = new System.Drawing.Size(660, 657);
            this.LV_products.TabIndex = 0;
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
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(678, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 62);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(678, 80);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(149, 62);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(678, 148);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(149, 62);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // tb_ProductSearch
            // 
            this.tb_ProductSearch.Location = new System.Drawing.Point(681, 244);
            this.tb_ProductSearch.Name = "tb_ProductSearch";
            this.tb_ProductSearch.Size = new System.Drawing.Size(146, 20);
            this.tb_ProductSearch.TabIndex = 6;
            this.tb_ProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ProductSearch_KeyDown);
            // 
            // Lb_Search
            // 
            this.Lb_Search.AutoSize = true;
            this.Lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_Search.Location = new System.Drawing.Point(678, 221);
            this.Lb_Search.Name = "Lb_Search";
            this.Lb_Search.Size = new System.Drawing.Size(119, 20);
            this.Lb_Search.TabIndex = 7;
            this.Lb_Search.Text = "Search Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(678, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter by category";
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(682, 309);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(145, 21);
            this.cbCategoryFilter.TabIndex = 10;
            this.cbCategoryFilter.SelectionChangeCommitted += new System.EventHandler(this.cbCategoryFilter_SelectionChangeCommitted);
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 180;
            // 
            // ProductOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 681);
            this.Controls.Add(this.cbCategoryFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Search);
            this.Controls.Add(this.tb_ProductSearch);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.LV_products);
            this.Name = "ProductOverviewForm";
            this.Text = "ProductForm";
            this.Activated += new System.EventHandler(this.ProductOverviewForm_Activated);
            this.Load += new System.EventHandler(this.ProductOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_products;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.TextBox tb_ProductSearch;
        private System.Windows.Forms.Label Lb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.ColumnHeader colDescription;
    }
}