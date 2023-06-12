using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class ItensPedidoModel
    {
        public string Insert(ItensPedidoEnt item)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbItensPedido(quantidade, precounidade, subtotal, idpedido, idlivro) VALUES (@quantidade, @precounidade, @subtotal, @idpedido, @idlivro)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@quantidade",   item.Quantidade);
                    command.Parameters.AddWithValue("@precounidade", item.PrecoUnidade);
                    command.Parameters.AddWithValue("@subtotal",     item.SubTotal);
                    command.Parameters.AddWithValue("@idpedido",     item.IdPedido);
                    command.Parameters.AddWithValue("@idlivro",      item.IdLivro);
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

        public string Update(ItensPedidoEnt item)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbItensPedido 
                            SET    quantidade = @quantidade
                                 precounidade = @precounidade
                                     subtotal = @subtotal
                                     idpedido = @idpedido
                                     idlivro  = @idlivro
                            WHERE         id  = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@quantidade",   item.Quantidade);
                    command.Parameters.AddWithValue("@precounidade", item.PrecoUnidade);
                    command.Parameters.AddWithValue("@subtotal",     item.SubTotal);
                    command.Parameters.AddWithValue("@idpedido",     item.IdPedido);
                    command.Parameters.AddWithValue("@idlivro",      item.IdLivro);
                    command.Parameters.AddWithValue("@id",           item.Id);
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
            string query = "DELETE FROM tbItensPedido WHERE id = @id";
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

        public List<ItensPedidoEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<ItensPedidoEnt> itens = new List<ItensPedidoEnt>();
            string query = "SELECT * FROM tbItensPedido";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItensPedidoEnt Item = new ItensPedidoEnt();
                            Item.Quantidade     = Convert.ToInt32(  reader["id"]);
                            Item.PrecoUnidade   = Convert.ToDecimal(reader["genero"]);
                            Item.SubTotal       = Convert.ToDecimal(reader["genero"]);
                            Item.IdPedido       = Convert.ToInt32(  reader["genero"]);
                            Item.IdLivro        = Convert.ToInt32(  reader["genero"]);
                            Item.Id             = Convert.ToInt32(  reader["genero"]);

                            itens.Add(Item);
                        }
                    }
                }
            }
            catch (Exception)
            {
                itens = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return itens;
        }

        public ItensPedidoEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            ItensPedidoEnt Item = new ItensPedidoEnt();
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
                            Item.Quantidade   = Convert.ToInt32(  reader["id"]);
                            Item.PrecoUnidade = Convert.ToDecimal(reader["genero"]);
                            Item.SubTotal     = Convert.ToDecimal(reader["genero"]);
                            Item.IdPedido     = Convert.ToInt32(  reader["genero"]);
                            Item.IdLivro      = Convert.ToInt32(  reader["genero"]);
                            Item.Id           = Convert.ToInt32(  reader["genero"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Item = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return Item;
        }
    }
}
