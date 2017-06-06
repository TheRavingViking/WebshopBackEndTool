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
    public partial class CategoriesOverviewForm : Form
    {
        public List<Category> ListOfCatagories;

        public CategoriesOverviewForm()
        {
            InitializeComponent();
        }

        //Buttons (add/edit or delete)
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            disableButtons();
            Category NewCategory = new Category();
            CategoryForm category = new CategoryForm(NewCategory);
            category.Show();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (LV_categories.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and passes it through in the next form
                var catagoryID = LV_categories.SelectedItems[0].Tag;
                Category selectedCatagory = Program.db.Categories.Find(catagoryID);
                CategoryForm EditCategory = new CategoryForm(selectedCatagory);
                disableButtons();
                EditCategory.Show();
            }
        }

        //Search function through text input.
        private void tb_CategorySearch_KeyDown(object sender, KeyEventArgs e)
        {
            LV_categories.Items.Clear();

            string searchTerm = tb_CategorySearch.Text;

            //Karim ik heb indexOf gebruikt omdat ik .Contains niet kon laten werken met Case-Sensitive. dit kwam ik tegen op het internet en het werkt. heb je hier een andere oplossing voor? of is dit de juiste?
            var categories = from category in ListOfCatagories
                             where category.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                             select category;

            foreach (Category category in categories)
            {
                ListViewItem productlist = new ListViewItem();

                // Sets Data
                productlist.Text = (category.ID.ToString());
                productlist.SubItems.Add(category.Name);
                productlist.Tag = category.ID;

                // add them to the list.
                LV_categories.Items.Add(productlist);
            }
        }

        //showing/refreshing listview
        private void ShowList()
        {
            LV_categories.Items.Clear();

            //finds all records who arent deleted.
            var Categories = from Supplier in Program.db.Categories
                             where Supplier.IsDeleted == null
                             select Supplier;

            ListOfCatagories = Categories.ToList();

            foreach (Category category in ListOfCatagories)
            {
                ListViewItem Categorylist = new ListViewItem();

                // Set Data.
                Categorylist.Text = (category.ID.ToString());
                Categorylist.SubItems.Add(category.Name);
                Categorylist.Tag = category.ID;

                // Add to list.
                LV_categories.Items.Add(Categorylist);
            }
        }

        //fills List on load
        private void CategoriesOverviewForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        //Refresh on screenactivation
        private void CategoriesOverviewForm_Activated(object sender, EventArgs e)
        {
            LV_categories.Items.Clear();
            ShowList();
            enableButtons();
        }

        //disable/enable buttons functions
        private void disableButtons()
        {
            btnAddCategory.Enabled = false;
            btnEditCategory.Enabled = false;
            tb_CategorySearch.Enabled = false;
        }

        private void enableButtons()
        {
            btnAddCategory.Enabled = true;
            btnEditCategory.Enabled = true;
            tb_CategorySearch.Enabled = true;
        }
    }
}
