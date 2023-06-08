using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LivrariaTor.Persistencia
{
    public class LivroEnt
    {
		private int id;
		private string titulo;
		private decimal preco;
        private string descricao;
        private int estoque;
        private string anoPublicacao;
        private string isbn;
        private int idEditora;
        private byte[] imagem;

        public int Id { get { return id; } set { id = value; }}
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public decimal Preco { get { return preco; } set { preco = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public int Estoque { get { return estoque; } set { estoque = value; } }
        public string AnoPublicacao { get { return anoPublicacao; } set { anoPublicacao = value; }	}
        public string Isbn { get { return isbn; } set { isbn = value; }	}
        public int IdEditora { get { return idEditora; } set { idEditora = value; }	}

        public byte[] Imagem { get => imagem; set => imagem = value; }

        public LivroEnt()
        {
            Id            = 0;
            Titulo        = string.Empty;
            Preco         = 0m;
            Descricao     = string.Empty;
            Estoque       = 0;
            Isbn          = string.Empty;
            IdEditora     = 0;
        }

        public Image ByteToIMG()
        {
            if (this.Imagem != null)
            {
                using (MemoryStream ms = new MemoryStream(this.Imagem))
                {
                    return Image.FromStream(ms);
                }
            }
            else
            {
                return null;
            }
            
        }
    }
}
