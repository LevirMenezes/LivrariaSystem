using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class EditoraEnt
    {
		private int id;
		private string telefone;
		private string nome;

        public int Id { get => id; set => id = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
