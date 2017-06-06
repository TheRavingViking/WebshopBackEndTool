using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class OrderDetails : Form
    {
        private Order _order;

        public OrderDetails(Order order)
        {
            InitializeComponent();
            _order = order;
            //set textboxes
            tbFirstname.Text = _order.Customer.FirstName;
            tbLastname.Text = _order.Customer.LastName;
            tbAdress.Text = _order.Customer.Address;
            tbPhoneNumber.Text = _order.Customer.PhoneNumber;
            tbShipAdress.Text = _order.ShipAdress;
            tbOrderDate.Text = _order.OrderDate.ToString();

            foreach (var orderDetails in _order.OrderDetails)
            {
                ListViewItem productlist = new ListViewItem();
                //set data.
                productlist.Text = (orderDetails.ProductID.ToString());
                productlist.SubItems.Add(orderDetails.Product.Name);
                productlist.SubItems.Add(orderDetails.Price);
                productlist.SubItems.Add(orderDetails.Quantity.ToString());
                productlist.Tag = orderDetails.ProductID;
                
                // add them to the list.
                LV_ShoppingCart.Items.Add(productlist);
            }

        }

        private void LV_ShoppingCart_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (LV_ShoppingCart.SelectedItems.Count > 0)
            {
                var ProductID = LV_ShoppingCart.SelectedItems[0].Tag;
                Product selectedProduct = Program.db.Products.Find(ProductID);

                tbName.Text = selectedProduct.Name;
                tbDescription.Text = selectedProduct.Description;
                tbCategory.Text = selectedProduct.Category.Name;
                tbSupplier.Text = selectedProduct.Supplier.Name;


                if (selectedProduct.Price != null)
                {
                    nmPrice.Value = decimal.Parse(selectedProduct.Price);
                }

                if (selectedProduct.Weight != null)
                {
                    nmWeight.Value = decimal.Parse(selectedProduct.Weight);
                }


                if (selectedProduct.Image != null)
                {
                    MemoryStream stream = new MemoryStream(selectedProduct.Image);
                    Image RetImage = Image.FromStream(stream);
                    pictureBox1.Image = RetImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }else
                {
                    pictureBox1.Image = null;
                }




            }


        }
    }
}
