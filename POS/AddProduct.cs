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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void rdBtnDiscountYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
