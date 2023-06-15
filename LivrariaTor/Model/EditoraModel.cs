using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class EditoraModel
    {
        public string Insert(EditoraEnt editora)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbEditora(nome,telefone) VALUES (@nome, @telefone)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@nome",     editora.Nome);
                    command.Parameters.AddWithValue("@telefone", editora.Telefone);
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

        public string Update(EditoraEnt editora)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbEditora 
                            SET autor    = @autor,
                                telefone = @telefone
                            WHERE id     = @id;";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@nome",     editora.Nome);
                    command.Parameters.AddWithValue("@telefone", editora.Telefone);
                    command.Parameters.AddWithValue("@id",       editora.Id);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Update não foi feito!";
                }
            }
            catch (Exception ex)
            {
                resp = "Erro no update! " + ex.Message;
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
            string query = "DELETE FROM tbEditora WHERE id = @id";
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

        public List<EditoraEnt> GetAll()
        {
            SqlConnection cn          = Conexao.ObterConexao();
            List<EditoraEnt> editoras = new List<EditoraEnt>();
            string query = "SELECT * FROM tbEditora";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EditoraEnt editora = new EditoraEnt();
                            editora.Id         = Convert.ToInt32(reader["id"]);
                            editora.Nome       = reader["nome"].ToString();
                            editora.Telefone   = reader["telefone"].ToString();

                            editoras.Add(editora);
                        }
                    }
                }
            }
            catch (Exception)
            {
                editoras = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return editoras;
        }

        public EditoraEnt GetById(int id)
        {
            SqlConnection cn   = Conexao.ObterConexao();
            EditoraEnt editora = new EditoraEnt();
            string query = "SELECT * FROM tbEditora WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            editora.Id       = Convert.ToInt32(reader["id"]);
                            editora.Nome     = reader["nome"].ToString();
                            editora.Telefone = reader["telefone"].ToString();
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

        public EditoraEnt GetId()
        {
            SqlConnection cn = Conexao.ObterConexao();
            EditoraEnt editora = new EditoraEnt();
            string query = "SELECT TOP 1 * FROM tbEditora ORDER BY id DESC;";
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
                            editora.Telefone = reader["telefone"].ToString();
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
