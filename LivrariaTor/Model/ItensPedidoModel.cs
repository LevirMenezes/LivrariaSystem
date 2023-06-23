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
            string query = "INSERT INTO tbItensPedido(quantidade, precounidade, idpedido, idlivro) VALUES (@quantidade, @precounidade, @idpedido, @idlivro)";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@quantidade",   item.Quantidade);
                    command.Parameters.AddWithValue("@precounidade", item.PrecoUnidade);
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

      

        internal List<ItensPedidoEnt> GetAllByUsuario(object idusuario)
        {
            throw new NotImplementedException();
        }

        public string UpdateItem(ItensPedidoEnt item)
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

        public string UpdateQuantidade(ItensPedidoEnt item)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string query = @"UPDATE tbItensPedido 
                            SET    quantidade = @quantidade
                            WHERE         id  = @id";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@quantidade", item.Quantidade);
                    command.Parameters.AddWithValue("@id",         item.Id);
                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "O Update não foi feito!";
                }
            }
            catch (Exception ex)
            {
                resp = "Erro no update!" + ex.Message;
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

        public List<ItensPedidoEnt> GetAllByUsuario(int idusuario)
        {
            SqlConnection        cn     = Conexao.ObterConexao();
            List<ItensPedidoEnt> Itens  = new List<ItensPedidoEnt>();
            string               query  = @"SELECT IPE.id as itemid,  IPE.quantidade, IPE.precounidade, IPE.subtotal, IPE.idpedido, IPE.idlivro,
                                                   LI.id  as livroid, LI.titulo, LI.preco, LI.descricao, LI.estoque, LI.anopublicacao, LI.isbn, LI.imagem, LI.ideditora
                                            FROM tbItensPedido IPE
                                            INNER JOIN tbLivro LI ON IPE.idlivro = LI.id
                                            WHERE IPE.idpedido IN 
                                            (
                                            SELECT TOP 1 PE.id
                                            FROM tbPedido PE
                                            WHERE    PE.idusuario    = @idusuario AND 
                                                     PE.estadopedido = 'EM ANDAMENTO'
                                            ORDER BY PE.id DESC
                                            )
                                            ";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LivroEnt livro         = new LivroEnt();
                            livro.Id               = Convert.ToInt32(reader["livroid"]);
                            livro.Titulo           = reader["titulo"].ToString();
                            livro.Preco            = Convert.ToDecimal(reader["preco"]);
                            livro.Descricao        = reader["descricao"].ToString();
                            livro.Estoque          = Convert.ToInt32(reader["estoque"]);
                            livro.AnoPublicacao    = Convert.ToDateTime(reader["anopublicacao"]).ToString("dd/MM/yyyy");
                            livro.Isbn             = reader["isbn"].ToString();
                            livro.IdEditora        = Convert.ToInt32(reader["ideditora"]);
                                                   
                            if (!reader.IsDBNull(reader.GetOrdinal("imagem")))
                            {
                                long tamanhoBytes  = reader.GetBytes(reader.GetOrdinal("imagem"), 0, null, 0, 0);
                                byte[] imagemBytes = new byte[tamanhoBytes];
                                reader.GetBytes(reader.GetOrdinal("imagem"), 0, imagemBytes, 0, (int)tamanhoBytes);

                                livro.Imagem       = imagemBytes;
                            }

                            ItensPedidoEnt itensPedidoEnt = new ItensPedidoEnt();
                            itensPedidoEnt.Id             = reader.IsDBNull(reader.GetOrdinal("itemid")) ? 0  : Convert.ToInt32(  reader["itemid"]);
                            itensPedidoEnt.Quantidade     = reader.IsDBNull(reader.GetOrdinal("quantidade")) ? 0  : Convert.ToInt32(  reader["quantidade"]);
                            itensPedidoEnt.PrecoUnidade   = reader.IsDBNull(reader.GetOrdinal("precounidade")) ? 0m : Convert.ToDecimal(reader["precounidade"]);
                            itensPedidoEnt.SubTotal       = reader.IsDBNull(reader.GetOrdinal("subtotal")) ? 0m : Convert.ToDecimal(reader["subtotal"]);
                            itensPedidoEnt.IdPedido       = reader.IsDBNull(reader.GetOrdinal("idpedido")) ? 0  : Convert.ToInt32(  reader["idpedido"]);
                            itensPedidoEnt.IdLivro        = reader.IsDBNull(reader.GetOrdinal("idlivro")) ? 0  : Convert.ToInt32(  reader["idlivro"]);
                            itensPedidoEnt.Livro          = livro;
                            
                            Itens.Add(itensPedidoEnt);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Itens = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            if (Itens == null || Itens.Count == 0)
                return null;
            else
                return Itens;
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

        public ItensPedidoEnt GetByLivroIdAndUsuarioId(int idlivro, int idusuario)
        {
            SqlConnection cn = Conexao.ObterConexao();
            ItensPedidoEnt Itens = new ItensPedidoEnt();
            string query = @"SELECT IPE.id as itemid,  IPE.quantidade, IPE.precounidade, IPE.subtotal, IPE.idpedido, IPE.idlivro,
                                                   LI.id  as livroid, LI.titulo, LI.preco, LI.descricao, LI.estoque, LI.anopublicacao, LI.isbn, LI.imagem, LI.ideditora
                                            FROM tbItensPedido IPE
                                            INNER JOIN tbLivro LI ON IPE.idlivro = LI.id
                                            WHERE IPE.idpedido IN 
                                            (
                                            SELECT TOP 1 PE.id
                                            FROM tbPedido PE
                                            WHERE    PE.idusuario    = @idusuario AND 
                                                     PE.estadopedido = 'EM ANDAMENTO'
                                            ORDER BY PE.id DESC
                                            )
                                            ";

            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LivroEnt livro = new LivroEnt();
                            livro.Id = Convert.ToInt32(reader["livroid"]);
                            livro.Titulo = reader["titulo"].ToString();
                            livro.Preco = Convert.ToDecimal(reader["preco"]);
                            livro.Descricao = reader["descricao"].ToString();
                            livro.Estoque = Convert.ToInt32(reader["estoque"]);
                            livro.AnoPublicacao = Convert.ToDateTime(reader["anopublicacao"]).ToString("dd/MM/yyyy");
                            livro.Isbn = reader["isbn"].ToString();
                            livro.IdEditora = Convert.ToInt32(reader["ideditora"]);

                            if (!reader.IsDBNull(reader.GetOrdinal("imagem")))
                            {
                                long tamanhoBytes = reader.GetBytes(reader.GetOrdinal("imagem"), 0, null, 0, 0);
                                byte[] imagemBytes = new byte[tamanhoBytes];
                                reader.GetBytes(reader.GetOrdinal("imagem"), 0, imagemBytes, 0, (int)tamanhoBytes);

                                livro.Imagem = imagemBytes;
                            }

                            
                            Itens.Id           = reader.IsDBNull(reader.GetOrdinal("itemid")) ? 0 : Convert.ToInt32(reader["itemid"]);
                            Itens.Quantidade   = reader.IsDBNull(reader.GetOrdinal("quantidade")) ? 0 : Convert.ToInt32(reader["quantidade"]);
                            Itens.PrecoUnidade = reader.IsDBNull(reader.GetOrdinal("precounidade")) ? 0m : Convert.ToDecimal(reader["precounidade"]);
                            Itens.SubTotal     = reader.IsDBNull(reader.GetOrdinal("subtotal")) ? 0m : Convert.ToDecimal(reader["subtotal"]);
                            Itens.IdPedido     = reader.IsDBNull(reader.GetOrdinal("idpedido")) ? 0 : Convert.ToInt32(reader["idpedido"]);
                            Itens.IdLivro      = reader.IsDBNull(reader.GetOrdinal("idlivro")) ? 0 : Convert.ToInt32(reader["idlivro"]);
                            Itens.Livro        = livro;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Itens = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }
            if (Itens == null)
                return null;
            else
                return Itens;
        }
    }
}
