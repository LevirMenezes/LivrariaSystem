using System.Configuration;
using System.Data.SqlClient;

namespace LivrariaTor.Persistencia
{
    public class Conexao
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["LivrariaTor"].ConnectionString;
        private static SqlConnection conexao;

        private Conexao() { }

        public static SqlConnection ObterConexao()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection(connectionString);
                conexao.Open();
            }

            return conexao;
        }

        public static void FecharConexao()
        {
            if (conexao != null && conexao.State != System.Data.ConnectionState.Closed)
            {
                conexao.Close();
                conexao = null;
            }
        }
    }
}
