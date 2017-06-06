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
    public partial class SuppliersOverviewForm : Form
    {

        public List<Supplier> ListOfSuppliers;

        public SuppliersOverviewForm()
        {
            InitializeComponent();
        }

        //Buttons (add/edit or delete)
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            disableButtons();
            Supplier supplier = new Supplier();
            SupplierForm addSupplier = new SupplierForm(supplier);
            addSupplier.Show();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (LV_Suppliers.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and passes it through in the next form
                var SupplierID = LV_Suppliers.SelectedItems[0].Tag;
                Supplier SelectedSupplier = Program.db.Suppliers.Find(SupplierID);
                SupplierForm EditSupplier = new SupplierForm(SelectedSupplier);
                disableButtons();
                EditSupplier.Show();
            }
        }

        //Search function through text input.
        private void tb_SupplierSearch_KeyDown(object sender, KeyEventArgs e)
        {
            LV_Suppliers.Items.Clear();

            string searchTerm = tb_SupplierSearch.Text;


            //Karim ik heb indexOf gebruikt omdat ik .Contains niet kon laten werken met Case-Sensitive. dit kwam ik tegen op het internet en het werkt. heb je hier een andere oplossing voor? of is dit de juiste?
            var suppliers = from product in ListOfSuppliers
                            where product.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                            select product;

            foreach (Supplier supplier in suppliers)
            {
                ListViewItem SupplierList = new ListViewItem();

                // Sets Data
                SupplierList.Text = (supplier.ID.ToString());
                SupplierList.SubItems.Add(supplier.Name);
                SupplierList.SubItems.Add(supplier.Address);
                SupplierList.SubItems.Add(supplier.PhoneNumber);
                SupplierList.Tag = supplier.ID;

                // add them to the list.
                LV_Suppliers.Items.Add(SupplierList);
            }
        }


        //showing/refreshing listview
        private void ShowList()
        {
            LV_Suppliers.Items.Clear();

            var suppliers = from Supplier in Program.db.Suppliers
                           where Supplier.IsDeleted == null
                           select Supplier;

            ListOfSuppliers = suppliers.ToList();


            foreach (Supplier supplier in ListOfSuppliers)
            {
                ListViewItem Supplierlist = new ListViewItem();


                // Set Data.
                Supplierlist.Text = (supplier.ID.ToString());
                Supplierlist.SubItems.Add(supplier.Name);
                Supplierlist.SubItems.Add(supplier.Address);
                Supplierlist.SubItems.Add(supplier.PhoneNumber);

                Supplierlist.Tag = supplier.ID;


                // Add to list.
                LV_Suppliers.Items.Add(Supplierlist);

            }
        }

        //Refresh on screenactivation
        private void SuppliersOverviewForm_Activated(object sender, EventArgs e)
        {
            ShowList();
            enableButtons();
        }

        //fills List on load
        private void SuppliersOverviewForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }


        //disable/enable buttons functions
        private void disableButtons()
        {
            btnAddSupplier.Enabled = false;
            btnEditSupplier.Enabled = false;
        }

        private void enableButtons()
        {
            btnAddSupplier.Enabled = true;
            btnEditSupplier.Enabled = true;
        }
    }
}
