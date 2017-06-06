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
    public partial class OrderOverviewForm : Form
    {
        public List<Order> ListOfOrders;

        public OrderOverviewForm()
        {
            InitializeComponent();
        }

        //Buttons (add/edit or delete)
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            disableButtons();
            Order newOrder = new Order();
            OrderForm AddOrder = new OrderForm(newOrder);
            AddOrder.Show();

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (LV_Orders.SelectedItems.Count > 0)
            {
                //uses selected value to find in the DB and passes it through in the next form
                var SelectedOrder = LV_Orders.SelectedItems[0].Tag;
                Order orderdetails = Program.db.Orders.Find(SelectedOrder);
                OrderDetails showOrder = new OrderDetails(orderdetails);
                showOrder.Show();
                disableButtons();
            }
        }

        //Search function through text input.
        private void tb_CustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            LV_Orders.Items.Clear();

            string searchTerm = tb_CustomerSearch.Text;

            //Karim ik heb indexOf gebruikt omdat ik .Contains niet kon laten werken met Case-Sensitive. dit kwam ik tegen op het internet en het werkt. heb je hier een andere oplossing voor? of is dit de juiste?
            var orders = from order in ListOfOrders
                         where order.Customer.FirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                         || order.Customer.LastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0
                         select order;

            foreach (Order order in orders)
            {
                ListViewItem orderlist = new ListViewItem();

                //Set Data.
                orderlist.Text = (order.ID.ToString());
                orderlist.SubItems.Add(order.OrderDate.ToString());
                orderlist.SubItems.Add(order.ShipAdress);
                orderlist.SubItems.Add(order.Customer.FirstName);
                orderlist.SubItems.Add(order.Customer.LastName);
                orderlist.SubItems.Add(order.Customer.Address);
                orderlist.Tag = order.ID;

                // add them to the list.
                LV_Orders.Items.Add(orderlist);
            }
        }

        //fills List on load
        private void OrderOverviewForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        //Refresh on screenactivation
        private void OrderOverviewForm_Activated(object sender, EventArgs e)
        {
            enableButtons();
            ShowList();
        }

        private void ShowList()
        {
            LV_Orders.Items.Clear();


            var orders = from order in Program.db.Orders
                         select order;

            ListOfOrders = orders.ToList();

            foreach (Order order in ListOfOrders)
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

        //disable/enable buttons functions
        private void disableButtons()
        {
            btnAddOrder.Enabled = false;
            btnShowDetails.Enabled = false;
        }

        private void enableButtons()
        {
            btnAddOrder.Enabled = true;
            btnShowDetails.Enabled = true;
        }


    }
}
