using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class ItensPedidoEnt
    {
		private int id;
        private int quantidade;
        private decimal precoUnidade;
        private decimal subTotal;
        private int idPedido;
        private int idLivro;

        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal PrecoUnidade { get => precoUnidade; set => precoUnidade = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }
    }
}
