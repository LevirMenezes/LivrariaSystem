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
    public partial class ItemLivro : UserControl
    {
        private string _title;
        private string _descricao;
        private decimal _precoLivro;
        private Image _imagemLivro;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblTituloLivro.Text = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; lblDescricaoLivro.Text = value; }
        }
        public decimal PrecoLivro
        {
            get { return _precoLivro; }
            set { _precoLivro = value; lblPrecoLivro.Text = value.ToString("F2"); }
        }
        public Image ImagemLivro
        {
            get { return _imagemLivro; }
            set { _imagemLivro = value; picboxLivro.Image = value; }
        }

        public LivroEnt Livro { get; set; }

        public event EventHandler<ItemLivroEventArgs> ItemClicado;

        public ItemLivro()
        {
            InitializeComponent();
        }

        private void ItemLivro_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ItemLivro_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        
        private void ItemLivro_Click(object sender, EventArgs e)
        {
            ItemClicado?.Invoke(this, new ItemLivroEventArgs(Livro, ImagemLivro));
        }
    }
}
