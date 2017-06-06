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
    public partial class CustomerOverviewForm : Form
    {
        public List<Customer> ListOfCustomers;


        public CustomerOverviewForm()
        {
            InitializeComponent();
        }

        //Buttons (add/edit or delete)
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            disableButtons();
            Customer _customer = new Customer();
            CustomerForm addCustomer = new CustomerForm(_customer);
            addCustomer.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (LV_Customers.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and passes it through in the next form
                disableButtons();
                var CustomerID = LV_Customers.SelectedItems[0].Tag;
                Customer selectedCustomer = Program.db.Customers.Find(CustomerID);
                CustomerForm editCustomer = new CustomerForm(selectedCustomer);
                editCustomer.Show();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (LV_Customers.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and deletes it.
                var CustomerID = LV_Customers.SelectedItems[0].Tag;
                Customer selectedCustomer = Program.db.Customers.Find(CustomerID);
                selectedCustomer.IsDeleted = DateTime.Now;
                Program.db.Entry(selectedCustomer).Property(x => x.IsDeleted).IsModified = true;
                Program.db.SaveChanges();
                ShowList();
            }
        }

        //Search function through text input.
        private void tb_CustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            LV_Customers.Items.Clear();

            string searchTerm = tb_CustomerSearch.Text;

            //Karim ik heb indexOf gebruikt omdat ik .Contains niet kon laten werken met Case-Sensitive. dit kwam ik tegen op het internet en het werkt. heb je hier een andere oplossing voor? of is dit de juiste?
            var customers = from customer in ListOfCustomers
                            where customer.FirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                            || customer.LastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                            select customer;

            foreach (Customer customer in customers)
            {
                ListViewItem productlist = new ListViewItem();

                // Sets Data
                productlist.Text = (customer.ID.ToString());
                productlist.SubItems.Add(customer.FirstName);
                productlist.SubItems.Add(customer.LastName);
                productlist.SubItems.Add(customer.Address);
                productlist.SubItems.Add(customer.PhoneNumber);

                productlist.Tag = customer.ID;

                // add them to the list.
                LV_Customers.Items.Add(productlist);
            }
        }

        //showing/refreshing listview
        private void ShowList()
        {
            LV_Customers.Items.Clear();

            //finds all products who arent deleted.
            var customers = from customer in Program.db.Customers
                            where customer.IsDeleted == null
                            select customer;

            ListOfCustomers = customers.ToList();

            foreach (Customer customer in ListOfCustomers)
            {
                ListViewItem customerlist = new ListViewItem();

                // Set Data.
                customerlist.Text = (customer.ID.ToString());
                customerlist.SubItems.Add(customer.FirstName);
                customerlist.SubItems.Add(customer.LastName);
                customerlist.SubItems.Add(customer.Address);
                customerlist.SubItems.Add(customer.PhoneNumber);
                customerlist.Tag = customer.ID;

                // Add to list.
                LV_Customers.Items.Add(customerlist);

            }
        }

        //Refresh on screenactivation
        private void CustomerOverviewForm_Activated(object sender, EventArgs e)
        {
            ShowList();
            enableButtons();
        }

        //disable/enable buttons functions
        private void disableButtons()
        {
            btnAddCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnEditCustomer.Enabled = false;
        }

        private void enableButtons()
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            btnEditCustomer.Enabled = true;
        }
    }
}
