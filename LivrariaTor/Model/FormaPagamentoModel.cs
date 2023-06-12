using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class FormaPagamentoModel
    {
        public string Insert(FormaPagamentoEnt forma_pagamento)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = "INSERT INTO tbFormaPagamento(tipopagamento) VALUES (@tipopagamento)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@tipopagamento", forma_pagamento.TipoPagamento);
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

        public string Update(FormaPagamentoEnt forma_pagamento)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbFormaPagamento 
                            SET tipopagamento = @tipopagamento
                            WHERE id   = @id ";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@tipopagamento", forma_pagamento.TipoPagamento);
                    command.Parameters.AddWithValue("@id",            forma_pagamento.Id);
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
            string query = "DELETE FROM tbFormaPagamento WHERE id = @id";
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

        public List<FormaPagamentoEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<FormaPagamentoEnt> formas_pagamento = new List<FormaPagamentoEnt>();
            string query = "SELECT * FROM tbFormaPagamento";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FormaPagamentoEnt forma_pagamento = new FormaPagamentoEnt();
                            forma_pagamento.Id                = Convert.ToInt32(reader["id"]);
                            forma_pagamento.TipoPagamento     = reader["tipopagamento"].ToString();

                            formas_pagamento.Add(forma_pagamento);
                        }
                    }
                }
            }
            catch (Exception)
            {
                formas_pagamento = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return formas_pagamento;
        }

        public FormaPagamentoEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            FormaPagamentoEnt forma_pagamento = new FormaPagamentoEnt();
            string query = "SELECT * FROM tbFormaPagamento WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            forma_pagamento.Id            = Convert.ToInt32(reader["id"]);
                            forma_pagamento.TipoPagamento = reader["tipopagamento"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                forma_pagamento = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return forma_pagamento;
        }
    }
}
