using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;


namespace Shop
{
    public partial class CustomerForm : Form
    {
        private Customer _customer;

        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            //set textboxes
            tbFirstName.Text = _customer.FirstName;
            tbLastName.Text = _customer.LastName;
            tbAdress.Text = _customer.Address;
            tbPhoneNumber.Text = _customer.PhoneNumber;
        }

        //button saves the new values
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            _customer.FirstName = tbFirstName.Text;
            _customer.LastName = tbLastName.Text;
            _customer.Address = tbAdress.Text;
            _customer.PhoneNumber = tbAdress.Text;
            _customer.CreatedAt = DateTime.Now;

            Program.db.Customers.AddOrUpdate(_customer);
            Program.db.SaveChanges();

            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
