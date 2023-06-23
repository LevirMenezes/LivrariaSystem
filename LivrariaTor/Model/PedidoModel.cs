using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class PedidoModel
    {
        public string Insert(int idusuario)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query     = "INSERT INTO tbPedido(datacompra, estadopedido, idusuario) VALUES (@datacompra, @estadopedido, @idusuario)";
            string resp      = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@datacompra",       DateTime.Now);
                    command.Parameters.AddWithValue("@estadopedido",     "EM ANDAMENTO");
                    command.Parameters.AddWithValue("@idusuario",        idusuario);
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

        public string Update(PedidoEnt pedido)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbPedido 
                            SET   datacompra       = @datacompra,
                                  estadopedido     = @estadopedido,
                                  idformapagamento = @idformapagamento
                            WHERE id               = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@datacompra",       DateTime.Now);
                    command.Parameters.AddWithValue("@estadopedido",     "CONCLUÍDO");
                    command.Parameters.AddWithValue("@idformapagamento", pedido.IdFormaPagamento);
                    command.Parameters.AddWithValue("@id",               pedido.Id);
                    resp = command.ExecuteNonQuery() >= 1 ? "OK" : "O Update não foi feito!";
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
            string query = "DELETE FROM tbPedido WHERE id = @id";
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

        public List<PedidoEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<PedidoEnt> pedidos = new List<PedidoEnt>();
            string query = "SELECT * FROM tbPedido";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoEnt pedido        = new PedidoEnt();
                            pedido.Id               = Convert.ToInt32(reader["id"]);
                            pedido.DataCompra       = Convert.ToDateTime(reader["datacompra"]);
                            pedido.PrecoTotal       = Convert.ToDecimal(reader["precototal"]);
                            pedido.EstadoPedido     = reader["estadopedido"].ToString();
                            pedido.IdFormaPagamento = Convert.ToInt32(reader["idformapagamento"]);
                            pedido.IdUsuario        = Convert.ToInt32(reader["idusuario"]);
                            
                            pedidos.Add(pedido);
                        }
                    }
                }
            }
            catch (Exception)
            {
                pedidos = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return pedidos;
        }

        public PedidoEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            PedidoEnt pedido = new PedidoEnt();
            string query = "SELECT * FROM tbPedido WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedido.Id               = Convert.ToInt32(reader["id"]);
                            pedido.DataCompra       = Convert.ToDateTime(reader["datacompra"]);
                            pedido.PrecoTotal       = Convert.ToDecimal(reader["precototal"]);
                            pedido.EstadoPedido     = reader["estadopedido"].ToString();
                            pedido.IdFormaPagamento = Convert.ToInt32(reader["idformapagamento"]);
                            pedido.IdUsuario        = Convert.ToInt32(reader["idusuario"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                pedido = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return pedido;
        }

        public PedidoEnt GetByUsuarioId(int idusuario)
        {
            SqlConnection cn = Conexao.ObterConexao();
            PedidoEnt pedido = new PedidoEnt();
            string query = @"SELECT TOP 1 *
                             FROM tbPedido PE
                             WHERE PE.idusuario    = @idusuario AND 
                                   PE.estadopedido = 'EM ANDAMENTO' 
                             ORDER BY PE.id DESC";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedido.Id               = Convert.ToInt32(   reader["id"]);
                            pedido.DataCompra       = Convert.ToDateTime(reader["datacompra"]);
                            pedido.PrecoTotal       = reader.IsDBNull(reader.GetOrdinal("precototal")) ? 0 : Convert.ToDecimal( reader["precototal"]);
                            pedido.EstadoPedido     = reader["estadopedido"].ToString();
                            pedido.IdUsuario        = Convert.ToInt32(   reader["idusuario"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                pedido = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return ((pedido.Id == 0 || pedido == null) ? null : pedido);
        }

        public List<RelatorioVendasEnt> GetRelatorioVendas()
        {
            List<RelatorioVendasEnt> Relatorios = new List<RelatorioVendasEnt>();
            
            try
            {
                SqlConnection cn = Conexao.ObterConexao();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "gerar_relatorio_vendas_completo";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RelatorioVendasEnt Relatorio = new RelatorioVendasEnt();
                            Relatorio.Pedidoid           = Convert.ToInt32(   reader["PedidoId"]);
                            Relatorio.DataCompra         = Convert.ToDateTime(reader["DataCompra"]).ToString("dd/MM/yyyy");
                            Relatorio.NomeUsuario        = Convert.ToString(  reader["NomeUsuario"]);
                            Relatorio.EmailUsuario       = Convert.ToString(  reader["EmailUsuario"]);
                            Relatorio.TituloLivro        = Convert.ToString(  reader["TituloLivro"]);
                            Relatorio.PrecoLivro         = Convert.ToDecimal( reader["PrecoLivro"]);
                            Relatorio.Quantidade         = Convert.ToInt32(   reader["Quantidade"]);
                            Relatorio.Subtotal           = Convert.ToDecimal( reader["Subtotal"]);
                            Relatorio.TipoPagamento      = Convert.ToString(  reader["TipoPagamento"]);

                            Relatorios.Add(Relatorio);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Relatorios = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            
            if (Relatorios == null)
                return null;
            else
                if (Relatorios.Count == 0)
                    return null;
                else
                    return Relatorios;

        }

    }

}
