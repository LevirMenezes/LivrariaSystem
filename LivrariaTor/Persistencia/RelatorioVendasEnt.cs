using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class RelatorioVendasEnt
    {
        private int     pedidoid;
        private string  dataCompra;
        private string  nomeUsuario;
        private string  emailUsuario;
        private string  tituloLivro;
        private decimal precoLivro;
        private int     quantidade;
        private decimal subtotal;
        private string  tipoPagamento;

        public int     Pedidoid      { get => pedidoid;      set => pedidoid      = value; }
        public string  DataCompra    { get => dataCompra;    set => dataCompra    = value; }
        public string  NomeUsuario   { get => nomeUsuario;   set => nomeUsuario   = value; }
        public string  EmailUsuario  { get => emailUsuario;  set => emailUsuario  = value; }
        public string  TituloLivro   { get => tituloLivro;   set => tituloLivro   = value; }
        public decimal PrecoLivro    { get => precoLivro;    set => precoLivro    = value; }
        public int     Quantidade    { get => quantidade;    set => quantidade    = value; }
        public decimal Subtotal      { get => subtotal;      set => subtotal      = value; }
        public string  TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
    }
}
