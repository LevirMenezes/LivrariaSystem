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
        private List<ItensPedidoEnt>  Itens  = null;
        private PedidoEnt             Pedido = null;

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

            }
        }
    }
}
