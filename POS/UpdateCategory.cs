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
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExistingName.Text))
            {
                MessageBox.Show("Please Enter the Existing Category Name to Update...");
            }

            string existingName = txtExistingName.Text;
            string updatedBy = "Admin";
            string updatedDate = DateTime.Now.ToString();

            string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query;

                    if (!string.IsNullOrEmpty(txtNewName.Text))
                    {
                        query = "UPDATE Category SET Description=@Description,UpdatedBy=@updatedBy,UpdatedDate=@UpdatedDate WHERE Name=@existingName";
                    }
                    else if (!string.IsNullOrEmpty(txtDescription.Text))
                    {
                        query = "UPDATE Category SET Name=@Name,UpdatedBy=@updatedBy,UpdatedDate=@UpdatedDate WHERE Name=@existingName";
                    }
                    else
                    {
                        query = "UPDATE Category SET Name=@Name,Description=@Description,UpdatedBy=@updatedBy,UpdatedDate=@UpdatedDate WHERE Name-@existingName";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtNewName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@existingName", existingName);
                    cmd.Parameters.AddWithValue("@updatedBy", updatedBy);
                    cmd.Parameters.AddWithValue("@updatedDate", updatedDate);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Category Updated Successfully..");

                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Please Try Again..");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                    string query = "SELECT Name,Description FROM Category WHERE Name = @Name";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", existingName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtNewName.Text = reader["Name"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }
    }
}
