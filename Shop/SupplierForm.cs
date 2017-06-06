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
    public partial class SupplierForm : Form
    {
        private Supplier _supplier;
        public SupplierForm(Supplier supplier)
        {
            InitializeComponent();

            _supplier = supplier;

            //set textboxes to object
            tbName.Text = _supplier.Name;
            tbAdress.Text = _supplier.Address;
            tbPhoneNumber.Text = _supplier.PhoneNumber;
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            //set data according to the textboxes
            _supplier.Name = tbName.Text;
            _supplier.Address = tbAdress.Text;
            _supplier.PhoneNumber = tbPhoneNumber.Text;

            //add or update the record
            Program.db.Suppliers.AddOrUpdate(_supplier);
            Program.db.SaveChanges();
            Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
