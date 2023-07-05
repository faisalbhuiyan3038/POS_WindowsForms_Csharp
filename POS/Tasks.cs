using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void menuAddItems_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
            this.Hide();
        }

        private void addProductEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void addStockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.Show();
            this.Hide();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }
    }
}
