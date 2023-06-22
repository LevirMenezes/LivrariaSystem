using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class Carrinho : Form
    {
        private PedidoController      PedidoController      = new PedidoController();
        private ItensPedidoController ItensPedidoController = new ItensPedidoController();
        private List<ItensPedidoEnt>  Itens                 = null;
        private PedidoEnt             Pedido                = null;

        public Carrinho()
        {
            InitializeComponent();
            Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);

            if (Pedido == null)
            {
                PedidoController.InserirPedido(VariaveisGlobais.UsuarioLogado.Id);
            }

            Itens = ItensPedidoController.PegaTodosItensPorUsuario(VariaveisGlobais.UsuarioLogado.Id);

            if (Itens == null)
            {
                MessageBox.Show("O carrinho está vazio!", "Carrinho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void Carrinho_Load(object sender, System.EventArgs e)
        {

        }

        private void PopularLista()
        {
            List<ItemCarrinho> ItensPedido = new List<ItemCarrinho>();

            foreach(ItensPedidoEnt item in Itens)
            {
                ItemCarrinho ItemCarrinho     = new ItemCarrinho();
                ItemCarrinho.Title            = item.Livro.Titulo;
                ItemCarrinho.Imagem           = item.Livro.ByteToIMG();
                ItemCarrinho.Subtotal         = item.SubTotal;
                List<EnumQuantidade> listaNum = new List<EnumQuantidade>();
                for(decimal i = 1; i <= item.Livro.Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numDecimal     = i;
                    enume.numString      = i.ToString();
                    listaNum.Add(enume);
                }

                ItemCarrinho.Listaquantidade = listaNum;
                ItemCarrinho.Livro           = item.Livro;
            }
        }
    }

    public class EnumQuantidade
    {
        public decimal numDecimal { get; set; }
        public string numString { get; set; }

        public EnumQuantidade()
        {
            numDecimal = 0m;
            numString  = "0";
        }

    }
}
