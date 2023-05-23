using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Model
{
    public class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());
        public static DatabaseConnection Instance => instance.Value;

        private readonly string connectionString = "Data Source=CODE;Initial Catalog = DB_Livraria; Integrated Security = True";
        
        private readonly SqlConnection connection;

        private DatabaseConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
