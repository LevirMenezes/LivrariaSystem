using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaTor.View
{

    public partial class ItemRelatoriodeVendas : UserControl
    {

        private string _title;
        private string _usuario;
        private string _email;
        private string _formaspagamento;
        private string _datadacompra;
        private decimal _precoLivro;
        private decimal _subtotal;
        private int _quantidade;
        private Image _imagemLivro;

        public string Title { get => _title; set { _title = value; lblTituloLivro.Text = value; } }

        public string Usuario { get => _usuario; set { _usuario = value; lblUsuario.Text = value.ToString(); } }

        public string Email { get => _email; set { _email = value; lblEmail.Text = value.ToString(); } }

        public string Formaspagamento { get => _formaspagamento; set { _formaspagamento = value; lblFormadePagamento.Text = value.ToString(); } }

        public string Datadacompra { get => _datadacompra; set { _datadacompra = value;  lblDataCompra.Text = value.ToString(); } }

        public decimal PrecoLivro { get => _precoLivro; set { _precoLivro = value; lblPreco.Text = value.ToString("F2"); } }

        public decimal Subtotal { get => _subtotal; set { _subtotal = value; lblSubtotal.Text = value.ToString("F2"); } }
        public int Quantidade { get => _quantidade; set { _quantidade = value; lblQuantidade.Text = value.ToString(); } }

        public Image ImagemLivro { get => _imagemLivro; set { _imagemLivro = value; picboxLivro.Image = value; } }


        public ItemRelatoriodeVendas()
        {
            InitializeComponent();
        }

       

        
    }
}

