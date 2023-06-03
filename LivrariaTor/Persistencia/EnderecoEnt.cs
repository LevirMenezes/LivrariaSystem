using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class EnderecoEnt
    {
        private int id;
        private string cep;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private int idUsuario;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
