﻿using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class PedidoModel
    {
        public string Insert(PedidoEnt pedido)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbPedido(datacompra, precototal, estadopedido, idformapagamento, idusuario) VALUES (@datacompra, @precototal, @estadopedido, @idformapagamento, @idusuario)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@datacompra",       pedido.DataCompra);
                    command.Parameters.AddWithValue("@precototal",       pedido.PrecoTotal);
                    command.Parameters.AddWithValue("@estadopedido",     pedido.EstadoPedido);
                    command.Parameters.AddWithValue("@idformapagamento", pedido.IdFormaPagamento);
                    command.Parameters.AddWithValue("@idusuario",        pedido.IdUsuario);
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
                            SET   datacompra       = @datacompra
                                  precototal       = @precototal
                                  estadopedido     = @estadopedido
                                  idformapagamento = @idformapagamento
                                  idusuario        = @idusuario
                            WHERE id               = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@datacompra",       pedido.DataCompra);
                    command.Parameters.AddWithValue("@precototal",       pedido.PrecoTotal);
                    command.Parameters.AddWithValue("@estadopedido",     pedido.EstadoPedido);
                    command.Parameters.AddWithValue("@idformapagamento", pedido.IdFormaPagamento);
                    command.Parameters.AddWithValue("@idusuario",        pedido.IdUsuario);
                    command.Parameters.AddWithValue("@id",               pedido.Id);
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
    }
}
