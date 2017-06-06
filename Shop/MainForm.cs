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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            disableButtons();
            ProductOverviewForm products = new ProductOverviewForm();
            products.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            disableButtons();
            CustomerOverviewForm customers = new CustomerOverviewForm();
            customers.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            disableButtons();
            SuppliersOverviewForm suppliers = new SuppliersOverviewForm();
            suppliers.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            disableButtons();
            CategoriesOverviewForm categories = new CategoriesOverviewForm();
            categories.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            disableButtons();
            OrderOverviewForm orders = new OrderOverviewForm();
            orders.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            enableButtons();
            ShowListCustomers();
            ShowListOrders();
            ShowListProducts();
        }

        private void ShowListCustomers()
        {
            LV_Customers.Items.Clear();

            //finds all products who arent deleted.
            var customers = (from customer in Program.db.Customers
                            where customer.IsDeleted == null
                            orderby customer.CreatedAt descending
                            select customer).Take(5);

            foreach (Customer customer in customers)
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

        private void ShowListOrders()
        {
            LV_Orders.Items.Clear();

            //get the last 5 orders.
            var orders = (from order in Program.db.Orders
                         orderby order.OrderDate descending
                         select order).Take(5);


            foreach (Order order in orders)
            {
                ListViewItem orderlist = new ListViewItem();

                // Set Data.
                orderlist.Text = (order.ID.ToString());
                orderlist.SubItems.Add(order.OrderDate.ToString());
                orderlist.SubItems.Add(order.ShipAdress);
                orderlist.SubItems.Add(order.Customer.FirstName);
                orderlist.SubItems.Add(order.Customer.LastName);
                orderlist.SubItems.Add(order.Customer.Address);
                orderlist.Tag = order.ID;

                // Add to list.
                LV_Orders.Items.Add(orderlist);
            }
        }

        private void ShowListProducts()
        {
            LV_products.Items.Clear();

            //finds all records who arent deleted.
            var products = from product in Program.db.Products
                           where product.IsDeleted == null
                           && product.Quantity <= 10
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

                // Add to list.
                LV_products.Items.Add(productlist);
            }
        }




        private void disableButtons()
        {
            btnCustomers.Enabled = false;
            btnOrders.Enabled = false;
            btnProducts.Enabled = false;
            btnSuppliers.Enabled = false;
            btnCategory.Enabled = false;
        }

        private void enableButtons()
        {
            btnCustomers.Enabled = true;
            btnOrders.Enabled = true;
            btnProducts.Enabled = true;
            btnSuppliers.Enabled = true;
            btnCategory.Enabled = true;
        }


    }
}
