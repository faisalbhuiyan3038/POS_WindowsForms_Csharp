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
using System.Xml.Linq;

namespace POS
{
    public partial class AddProduct : Form
    {
        string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
        public AddProduct()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Category";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCategory.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
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
            
            string Name = txtName.Text;
            string Price = txtPrice.Text;
            string VATPercent = txtVATPercent.Text;
            string Description = txtDescription.Text;
            string CategoryName = comboBoxCategory.Text;
            string createdBy = "Admin";
            string createdDate = DateTime.Now.ToString();
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string categoryIdQuery = "SELECT CategoryID FROM Category WHERE Name = @categoryName";
                SqlCommand cmd = new SqlCommand(categoryIdQuery, conn);
                cmd.Parameters.AddWithValue("@categoryName", CategoryName);

                string categoryID = cmd.ExecuteScalar().ToString();

                string query = "INSERT INTO Product (Name,Price,VATPercent,IsDiscountAllow,Description,CategoryID,CreatedBy,CreatedDate) VALUES (@Name,@Price,@VATPercent,@IsDiscountAllowed,@Description,@CategoryID,@CreatedBy,@CreatedDate)";

                SqlParameter isDiscountAllow = new SqlParameter("@IsDiscountAllowed", System.Data.SqlDbType.Bit);

                if (rdBtnDiscountYes.Checked)
                {
                    isDiscountAllow.Value = true;
                }
                else if (rdBtnDiscountNo.Checked)
                {
                    isDiscountAllow.Value = false;
                }
                

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@VATPercent", VATPercent);
                cmd.Parameters.Add(isDiscountAllow);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                cmd.Parameters.AddWithValue("@CreatedDate", createdDate);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Added Successfully!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong. Please Try Again!");
                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
