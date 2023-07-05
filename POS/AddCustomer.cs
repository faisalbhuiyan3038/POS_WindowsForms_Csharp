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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Email = txtEmail.Text;
            string Mobile = txtMobile.Text;
            string Address = txtAddress.Text;

            if(string.IsNullOrEmpty(Name) == false)
            {
                MessageBox.Show("Please Type In the Customer's Name....");
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Customer (Name,Email,Mobile,Address) VALUES (@Name,@Email,@Mobile,@Address)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    cmd.Parameters.AddWithValue("@Address", Address);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Customer Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Please Try Again.");
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
