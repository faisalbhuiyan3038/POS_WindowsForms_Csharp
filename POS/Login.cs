using System.Data.SqlClient;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Xml.Linq;


namespace POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string connectionString = "Data Source=DESKTOP-QFRL6D9\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Admin WHERE UserName = @UserName AND Password = @Password";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        Tasks tasks = new Tasks();
                        tasks.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed. Please Try Again.");
                    }

                     connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured: " + ex.Message);
            }

            

            
        }
    }
}