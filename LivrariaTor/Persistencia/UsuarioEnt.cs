using System.Drawing;
using System.IO;

namespace LivrariaTor.Persistencia
{
    public class UsuarioEnt
    {
        private int id;      
        private string nome;    
        private string telefone;
        private string cpf;     
        private string email;   
        private string senha;   
        private int adm;
        private byte[] imagem;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Adm { get => adm; set => adm = value; }
        public byte[] Imagem { get => imagem; set => imagem = value; }

        public UsuarioEnt()
        {
            Id       = 0;
            Nome     = string.Empty;
            Telefone = string.Empty;
            Cpf      = string.Empty;
            Email    = string.Empty;
            Senha    = string.Empty;
            Adm      = 0;
            Imagem   = null;
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
