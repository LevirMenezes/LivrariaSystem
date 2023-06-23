using LivrariaTor.Persistencia;
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
    public partial class ItemRelatorioestoque : UserControl
    {
        private string _title;
        private decimal _AnodePublicacao;
        private decimal _precoLivro;
        private decimal _isbn;
        private decimal _Estoque;
        private Image _imagemLivro;

        public LivroEnt Livro { get; set; }

        public string Title { get => _title; set { _title = value; lblTituloLivro.Text = value; } }

        public decimal AnodePublicacao { get => _AnodePublicacao; set { _AnodePublicacao = value; lblAnopublicacao.Text = value.ToString("F2"); } }

        public decimal PrecoLivro { get => _precoLivro; set { _precoLivro = value; lblPreco.Text = value.ToString("F2"); } }

        public decimal isbn { get => _isbn; set { _isbn = value; lblIsbn.Text = value.ToString("F4"); } }
        public decimal Estoque { get => _Estoque; set { _Estoque = value; lblEstoque.Text = value.ToString("F2"); } }

        public Image ImagemLivro { get => _imagemLivro; set { _imagemLivro = value; picboxLivro.Image = value; } }

        public ItemRelatorioestoque()
        {
            InitializeComponent();
        }

       
        
    }
}

