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
                    command.Parameters.AddWithValue("@nome", autor.Nome);
                    resp = command.ExecuteNonQuery()==1?"OK":"O Insert não foi feito!";
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

        public string Update(AutorEnt autor)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbAutor 
                            SET nome = @nome
                            WHERE id = @id ";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@nome", autor.Nome);
                    command.Parameters.AddWithValue("@id", autor.Id);
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
        
        public string Delete(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "DELETE FROM tbAutor WHERE id = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
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
        
        public List<AutorEnt> GetAll()
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
                            autor.Id       = Convert.ToInt32(reader["id"]);
                            autor.Nome     = reader["nome"].ToString();

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
        
        public AutorEnt GetById(int id)
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
                            autor.Id    = Convert.ToInt32(reader["id"]);
                            autor.Nome  = reader["nome"].ToString();
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

        public AutorEnt GetByLivroId(int idlivro)
        {
            SqlConnection cn = Conexao.ObterConexao();
            AutorEnt autor = new AutorEnt();
            string query = @"SELECT autor.id, autor.nome FROM tbLivroAutor
                             INNER JOIN tbAutor AS autor
                             ON autor.id = tbLivroAutor.idautor
                             WHERE tbLivroAutor.idlivro = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", idlivro);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autor.Id = Convert.ToInt32(reader["id"]);
                            autor.Nome = reader["nome"].ToString();
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

        public AutorEnt GetId()
        {
            SqlConnection cn = Conexao.ObterConexao();
            AutorEnt editora = new AutorEnt();
            string query = "SELECT TOP 1 * FROM tbAutor ORDER BY id DESC;";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            editora.Id = Convert.ToInt32(reader["id"]);
                            editora.Nome = reader["nome"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                editora = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return editora;
        }

    }
}
