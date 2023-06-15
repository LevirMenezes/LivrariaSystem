using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class UsuarioModel
    {
        public string Insert(UsuarioEnt usuario)
        {
            SqlConnection cn = Conexao.ObterConexao();

            string query = "INSERT INTO tbUsuario(nome, telefone, cpf, email, senha, adm) VALUES (@nome, @telefone, @cpf, @email, @senha, 0);";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@nome",     usuario.Nome);
                    command.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    command.Parameters.AddWithValue("@cpf",      usuario.Cpf);
                    command.Parameters.AddWithValue("@email",    usuario.Email);
                    command.Parameters.AddWithValue("@senha",    usuario.Senha);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Insert não foi feito!";
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

        public string Update(UsuarioEnt usuario)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbUsuario 
                             SET nome = @nome,
                             telefone = @telefone,
                             cpf      = @cpf,
                             email    = @email,
                             senha    = @senha
                             WHERE id = @id;";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id",   usuario.Id);
                    command.Parameters.AddWithValue("@nome", usuario.Nome);
                    command.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    command.Parameters.AddWithValue("@cpf", usuario.Cpf);
                    command.Parameters.AddWithValue("@email", usuario.Email);
                    command.Parameters.AddWithValue("@senha", usuario.Senha);
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
            string query = "DELETE FROM tbUsuario WHERE id = @id";
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

        public List<UsuarioEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<UsuarioEnt> usuarios = new List<UsuarioEnt>();
            string query = "SELECT * FROM tbUsuario";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsuarioEnt usuario = new UsuarioEnt();
                            usuario.Id         = Convert.ToInt32(reader["id"]);
                            usuario.Nome       = reader["nome"].ToString();
                            usuario.Telefone   = reader["telefone"].ToString();
                            usuario.Cpf        = reader["cpf"].ToString();
                            usuario.Email      = reader["email"].ToString();
                            usuario.Senha      = reader["senha"].ToString();
                            usuario.Adm        = Convert.ToInt32(reader["adm"]);

                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception)
            {
                usuarios = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return usuarios;
        }

        public UsuarioEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            UsuarioEnt usuario = new UsuarioEnt();
            string query = "SELECT * FROM tbUsuario WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Id       = Convert.ToInt32(reader["id"]);
                            usuario.Nome     = reader["nome"].ToString();
                            usuario.Telefone = reader["telefone"].ToString();
                            usuario.Cpf      = reader["cpf"].ToString();
                            usuario.Email    = reader["email"].ToString();
                            usuario.Senha    = reader["senha"].ToString();
                            usuario.Adm      = Convert.ToInt32(reader["adm"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                usuario = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return usuario;
        }

        public UsuarioEnt GetLogin(string username, string password)
        {
            SqlConnection cn  = Conexao.ObterConexao();
            UsuarioEnt usuario = new UsuarioEnt();
            string query = "SELECT * FROM tbUsuario WHERE email = @email and senha = @senha";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@email", username);
                    command.Parameters.AddWithValue("@senha", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Id       = Convert.ToInt32(reader["id"]);
                            usuario.Nome     = reader["nome"].ToString();
                            usuario.Telefone = reader["telefone"].ToString();
                            usuario.Cpf      = reader["cpf"].ToString();
                            usuario.Email    = reader["email"].ToString();
                            usuario.Senha    = reader["senha"].ToString();
                            usuario.Adm      = Convert.ToInt32(reader["adm"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                usuario = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return usuario.Id == 0 ? null : usuario;
        }

    }
}
