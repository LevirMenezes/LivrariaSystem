using System;

namespace LivrariaTor.Persistencia
{
	public class PedidoEnt
    {
        private int id;
        private DateTime dataCompra;
        private decimal precoTotal;
        private string estadoPedido;
        private int idFormaPagamento;
        private int idUsuario;

        public int Id { get => id; set => id = value; }
        public DateTime DataCompra { get => dataCompra; set => dataCompra = value; }
        public decimal PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public string EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
        public int IdFormaPagamento { get => idFormaPagamento; set => idFormaPagamento = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
