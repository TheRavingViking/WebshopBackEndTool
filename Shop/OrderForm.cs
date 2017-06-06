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
    public partial class OrderForm : Form
    {
        public List<Customer> ListOfCustomers;
        public List<Product> ListOfProducts;
        private Order _order;
        private int _customerID;

        public OrderForm(Order order)
        {
            _order = order;
            InitializeComponent();
        }


        //buttons
        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            //this button copies the data from product list to shopping cart. also adds the quantity given in the numericupdown.
            if (LV_Products.SelectedItems.Count > 0)
            {
                ListViewItem cloneFromProducts = new ListViewItem();

                //set data
                cloneFromProducts.Text = LV_Products.SelectedItems[0].Text;
                cloneFromProducts.SubItems.Add(LV_Products.SelectedItems[0].SubItems[1]);
                cloneFromProducts.SubItems.Add(LV_Products.SelectedItems[0].SubItems[2]);
                cloneFromProducts.SubItems.Add(nmQuantity.Value.ToString());
                cloneFromProducts.Tag = LV_Products.SelectedItems[0].Tag;

                LV_ShoppingCart.Items.Add(cloneFromProducts);
            }
        }

        //button selects the customer for whom the order is. also enables productlist and shopping cart.
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if (btnSelectCustomer.Text == "Select Customer")
            {
                if (LV_Customers.SelectedItems.Count > 0)
                {
                    _customerID = (int)LV_Customers.SelectedItems[0].Tag;
                    LV_Customers.Enabled = false;
                    btnSelectCustomer.Text = "Update";
                }
            }
            else
            {
                LV_Customers.Enabled = true;

                btnSelectCustomer.Text = "Select Customer";
            }

            if (btnSelectCustomer.Text == "Update")
            {
                LV_Products.Enabled = true;
                LV_ShoppingCart.Enabled = true;
                nmQuantity.Enabled = true;
                btnConfirm.Enabled = true;
                BtnDeleteProductFromShoppingCart.Enabled = true;
                btnAddProductToCart.Enabled = true;
            }
            else
            {
                LV_Products.Enabled = false;
                LV_ShoppingCart.Enabled = false;
                nmQuantity.Enabled = false;
                btnConfirm.Enabled = false;
                BtnDeleteProductFromShoppingCart.Enabled = false;
                btnAddProductToCart.Enabled = false;
            }
        }

        //button removes selected item from shoppingcart
        private void BtnDeleteProductFromShoppingCart_Click(object sender, EventArgs e)
        {
            if (LV_ShoppingCart.SelectedItems.Count > 0)
            {
                LV_ShoppingCart.SelectedItems[0].Remove();
            }
        }

        //button saves the items to DB
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //finds customer and adds him to the new order.
            Customer SelectedCustomer = Program.db.Customers.Find(_customerID);
            SelectedCustomer.Orders.Add(_order);
            _order.OrderDate = DateTime.Now;
            _order.ShipAdress = SelectedCustomer.Address;
            Program.db.Orders.Add(_order);

            foreach (ListViewItem product in LV_ShoppingCart.Items)
            {
                OrderDetail _orderDetail = new OrderDetail();
                _orderDetail.OrderID = _order.ID;
                _orderDetail.ProductID = (int)product.Tag;
                _orderDetail.Price = product.SubItems[2].Text.ToString();
                _orderDetail.Quantity = Int32.Parse(product.SubItems[3].Text.ToString());
                Program.db.OrderDetails.Add(_orderDetail);

                //finds the product and removes the amount given from the quantity.
                Product selectedProduct = Program.db.Products.Find(product.Tag);
                selectedProduct.Quantity -= Int32.Parse(product.SubItems[3].Text.ToString());

                // if product quantity drops below 2 the system automatically resupplies by amount order.
                if (selectedProduct.Quantity < 2)
                {
                    selectedProduct.Quantity += Int32.Parse(product.SubItems[3].Text.ToString());
                }

            }

            //saves the changes.
            Program.db.SaveChanges();

            Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //on form load show the lists and disables them. 
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ShowListCustomers();
            ShowListProducts();

            if (btnSelectCustomer.Text == "Select Customer")
            {
                LV_Products.Enabled = false;
                LV_ShoppingCart.Enabled = false;
                nmQuantity.Enabled = false;
                btnConfirm.Enabled = false;
                BtnDeleteProductFromShoppingCart.Enabled = false;
                btnAddProductToCart.Enabled = false;
            }
        }

        //showlists for customers and products
        private void ShowListCustomers()
        {
            LV_Customers.Items.Clear();

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
                customerlist.Tag = customer.ID;

                // Add to list.
                LV_Customers.Items.Add(customerlist);

            }
        }

        private void ShowListProducts()
        {
            LV_Products.Items.Clear();

            var products = from product in Program.db.Products
                           where product.IsDeleted == null
                           select product;

            ListOfProducts = products.ToList();

            foreach (Product product in products)
            {
                ListViewItem productlist = new ListViewItem();

                //set data
                productlist.Text = (product.ID.ToString());
                productlist.SubItems.Add(product.Name);
                productlist.SubItems.Add(product.Price);
                productlist.SubItems.Add(product.Weight);
                productlist.SubItems.Add(product.Quantity.ToString());
                productlist.Tag = product.ID;

                // add them to the list.
                LV_Products.Items.Add(productlist);
            }
        }

    }
}
