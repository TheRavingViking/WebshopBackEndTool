namespace Shop
{
    partial class OrderDetails
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
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lbLastname = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBOrderDate = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.lbShipadress = new System.Windows.Forms.Label();
            this.tbShipAdress = new System.Windows.Forms.TextBox();
            this.LV_ShoppingCart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Supplier = new System.Windows.Forms.Label();
            this.LB_Category = new System.Windows.Forms.Label();
            this.LB_Price = new System.Windows.Forms.Label();
            this.LB_weight = new System.Windows.Forms.Label();
            this.LB_name = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.nmWeight = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.label4);
            this.groupBoxCustomer.Controls.Add(this.tbPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.lbAdress);
            this.groupBoxCustomer.Controls.Add(this.tbAdress);
            this.groupBoxCustomer.Controls.Add(this.lbLastname);
            this.groupBoxCustomer.Controls.Add(this.tbLastname);
            this.groupBoxCustomer.Controls.Add(this.lbFirstname);
            this.groupBoxCustomer.Controls.Add(this.tbFirstname);
            this.groupBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(195, 224);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Ordered by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phonenumber";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Enabled = false;
            this.tbPhoneNumber.Location = new System.Drawing.Point(17, 189);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(153, 20);
            this.tbPhoneNumber.TabIndex = 9;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(18, 119);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(39, 13);
            this.lbAdress.TabIndex = 8;
            this.lbAdress.Text = "Adress";
            // 
            // tbAdress
            // 
            this.tbAdress.Enabled = false;
            this.tbAdress.Location = new System.Drawing.Point(17, 138);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(153, 20);
            this.tbAdress.TabIndex = 7;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(18, 74);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 6;
            this.lbLastname.Text = "Lastname";
            // 
            // tbLastname
            // 
            this.tbLastname.Enabled = false;
            this.tbLastname.Location = new System.Drawing.Point(17, 93);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(153, 20);
            this.tbLastname.TabIndex = 5;
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(18, 25);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(52, 13);
            this.lbFirstname.TabIndex = 4;
            this.lbFirstname.Text = "Firstname";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Enabled = false;
            this.tbFirstname.Location = new System.Drawing.Point(17, 44);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(153, 20);
            this.tbFirstname.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBOrderDate);
            this.groupBox1.Controls.Add(this.tbOrderDate);
            this.groupBox1.Controls.Add(this.lbShipadress);
            this.groupBox1.Controls.Add(this.tbShipAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order details";
            // 
            // LBOrderDate
            // 
            this.LBOrderDate.AutoSize = true;
            this.LBOrderDate.Location = new System.Drawing.Point(18, 77);
            this.LBOrderDate.Name = "LBOrderDate";
            this.LBOrderDate.Size = new System.Drawing.Size(57, 13);
            this.LBOrderDate.TabIndex = 14;
            this.LBOrderDate.Text = "Order date";
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Enabled = false;
            this.tbOrderDate.Location = new System.Drawing.Point(17, 96);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.Size = new System.Drawing.Size(153, 20);
            this.tbOrderDate.TabIndex = 13;
            // 
            // lbShipadress
            // 
            this.lbShipadress.AutoSize = true;
            this.lbShipadress.Location = new System.Drawing.Point(18, 25);
            this.lbShipadress.Name = "lbShipadress";
            this.lbShipadress.Size = new System.Drawing.Size(83, 13);
            this.lbShipadress.TabIndex = 12;
            this.lbShipadress.Text = "Shipping Adress";
            // 
            // tbShipAdress
            // 
            this.tbShipAdress.Enabled = false;
            this.tbShipAdress.Location = new System.Drawing.Point(17, 44);
            this.tbShipAdress.Name = "tbShipAdress";
            this.tbShipAdress.Size = new System.Drawing.Size(153, 20);
            this.tbShipAdress.TabIndex = 11;
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
            this.LV_ShoppingCart.Location = new System.Drawing.Point(213, 19);
            this.LV_ShoppingCart.MultiSelect = false;
            this.LV_ShoppingCart.Name = "LV_ShoppingCart";
            this.LV_ShoppingCart.Size = new System.Drawing.Size(475, 371);
            this.LV_ShoppingCart.TabIndex = 14;
            this.LV_ShoppingCart.UseCompatibleStateImageBehavior = false;
            this.LV_ShoppingCart.View = System.Windows.Forms.View.Details;
            this.LV_ShoppingCart.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_ShoppingCart_ItemSelectionChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDescription);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.tbSupplier);
            this.groupBox2.Controls.Add(this.tbCategory);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.LB_Supplier);
            this.groupBox2.Controls.Add(this.LB_Category);
            this.groupBox2.Controls.Add(this.LB_Price);
            this.groupBox2.Controls.Add(this.LB_weight);
            this.groupBox2.Controls.Add(this.LB_name);
            this.groupBox2.Controls.Add(this.nmPrice);
            this.groupBox2.Controls.Add(this.nmWeight);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(12, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 500);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(18, 316);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 30;
            this.lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Location = new System.Drawing.Point(17, 341);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(640, 144);
            this.tbDescription.TabIndex = 29;
            // 
            // tbSupplier
            // 
            this.tbSupplier.Enabled = false;
            this.tbSupplier.Location = new System.Drawing.Point(17, 265);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(305, 20);
            this.tbSupplier.TabIndex = 28;
            // 
            // tbCategory
            // 
            this.tbCategory.Enabled = false;
            this.tbCategory.Location = new System.Drawing.Point(17, 212);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(305, 20);
            this.tbCategory.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Supplier
            // 
            this.LB_Supplier.AutoSize = true;
            this.LB_Supplier.Location = new System.Drawing.Point(14, 249);
            this.LB_Supplier.Name = "LB_Supplier";
            this.LB_Supplier.Size = new System.Drawing.Size(45, 13);
            this.LB_Supplier.TabIndex = 19;
            this.LB_Supplier.Text = "Supplier";
            // 
            // LB_Category
            // 
            this.LB_Category.AutoSize = true;
            this.LB_Category.Location = new System.Drawing.Point(15, 192);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(49, 13);
            this.LB_Category.TabIndex = 20;
            this.LB_Category.Text = "Catagory";
            // 
            // LB_Price
            // 
            this.LB_Price.AutoSize = true;
            this.LB_Price.Location = new System.Drawing.Point(15, 136);
            this.LB_Price.Name = "LB_Price";
            this.LB_Price.Size = new System.Drawing.Size(31, 13);
            this.LB_Price.TabIndex = 21;
            this.LB_Price.Text = "Price";
            // 
            // LB_weight
            // 
            this.LB_weight.AutoSize = true;
            this.LB_weight.Location = new System.Drawing.Point(14, 80);
            this.LB_weight.Name = "LB_weight";
            this.LB_weight.Size = new System.Drawing.Size(41, 13);
            this.LB_weight.TabIndex = 22;
            this.LB_weight.Text = "Weight";
            // 
            // LB_name
            // 
            this.LB_name.AutoSize = true;
            this.LB_name.Location = new System.Drawing.Point(15, 28);
            this.LB_name.Name = "LB_name";
            this.LB_name.Size = new System.Drawing.Size(35, 13);
            this.LB_name.TabIndex = 23;
            this.LB_name.Text = "Name";
            // 
            // nmPrice
            // 
            this.nmPrice.Enabled = false;
            this.nmPrice.Location = new System.Drawing.Point(17, 157);
            this.nmPrice.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(305, 20);
            this.nmPrice.TabIndex = 16;
            this.nmPrice.ThousandsSeparator = true;
            // 
            // nmWeight
            // 
            this.nmWeight.Enabled = false;
            this.nmWeight.Location = new System.Drawing.Point(17, 99);
            this.nmWeight.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmWeight.Name = "nmWeight";
            this.nmWeight.Size = new System.Drawing.Size(305, 20);
            this.nmWeight.TabIndex = 15;
            this.nmWeight.ThousandsSeparator = true;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(18, 48);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(304, 20);
            this.tbName.TabIndex = 14;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 919);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LV_ShoppingCart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label LBOrderDate;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.Label lbShipadress;
        private System.Windows.Forms.TextBox tbShipAdress;
        private System.Windows.Forms.ListView LV_ShoppingCart;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Supplier;
        private System.Windows.Forms.Label LB_Category;
        private System.Windows.Forms.Label LB_Price;
        private System.Windows.Forms.Label LB_weight;
        private System.Windows.Forms.Label LB_name;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.NumericUpDown nmWeight;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
    }
}