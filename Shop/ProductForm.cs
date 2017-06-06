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
using System.IO;

namespace Shop
{
    public partial class ProductForm : Form
    {
        private Product _Product;

        public ProductForm(Product product)
        {
            InitializeComponent();
            _Product = product;

            //set data to textboxes
            tbName.Text = _Product.Name;
            tbDescription.Text = _Product.Description;

            if (_Product.Price != null)
            {
                nmPrice.Value = decimal.Parse(_Product.Price);
            }

            if (_Product.Weight != null)
            {
                nmWeight.Value = decimal.Parse(_Product.Weight);
            }

            if (_Product.Quantity != null)
            {
                nmQuantity.Value = decimal.Parse(_Product.Quantity.ToString());
            }

            if (_Product.Image != null)
            {
                MemoryStream stream = new MemoryStream(_Product.Image);
                Image RetImage = Image.FromStream(stream);
                pictureBox1.Image = RetImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }
        //edits or inserts items on click
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            // finds supplier by selected value
            if (cbSupplier.SelectedValue != null)
            {
                int supplierID = (int)cbSupplier.SelectedValue;
                Supplier _selectedSupplier = Program.db.Suppliers.Find(supplierID);
                _Product.Supplier = _selectedSupplier;
            }

            // finds catagory by selected value
            if (cbCategory.SelectedValue != null)
            {
                int catagoryID = (int)cbCategory.SelectedValue;
                Category _selectedCategory = Program.db.Categories.Find(catagoryID);
                _Product.Category = _selectedCategory;
            }


            _Product.Name = tbName.Text;
            _Product.Description = tbDescription.Text;
            _Product.Price = nmPrice.Value.ToString();
            _Product.Weight = nmWeight.Value.ToString();
            _Product.Quantity = Int32.Parse(nmQuantity.Value.ToString());
            _Product.CreatedAt = DateTime.Now;


            //picture save
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                Byte[] a = ms.GetBuffer();
                ms.Close();
                _Product.Image = a;
            }


            //adds or updates record.
            Program.db.Products.AddOrUpdate(_Product);
            Program.db.SaveChanges();

            Close();

        }

        private void btnAddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opendlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //onload fill comboboxes
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            //checks if product has catagory if true it selects the correct catagory.
            if (_Product.Category != null)
            {
                Category CurrentCat = Program.db.Categories.Find(_Product.Category.ID);
                int selectedCat = CurrentCat.ID;

                var categories = Program.db.Categories.ToArray();
                cbCategory.DataSource = categories;
                cbCategory.ValueMember = "ID";
                cbCategory.DisplayMember = "Name";
                cbCategory.SelectedValue = selectedCat;
            }
            else
            {
                //else loads all catagory in combobox
                var categories = Program.db.Categories.ToArray();
                cbCategory.DataSource = categories;
                cbCategory.ValueMember = "ID";
                cbCategory.DisplayMember = "Name";
            }

            //checks if product has supplier if true it selects the correct supplier.
            if (_Product.Supplier != null)
            {
                Supplier CurrentSup = Program.db.Suppliers.Find(_Product.Supplier.ID);
                int selectedSup = CurrentSup.ID;

                var suppliers = Program.db.Suppliers.ToArray();
                cbSupplier.DataSource = suppliers;
                cbSupplier.ValueMember = "ID";
                cbSupplier.DisplayMember = "Name";
                cbSupplier.SelectedValue = selectedSup;
            }
            else
            {
                //else loads all suppliers in combobox
                var suppliers = Program.db.Suppliers.ToArray();
                cbSupplier.DataSource = suppliers;
                cbSupplier.ValueMember = "ID";
                cbSupplier.DisplayMember = "Name";
            }
        }


    }
}

