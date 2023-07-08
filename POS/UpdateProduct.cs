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
using Windows.UI.Xaml;

namespace POS
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
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

        private void btnLoadExistingData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExistingName.Text))
            {
                MessageBox.Show("No Data Found...");
            }

            string existingName = txtExistingName.Text;

            string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Product WHERE Name = @existingName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@existingName", existingName);

                    int categoryID = 0;
                    

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtNewName.Text = reader["Name"].ToString();
                            txtNewDescription.Text = reader["Description"].ToString();
                            txtNewPrice.Text = reader["Price"].ToString();
                            txtNewVATPercent.Text = reader["VATPercent"].ToString();

                            if (reader.GetBoolean("IsDiscountAllow"))
                            {
                                rdBtnDiscountYes.Checked = true;
                            }
                            else
                            {
                                rdBtnDiscountNo.Checked = true;
                            }

                            
                            categoryID = (int)reader["CategoryID"];
                            comboBoxCategory.SelectedIndex = categoryID - 1;
                        }

                    }
                    
                        

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
