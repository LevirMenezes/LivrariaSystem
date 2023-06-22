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
    public partial class ItemCarrinho : UserControl
    {
        private Image                _imagem;
        private string               _title;
        private decimal              _subtotal;
        private List<EnumQuantidade> _listaquantidade;

        public List<EnumQuantidade> Listaquantidade { get => _listaquantidade; set { _listaquantidade = value; cbxQuantidade.DataSource = value; } }
        
        public Image        Imagem                  { get => _imagem;          set { _imagem          = value; picboxIMG.Image          = value; } }
                                                    
        public string       Title                   { get => _title;           set { _title           = value; lblTituloLivro.Text      = value; } }
                                                    
        public decimal      Subtotal                { get => _subtotal;        set { _subtotal        = value; lblSubtotal.Text         = value.ToString("F2"); } }
                                                    
        public LivroEnt     Livro                   { get; set; }

        public event EventHandler<ItemLivroEventArgs> ItemClicado;

        public ItemCarrinho()
        {
            InitializeComponent();
        }

        private void btnIMGFechar_Click(object sender, EventArgs e)
        {
            ItemClicado?.Invoke(this, new ItemLivroEventArgs(Livro, null));
        }
    }
}
