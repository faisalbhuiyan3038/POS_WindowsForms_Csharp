using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Duplicates
    {
        public static bool isDuplicateExists(string connectionString, string tableName, string columnName, string columnData)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object for checking duplicates
                string query = "SELECT COUNT(*) FROM "+tableName+" WHERE "+columnName+"="+columnData;
                SqlCommand duplicateCheckCommand = new SqlCommand(query, connection);

                // Set parameter values

                // Execute the duplicate check query
                int duplicateCount = (int)duplicateCheckCommand.ExecuteScalar();

                if (duplicateCount > 0)
                {
                    // Duplicate exists, do not perform the insert
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
