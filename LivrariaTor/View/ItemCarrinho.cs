using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool                 _config           = true;

        public List<EnumQuantidade> Listaquantidade   { get => _listaquantidade; set 
            { 
                _listaquantidade            = value; 
                cbxQuantidade.DataSource    = value; 
                cbxQuantidade.DisplayMember = "numString";
                // cbxQuantidade.SelectedIndex = (Item.Quantidade - 1);
            } }
        
        public Image          Imagem                  { get => _imagem;          set { _imagem          = value; picboxIMG.Image          = value; } }
                                                      
        public string         Title                   { get => _title;           set { _title           = value; lblTituloLivro.Text      = value; } }
                                                      
        public decimal        Subtotal                { get => _subtotal;        set { _subtotal        = value; lblSubtotal.Text         = value.ToString("F2"); } }
                                                    
        public ItensPedidoEnt Item                    { get; set; }

        public event EventHandler<ItemCarrinhoEventArgs> ItemClicado;

        public event EventHandler<ItemCarrinhoEventArgs> ItemSelecionado;

        public ItemCarrinho()
        {
            InitializeComponent();
        }

        private void btnIMGFechar_Click(object sender, EventArgs e)
        {
            ItemClicado?.Invoke(this, new ItemCarrinhoEventArgs(Item, null));
        }

        private void cbxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_config)
            {
                EnumQuantidade Quantidade   = ((EnumQuantidade)cbxQuantidade.SelectedItem);
                Item.Quantidade             = Quantidade.numInt;
                cbxQuantidade.SelectedIndex = Quantidade.numInt - 1;
                ItemSelecionado?.Invoke(this, new ItemCarrinhoEventArgs(Item, null));
            }
            else
            {
                cbxQuantidade.SelectedIndex = Item.Quantidade - 1;
                _config = false;
            }
            
        }

        private void ItemCarrinho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
