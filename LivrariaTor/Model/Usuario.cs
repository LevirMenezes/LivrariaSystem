using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int adm { get; set; }
    }
}
