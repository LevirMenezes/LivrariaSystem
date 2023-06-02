using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class FormaPagamentoEnt
    {
		private int id;
		private string tipoPagamento;

        public int Id { get => id; set => id = value; }
        public string TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
    }
}
