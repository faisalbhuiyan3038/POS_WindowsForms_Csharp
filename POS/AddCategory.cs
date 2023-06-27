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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";

            string name = txtName.Text;
            string description = txtDescription.Text;
            string createdBy = "Admin";
            string createdDate = (DateTime.Now).ToString();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Category (Name,Description,CreatedBy,CreatedDate) VALUES (@Name,@Description,@CreatedBy,@CreatedDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                cmd.Parameters.AddWithValue("@CreatedDate", createdDate);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category Added Successfully!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong. Please Try Again!");
                }
            }
        }
    }
}
