using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livros
    {
        public void InsertData(string data)
        {
            using (SqlConnection connection = DatabaseConnection.Instance.GetConnection())
            {
                string query = "INSERT INTO TableName (ColumnName) VALUES (@Data)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Data", data);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
