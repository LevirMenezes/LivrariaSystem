using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class GeneroModel
    {
        public string Insert(GeneroEnt genero)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbGenero(genero) VALUES (@genero)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@genero", genero.Genero);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Insert não foi feito!";
                }
            }
            catch (Exception ex)
            {
                resp = "Erro no insert!" + ex.Message;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return resp;
        }

        public string Update(GeneroEnt genero)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbGenero 
                            SET genero = @genero
                            WHERE id   = @id ";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@genero", genero.Genero);
                    command.Parameters.AddWithValue("@id",     genero.Id);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Update não foi feito!";
                }
            }
            catch (Exception ex)
            {
                resp = "Erro no update!" + ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return resp;
        }

        public string Delete(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "DELETE FROM tbGenero WHERE id = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Delete não foi feito!";
                }
            }
            catch (Exception ex)
            {
                resp = "Erro no delete!" + ex.Message;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return resp;
        }

        public List<GeneroEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<GeneroEnt> generos = new List<GeneroEnt>();
            string query = "SELECT * FROM tbGenero";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GeneroEnt genero = new GeneroEnt();
                            genero.Id        = Convert.ToInt32(reader["id"]);
                            genero.Genero    = reader["genero"].ToString();

                            generos.Add(genero);
                        }
                    }
                }
            }
            catch (Exception)
            {
                generos = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return generos;
        }

        public GeneroEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            GeneroEnt genero = new GeneroEnt();
            string query = "SELECT * FROM tbGenero WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genero.Id     = Convert.ToInt32(reader["id"]);
                            genero.Genero = reader["genero"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                genero = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return genero;
        }
    }
}
