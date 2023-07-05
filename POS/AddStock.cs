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
    public partial class AddStock : Form
    {
        string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
        public AddStock()
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
                    comboBoxProduct.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string ProductName = comboBoxProduct.Text;
            string Qty = numericUpDownQty.Text;
            DateTime ExpiryDate = dTPickerExpiryDate.Value;
            string CreatedBy = "Admin";
            string CreatedDate = DateTime.Now.ToString();

            if(string.IsNullOrEmpty(ProductName) == false || string.IsNullOrEmpty(Qty) == false)
            {
                MessageBox.Show("Please Fill Out All Necessary Fields...");
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string ProductQuery = "SELECT ProductID FROM Product WHERE Name = @ProductName";
                    SqlCommand cmd = new SqlCommand(ProductQuery, conn);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);

                    string ProductId = cmd.ExecuteScalar().ToString();

                    string query = "INSERT INTO Stock (ProductID,Qty,ExpiryDate,CreatedBy,CreatedDate) VALUES (@ProductID,@Qty,@ExpiryDate,@CreatedBy,@CreatedDate)";

                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", ProductId);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                    int AffectedRows = cmd.ExecuteNonQuery();

                    if (AffectedRows > 0)
                    {
                        MessageBox.Show("Stock Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Please Try Again.");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured: " + ex.Message);
            }

            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }
    }
}
