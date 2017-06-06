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
    public partial class CategoryForm : Form
    {
        private Category _category;
        public CategoryForm(Category category)
        {
            InitializeComponent();
            _category = category;

            //set textboxes
            tbName.Text = _category.Name;
        }

        //saves the new data from textboxes
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            _category.Name = tbName.Text;

            Program.db.Categories.AddOrUpdate(_category);
            Program.db.SaveChanges();
            Close();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
