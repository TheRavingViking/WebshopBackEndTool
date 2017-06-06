using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop
{
    public partial class ProductOverviewForm : Form
    {

        public List<Product> ListOfProducts;

        public ProductOverviewForm()
        {
            InitializeComponent();
        }

        //Buttons (add/edit or delete)
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            disableButtons();
            Product product = new Product();
            ProductForm addProduct = new ProductForm(product);
            addProduct.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (LV_products.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and passes it through in the next form
                var ProductID = LV_products.SelectedItems[0].Tag;
                Product selectedProduct = Program.db.Products.Find(ProductID);
                ProductForm editProduct = new ProductForm(selectedProduct);
                disableButtons();
                editProduct.Show();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (LV_products.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and deletes it.
                var ProductID = LV_products.SelectedItems[0].Tag;
                Product selectedProduct = Program.db.Products.Find(ProductID);
                selectedProduct.IsDeleted = DateTime.Now;
                Program.db.Entry(selectedProduct).Property(x => x.IsDeleted).IsModified = true;
                Program.db.SaveChanges();
                ShowList();
            }
        }

        //Search function through text input.
        private void tb_ProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            LV_products.Items.Clear();

            string searchTerm = tb_ProductSearch.Text;
            
            //Karim ik heb indexOf gebruikt omdat ik .Contains niet kon laten werken met Case-Sensitive. dit kwam ik tegen op het internet en het werkt. heb je hier een andere oplossing voor? of is dit de juiste?
            var products = from product in ListOfProducts
                           where product.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                           select product;


            foreach (Product product in products)
            {
                ListViewItem productlist = new ListViewItem();

                // Sets Data
                productlist.Text = (product.ID.ToString());
                productlist.SubItems.Add(product.Name);
                productlist.SubItems.Add(product.Description);
                productlist.SubItems.Add(product.Price);
                productlist.SubItems.Add(product.Weight);
                productlist.SubItems.Add(product.Quantity.ToString());

                productlist.Tag = product.ID;

                // add them to the list.
                LV_products.Items.Add(productlist);
            }
        }

        //showing/refreshing listview
        private void ShowList()
        {
            LV_products.Items.Clear();

            //finds all records who arent deleted.
            var products = from product in Program.db.Products
                           where product.IsDeleted == null
                           select product;


            ListOfProducts = products.ToList();

            foreach (Product product in ListOfProducts)
            {
                ListViewItem productlist = new ListViewItem();

                // Set Data.
                productlist.Text = (product.ID.ToString());
                productlist.SubItems.Add(product.Name);
                productlist.SubItems.Add(product.Description);
                productlist.SubItems.Add(product.Price);
                productlist.SubItems.Add(product.Weight);
                productlist.SubItems.Add(product.Quantity.ToString());
                productlist.Tag = product.ID;

                // Add to list.
                LV_products.Items.Add(productlist);
            }
        }

        //Refresh on screenactivation
        private void ProductOverviewForm_Activated(object sender, EventArgs e)
        {
            enableButtons();
            ShowList();

        }

        //fills List & combobox on load
        private void ProductOverviewForm_Load(object sender, EventArgs e)
        {
            ShowList();
            var categories = Program.db.Categories.ToArray();
            cbCategoryFilter.DataSource = categories;
            cbCategoryFilter.ValueMember = "ID";
            cbCategoryFilter.DisplayMember = "Name";
        }

        //on change filters products by category
        private void cbCategoryFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LV_products.Items.Clear();

            //finds the catagory according to the selected value from the combobox
            int catagoryID = (int)cbCategoryFilter.SelectedValue;
            Category selectedCategory = Program.db.Categories.Find(catagoryID);

            var products = from product in ListOfProducts
                           where product.Category == selectedCategory
                           select product;

            foreach (Product product in products)
            {
                ListViewItem productlist = new ListViewItem();

                // Set Data.
                productlist.Text = (product.ID.ToString());
                productlist.SubItems.Add(product.Name);
                productlist.SubItems.Add(product.Price);
                productlist.SubItems.Add(product.Weight);
                productlist.SubItems.Add(product.Quantity.ToString());

                productlist.Tag = product.ID;

                // add them to the list.
                LV_products.Items.Add(productlist);
            }
        }

        //disable/enable buttons functions
        private void disableButtons()
        {
            btnAddProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            cbCategoryFilter.Enabled = false;
            tb_ProductSearch.Enabled = false;
        }

        private void enableButtons()
        {
            btnAddProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnEditProduct.Enabled = true;
            cbCategoryFilter.Enabled = true;
            tb_ProductSearch.Enabled = true;
        }
    }
}


