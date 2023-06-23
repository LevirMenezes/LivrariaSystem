using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System.Collections.Generic;
using System.Drawing;
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
        }

        private void Carrinho_Load(object sender, System.EventArgs e)
        {
            RecarregarTela();
        }

        private void PopularLista()
        {
            List<ItemCarrinho> ItensPedido = new List<ItemCarrinho>();

            // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
            if (flowLayoutCarrinho.Controls.Count > 0)
            {
                flowLayoutCarrinho.Controls.Clear();
            }

            foreach (ItensPedidoEnt item in Itens)
            {
                ItemCarrinho ItemCarrinho     = new ItemCarrinho();
                ItemCarrinho.Title            = item.Livro.Titulo;
                ItemCarrinho.Imagem           = item.Livro.ByteToIMG();
                ItemCarrinho.Subtotal         = item.SubTotal;
                List<EnumQuantidade> listaNum = new List<EnumQuantidade>();
                for(int i = 1; i <= item.Livro.Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt         = i;
                    enume.numString      = i.ToString();
                    listaNum.Add(enume);
                }

                ItemCarrinho.Item             = item;
                ItemCarrinho.Listaquantidade  = listaNum;
                ItemCarrinho.ItemClicado     += ItemClicadoHandler;
                ItemCarrinho.ItemSelecionado += ItemSelecionadoHandler;

                ItensPedido.Add(ItemCarrinho);

                flowLayoutCarrinho.Controls.Add(ItemCarrinho);
            }
        }


        // Método responsável pelo clique no botão X de cada item do carrinho
        private void ItemClicadoHandler(object sender, ItemCarrinhoEventArgs e)
        {
            // Chama o metodo do controller para apagar o item da listagem e do banco
            string respItem = ItensPedidoController.DeletarItem(e.Item.Id);

            if (respItem == "OK")
            {
                MessageBox.Show("Livro Removido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecarregarTela();
            }
            else
                MessageBox.Show("Falha ao deletar item do carrinho!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Método responsável por atualizar a quantidade do banco para que fique de acordo com a quantidade selecionada no combobox do item do carrinho
        private void ItemSelecionadoHandler(object sender, ItemCarrinhoEventArgs e)
        {
            string respItem = ItensPedidoController.AtualizarQuantidadeItem(e.Item);
            if (respItem == "OK")
                RecarregarTela();
            else
                MessageBox.Show("Falha ao atualizar a quantidade do item do carrinho!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFecharPagina_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFinalizarComprar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RecarregarTela()
        {
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
                return;
            }
            if (Pedido != null)
            {
                lblSubtotal.Text = Pedido.PrecoTotal.ToString("F2");
            }
            PopularLista();
        }
    }

    public class EnumQuantidade
    {
        public int numInt { get; set; }
        public string numString { get; set; }

        public EnumQuantidade()
        {
            numInt     = 0;
            numString  = "0";
        }

    }
}
