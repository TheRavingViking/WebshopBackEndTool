namespace Shop
{
    partial class OrderOverviewForm
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
            this.Lb_Search = new System.Windows.Forms.Label();
            this.tb_CustomerSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.LV_Orders = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColShippingAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Lb_Search
            // 
            this.Lb_Search.AutoSize = true;
            this.Lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_Search.Location = new System.Drawing.Point(623, 155);
            this.Lb_Search.Name = "Lb_Search";
            this.Lb_Search.Size = new System.Drawing.Size(133, 20);
            this.Lb_Search.TabIndex = 19;
            this.Lb_Search.Text = "Search Customer";
            // 
            // tb_CustomerSearch
            // 
            this.tb_CustomerSearch.Location = new System.Drawing.Point(626, 178);
            this.tb_CustomerSearch.Name = "tb_CustomerSearch";
            this.tb_CustomerSearch.Size = new System.Drawing.Size(146, 20);
            this.tb_CustomerSearch.TabIndex = 18;
            this.tb_CustomerSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CustomerSearch_KeyDown);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(627, 80);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(149, 62);
            this.btnShowDetails.TabIndex = 15;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(627, 12);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(149, 62);
            this.btnAddOrder.TabIndex = 16;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // LV_Orders
            // 
            this.LV_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.ColOrderDate,
            this.ColShippingAdress,
            this.colName,
            this.colLname,
            this.colAdress});
            this.LV_Orders.FullRowSelect = true;
            this.LV_Orders.GridLines = true;
            this.LV_Orders.LabelWrap = false;
            this.LV_Orders.Location = new System.Drawing.Point(12, 12);
            this.LV_Orders.MultiSelect = false;
            this.LV_Orders.Name = "LV_Orders";
            this.LV_Orders.Size = new System.Drawing.Size(600, 657);
            this.LV_Orders.TabIndex = 14;
            this.LV_Orders.UseCompatibleStateImageBehavior = false;
            this.LV_Orders.View = System.Windows.Forms.View.Details;
            // 
            // colid
            // 
            this.colid.Text = "ID";
            this.colid.Width = 100;
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
            // colName
            // 
            this.colName.Text = "Firstname";
            this.colName.Width = 100;
            // 
            // colLname
            // 
            this.colLname.Text = "Lastname";
            this.colLname.Width = 100;
            // 
            // colAdress
            // 
            this.colAdress.Text = "Adress";
            this.colAdress.Width = 99;
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 684);
            this.Controls.Add(this.Lb_Search);
            this.Controls.Add(this.tb_CustomerSearch);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.LV_Orders);
            this.Name = "OrderOverviewForm";
            this.Text = "OrderOverview";
            this.Activated += new System.EventHandler(this.OrderOverviewForm_Activated);
            this.Load += new System.EventHandler(this.OrderOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Search;
        private System.Windows.Forms.TextBox tb_CustomerSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ListView LV_Orders;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLname;
        private System.Windows.Forms.ColumnHeader colAdress;
        private System.Windows.Forms.ColumnHeader ColOrderDate;
        private System.Windows.Forms.ColumnHeader ColShippingAdress;
    }
}