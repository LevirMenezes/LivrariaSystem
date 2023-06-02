using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class AutorEnt
    {
		private int id;
        private string autor;

        public int Id { get => id; set => id = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
