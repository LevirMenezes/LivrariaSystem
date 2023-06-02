using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class GeneroEnt
    {
		private int id;
        private string genero;

        public int Id { get => id; set => id = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
