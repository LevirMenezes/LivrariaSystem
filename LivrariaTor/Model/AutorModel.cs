using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LivrariaTor.Model
{
    public class AutorModel
    {
        public string Insert(AutorEnt autor)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbAutor(nome) VALUES (@nome)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@nome", autor.Autor);
                    resp = command.ExecuteNonQuery()==1?"OK":"O Insert não foi feito!";
                }
            }
            catch (Exception)
            {
                resp = "Erro no insert!";
            }
            finally
            {
                Conexao.FecharConexao();
                
            }

            return resp;
        }

        private string Update(AutorEnt autor)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "UPDATE tbAutor WHERE id = @id SET autor = @autor";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", autor.Id);
                    command.Parameters.AddWithValue("@nome", autor.Autor);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Update não foi feito!";
                }
            }
            catch (Exception)
            {
                resp = "Erro no update!";
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return resp;
        }

        private string Delete(AutorEnt autor)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "DELETE FROM tbAutor WHERE id = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", autor.Id);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Delete não foi feito!";
                }
            }
            catch (Exception)
            {
                resp = "Erro no delete!";
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return resp;
        }

        private List<AutorEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<AutorEnt> autores = new List<AutorEnt>();
            string query = "SELECT * FROM tbAutor";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AutorEnt autor = new AutorEnt();
                            autor.Id = Convert.ToInt32(reader["id"]);
                            autor.Autor = reader["autor"].ToString();

                            autores.Add(autor);
                        }
                    }
                }
            }
            catch (Exception)
            {
                autores = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return autores;
        }

        private AutorEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            AutorEnt autor = new AutorEnt();
            string query = "SELECT * FROM tbAutor WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autor.Id = Convert.ToInt32(reader["id"]);
                            autor.Autor = reader["autor"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                autor = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return autor;
        }
    }
}
