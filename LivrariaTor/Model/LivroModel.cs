using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LivrariaTor.Model
{
    public class LivroModel
    {
        public string Insert(LivroEnt livro)
        {
            SqlConnection cn = Conexao.ObterConexao();

            string query = "INSERT INTO tbLivro (titulo, preco, descricao, estoque, anopublicacao, isbn, ideditora, imagem) VALUES  (@titulo, @preco, @descricao, @estoque, @anopublicacao, @isbn, @ideditora, @imagem);";
            string resp = string.Empty;
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@titulo",        livro.Titulo);
                    command.Parameters.AddWithValue("@preco",         livro.Preco);
                    command.Parameters.AddWithValue("@descricao",     livro.Descricao);
                    command.Parameters.AddWithValue("@estoque",       livro.Estoque);
                    command.Parameters.AddWithValue("@anopublicacao", livro.AnoPublicacao);
                    command.Parameters.AddWithValue("@isbn",          livro.Isbn);
                    command.Parameters.AddWithValue("@ideditora",     livro.IdEditora);
                    command.Parameters.AddWithValue("@imagem",        livro.Imagem);
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

        public string Update(LivroEnt livro)
        {
            SqlConnection cn = Conexao.ObterConexao();
            string resp      = string.Empty;
            string query     = @"UPDATE tbLivro 
                                 SET nome      = @titulo,
                                 telefone      = @preco,
                                 cpf           = @descricao,
                                 email         = @estoque,
                                 anopublicacao = @anopublicacao,
                                 isbn          = @isbn,
                                 ideditora     = @ideditora,
                                 imagem        = @imagem
                                 WHERE id      = @id;";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id",            livro.Id);
                    command.Parameters.AddWithValue("@titulo",        livro.Titulo);
                    command.Parameters.AddWithValue("@preco",         livro.Preco);
                    command.Parameters.AddWithValue("@descricao",     livro.Descricao);
                    command.Parameters.AddWithValue("@estoque",       livro.Estoque);
                    command.Parameters.AddWithValue("@anopublicacao", livro.AnoPublicacao);
                    command.Parameters.AddWithValue("@isbn",          livro.Isbn);
                    command.Parameters.AddWithValue("@ideditora",     livro.IdEditora);
                    command.Parameters.AddWithValue("@imagem",        livro.Imagem);
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
            string query = "DELETE FROM tbLivro WHERE id = @id";
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

        public List<LivroEnt> GetAll()
        {
            SqlConnection cn = Conexao.ObterConexao();
            List<LivroEnt> livros = new List<LivroEnt>();
            string query = "SELECT * FROM tbLivro";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LivroEnt livro = new LivroEnt();
                            livro.Id            = Convert.ToInt32(reader["id"]);
                            livro.Titulo        = reader["titulo"].ToString();
                            livro.Preco         = Convert.ToDecimal(reader["preco"]);
                            livro.Descricao     = reader["descricao"].ToString();
                            livro.Estoque       = Convert.ToInt32(reader["estoque"]);
                            livro.AnoPublicacao = Convert.ToDateTime(reader["anopublicacao"]).ToString("dd/MM/yyyy");
                            livro.Isbn          = reader["isbn"].ToString();
                            livro.IdEditora     = Convert.ToInt32(reader["ideditora"]);

                            if (!reader.IsDBNull(reader.GetOrdinal("imagem")))
                            {
                                long tamanhoBytes = reader.GetBytes(reader.GetOrdinal("imagem"), 0, null, 0, 0);
                                byte[] imagemBytes = new byte[tamanhoBytes];
                                reader.GetBytes(reader.GetOrdinal("imagem"), 0, imagemBytes, 0, (int)tamanhoBytes);

                                livro.Imagem = imagemBytes;
                            }

                            livros.Add(livro);
                        }
                    }
                }
            }
            catch (Exception)
            {
                livros = null;
            }
            finally
            {
                Conexao.FecharConexao();

            }

            return livros;
        }

        public LivroEnt GetById(int id)
        {
            SqlConnection cn = Conexao.ObterConexao();
            LivroEnt livro = new LivroEnt();
            string query = "SELECT * FROM tbLivro WHERE id = @id";
            try
            {
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            livro.Id            = Convert.ToInt32(reader["id"]);
                            livro.Titulo        = reader["titulo"].ToString();
                            livro.Preco         = Convert.ToDecimal(reader["preco"]);
                            livro.Descricao     = reader["descricao"].ToString();
                            livro.Estoque       = Convert.ToInt32(reader["estoque"]);
                            livro.AnoPublicacao = Convert.ToDateTime(reader["anopublicacao"]).ToString("dd/MM/yyyy");
                            livro.Isbn          = reader["isbn"].ToString();
                            livro.IdEditora     = Convert.ToInt32(reader["ideditora"]);

                            if (!reader.IsDBNull(reader.GetOrdinal("imagem")))
                            {
                                long tamanhoBytes = reader.GetBytes(reader.GetOrdinal("imagem"), 0, null, 0, 0);
                                byte[] imagemBytes = new byte[tamanhoBytes];
                                reader.GetBytes(reader.GetOrdinal("imagem"), 0, imagemBytes, 0, (int)tamanhoBytes);

                                livro.Imagem = imagemBytes;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                livro = null;
            }
            finally
            {
                Conexao.FecharConexao();
            }

            return livro;
        }


    }
}
