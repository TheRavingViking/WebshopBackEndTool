namespace Shop
{
    partial class ProductForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.nmWeight = new System.Windows.Forms.NumericUpDown();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.LB_name = new System.Windows.Forms.Label();
            this.LB_weight = new System.Windows.Forms.Label();
            this.LB_Price = new System.Windows.Forms.Label();
            this.LB_Category = new System.Windows.Forms.Label();
            this.LB_Supplier = new System.Windows.Forms.Label();
            this.LBQuantity = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddpicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(60, 14);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 20);
            this.tbName.TabIndex = 0;
            // 
            // nmWeight
            // 
            this.nmWeight.Location = new System.Drawing.Point(60, 40);
            this.nmWeight.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmWeight.Name = "nmWeight";
            this.nmWeight.Size = new System.Drawing.Size(256, 20);
            this.nmWeight.TabIndex = 1;
            this.nmWeight.ThousandsSeparator = true;
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(60, 66);
            this.nmPrice.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(256, 20);
            this.nmPrice.TabIndex = 3;
            this.nmPrice.ThousandsSeparator = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(60, 92);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(256, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(60, 119);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(256, 21);
            this.cbSupplier.TabIndex = 6;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.Location = new System.Drawing.Point(167, 301);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(149, 32);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "Save/Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 301);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 32);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // LB_name
            // 
            this.LB_name.AutoSize = true;
            this.LB_name.Location = new System.Drawing.Point(9, 17);
            this.LB_name.Name = "LB_name";
            this.LB_name.Size = new System.Drawing.Size(35, 13);
            this.LB_name.TabIndex = 8;
            this.LB_name.Text = "Name";
            // 
            // LB_weight
            // 
            this.LB_weight.AutoSize = true;
            this.LB_weight.Location = new System.Drawing.Point(9, 43);
            this.LB_weight.Name = "LB_weight";
            this.LB_weight.Size = new System.Drawing.Size(41, 13);
            this.LB_weight.TabIndex = 8;
            this.LB_weight.Text = "Weight";
            // 
            // LB_Price
            // 
            this.LB_Price.AutoSize = true;
            this.LB_Price.Location = new System.Drawing.Point(9, 69);
            this.LB_Price.Name = "LB_Price";
            this.LB_Price.Size = new System.Drawing.Size(31, 13);
            this.LB_Price.TabIndex = 8;
            this.LB_Price.Text = "Price";
            // 
            // LB_Category
            // 
            this.LB_Category.AutoSize = true;
            this.LB_Category.Location = new System.Drawing.Point(9, 95);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(49, 13);
            this.LB_Category.TabIndex = 8;
            this.LB_Category.Text = "Catagory";
            // 
            // LB_Supplier
            // 
            this.LB_Supplier.AutoSize = true;
            this.LB_Supplier.Location = new System.Drawing.Point(9, 122);
            this.LB_Supplier.Name = "LB_Supplier";
            this.LB_Supplier.Size = new System.Drawing.Size(45, 13);
            this.LB_Supplier.TabIndex = 8;
            this.LB_Supplier.Text = "Supplier";
            // 
            // LBQuantity
            // 
            this.LBQuantity.AutoSize = true;
            this.LBQuantity.Location = new System.Drawing.Point(9, 151);
            this.LBQuantity.Name = "LBQuantity";
            this.LBQuantity.Size = new System.Drawing.Size(46, 13);
            this.LBQuantity.TabIndex = 9;
            this.LBQuantity.Text = "Quantity";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(60, 147);
            this.nmQuantity.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(256, 20);
            this.nmQuantity.TabIndex = 10;
            this.nmQuantity.ThousandsSeparator = true;
            // 
            // btnAddpicture
            // 
            this.btnAddpicture.Location = new System.Drawing.Point(444, 301);
            this.btnAddpicture.Name = "btnAddpicture";
            this.btnAddpicture.Size = new System.Drawing.Size(168, 32);
            this.btnAddpicture.TabIndex = 11;
            this.btnAddpicture.Text = "Add/Edit Picture";
            this.btnAddpicture.UseVisualStyleBackColor = true;
            this.btnAddpicture.Click += new System.EventHandler(this.btnAddpicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 281);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 206);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(304, 89);
            this.tbDescription.TabIndex = 14;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(12, 185);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Description";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 345);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddpicture);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.LBQuantity);
            this.Controls.Add(this.LB_Supplier);
            this.Controls.Add(this.LB_Category);
            this.Controls.Add(this.LB_Price);
            this.Controls.Add(this.LB_weight);
            this.Controls.Add(this.LB_name);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.nmWeight);
            this.Controls.Add(this.tbName);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nmWeight;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label LB_name;
        private System.Windows.Forms.Label LB_weight;
        private System.Windows.Forms.Label LB_Price;
        private System.Windows.Forms.Label LB_Category;
        private System.Windows.Forms.Label LB_Supplier;
        private System.Windows.Forms.Label LBQuantity;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Button btnAddpicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
    }
}