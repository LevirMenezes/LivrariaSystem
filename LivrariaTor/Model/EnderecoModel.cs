using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class EnderecoModel
    {
        public string Insert(EnderecoEnt endereco)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbEndereco(cep, rua, numero, bairro, cidade, estado, idusuario) VALUES (@cep, @rua, @numero, @bairro, @cidade, @estado, @idusuario)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@cep",       endereco.Cep);
                    command.Parameters.AddWithValue("@rua",       endereco.Rua);
                    command.Parameters.AddWithValue("@numero",    endereco.Numero);
                    command.Parameters.AddWithValue("@bairro",    endereco.Bairro);
                    command.Parameters.AddWithValue("@cidade",    endereco.Cidade);
                    command.Parameters.AddWithValue("@estado",    endereco.Estado);
                    command.Parameters.AddWithValue("@idusuario", endereco.IdUsuario);
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

        public string Update(EnderecoEnt endereco)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbEndereco 
                            SET   cep       = @cep,
                                  rua       = @rua,
                                  numero    = @numero,
                                  bairro    = @bairro,
                                  cidade    = @cidade,
                                  estado    = @estado,
                                  idusuario = @idusuario
                            WHERE id        = @id ";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@cep",       endereco.Cep);
                    command.Parameters.AddWithValue("@rua",       endereco.Rua);
                    command.Parameters.AddWithValue("@numero",    endereco.Numero);
                    command.Parameters.AddWithValue("@bairro",    endereco.Bairro);
                    command.Parameters.AddWithValue("@cidade",    endereco.Cidade);
                    command.Parameters.AddWithValue("@estado",    endereco.Estado);
                    command.Parameters.AddWithValue("@idusuario", endereco.IdUsuario);
                    command.Parameters.AddWithValue("@id",        endereco.Id);
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
            string query = "DELETE FROM tbEndereco WHERE id = @id";
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

        public List<EnderecoEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<EnderecoEnt> enderecos = new List<EnderecoEnt>();
            string query = "SELECT * FROM tbEndereco";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EnderecoEnt endereco = new EnderecoEnt();
                            endereco.Id        = Convert.ToInt32(reader["id"]);
                            endereco.Cep       = reader["cep"].ToString();
                            endereco.Rua       = reader["rua"].ToString();
                            endereco.Numero    = reader["numero"].ToString();
                            endereco.Bairro    = reader["bairro"].ToString();
                            endereco.Cidade    = reader["cidade"].ToString();
                            endereco.Estado    = reader["estado"].ToString();
                            endereco.IdUsuario = Convert.ToInt32(reader["idusuario"]);

                            enderecos.Add(endereco);
                        }
                    }
                }
            }
            catch (Exception)
            {
                enderecos = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return enderecos;
        }

        public EnderecoEnt GetById(int id)
        {
            SqlConnection cn     = Conexao.ObterConexao();
            EnderecoEnt endereco = new EnderecoEnt();
            string query         = "SELECT * FROM tbEndereco WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            endereco.Id        = Convert.ToInt32(reader["id"]);
                            endereco.Cep       = reader["cep"].ToString();
                            endereco.Rua       = reader["rua"].ToString();
                            endereco.Numero    = reader["numero"].ToString();
                            endereco.Bairro    = reader["bairro"].ToString();
                            endereco.Cidade    = reader["cidade"].ToString();
                            endereco.Estado    = reader["estado"].ToString();
                            endereco.IdUsuario = Convert.ToInt32(reader["idusuario"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                endereco = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return endereco;
        }

        public EnderecoEnt GetByUsuarioId(int idusuario)
        {
            SqlConnection cn = Conexao.ObterConexao();
            EnderecoEnt endereco = new EnderecoEnt();
            string query = "SELECT * FROM tbEndereco WHERE idusuario = @idusuario";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            endereco.Id        = Convert.ToInt32(reader["id"]);
                            endereco.Cep       = reader["cep"].ToString();
                            endereco.Rua       = reader["rua"].ToString();
                            endereco.Numero    = reader["numero"].ToString();
                            endereco.Bairro    = reader["bairro"].ToString();
                            endereco.Cidade    = reader["cidade"].ToString();
                            endereco.Estado    = reader["estado"].ToString();
                            endereco.IdUsuario = Convert.ToInt32(reader["idusuario"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                endereco = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return endereco;
        }
    }
}
