using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UpdateStock : Form
    {
        string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
        public UpdateStock()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Product";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxExistingProduct.Items.Add(reader["Name"].ToString());
                    comboBoxNewProduct.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (comboBoxExistingProduct.SelectedIndex==-1)
            {
                MessageBox.Show("No Product Selected....");
            }
            int existingProductID = comboBoxExistingProduct.SelectedIndex-1;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Stock WHERE ProductID='" + existingProductID;


            }
            
        }
    }
}
