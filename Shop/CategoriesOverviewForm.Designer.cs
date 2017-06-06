namespace Shop
{
    partial class CategoriesOverviewForm
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
            this.LV_categories = new System.Windows.Forms.ListView();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lb_Search = new System.Windows.Forms.Label();
            this.tb_CategorySearch = new System.Windows.Forms.TextBox();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LV_categories
            // 
            this.LV_categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colName});
            this.LV_categories.FullRowSelect = true;
            this.LV_categories.GridLines = true;
            this.LV_categories.LabelWrap = false;
            this.LV_categories.Location = new System.Drawing.Point(12, 12);
            this.LV_categories.MultiSelect = false;
            this.LV_categories.Name = "LV_categories";
            this.LV_categories.Size = new System.Drawing.Size(303, 521);
            this.LV_categories.TabIndex = 13;
            this.LV_categories.UseCompatibleStateImageBehavior = false;
            this.LV_categories.View = System.Windows.Forms.View.Details;
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
            // Lb_Search
            // 
            this.Lb_Search.AutoSize = true;
            this.Lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_Search.Location = new System.Drawing.Point(321, 154);
            this.Lb_Search.Name = "Lb_Search";
            this.Lb_Search.Size = new System.Drawing.Size(128, 20);
            this.Lb_Search.TabIndex = 20;
            this.Lb_Search.Text = "Search Category";
            // 
            // tb_CategorySearch
            // 
            this.tb_CategorySearch.Location = new System.Drawing.Point(324, 177);
            this.tb_CategorySearch.Name = "tb_CategorySearch";
            this.tb_CategorySearch.Size = new System.Drawing.Size(146, 20);
            this.tb_CategorySearch.TabIndex = 19;
            this.tb_CategorySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_CategorySearch_KeyDown);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.Location = new System.Drawing.Point(321, 80);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(149, 62);
            this.btnEditCategory.TabIndex = 17;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(321, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(149, 62);
            this.btnAddCategory.TabIndex = 18;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // CategoriesOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 545);
            this.Controls.Add(this.Lb_Search);
            this.Controls.Add(this.tb_CategorySearch);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.LV_categories);
            this.Name = "CategoriesOverviewForm";
            this.Text = "CategoriesOverviewForm";
            this.Activated += new System.EventHandler(this.CategoriesOverviewForm_Activated);
            this.Load += new System.EventHandler(this.CategoriesOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_categories;
        private System.Windows.Forms.ColumnHeader colid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label Lb_Search;
        private System.Windows.Forms.TextBox tb_CategorySearch;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
    }
}