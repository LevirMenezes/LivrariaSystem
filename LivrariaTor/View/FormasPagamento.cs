using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
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
    public partial class FormasPagamento : Form
    {
        private PedidoController pedidoController = new PedidoController();
        private PedidoEnt        pedido           = null;

        public FormasPagamento()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CarregarInformacoes()
        {
            pedido = pedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            if (pedido == null)
            {
                MessageBox.Show("Falha ao buscar o pedido!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                tbxNomeUsuario.Text      = VariaveisGlobais.UsuarioLogado.Nome;
                mtbxCpfUsuario.Text      = VariaveisGlobais.FormataCPF(VariaveisGlobais.UsuarioLogado.Cpf);
                mtbxTelefoneUsuario.Text = VariaveisGlobais.FormataTelefone(VariaveisGlobais.UsuarioLogado.Telefone);
                lblTotal.Text            = pedido.PrecoTotal.ToString("F2");
            }
        }

        #endregion

        #region Eventos

        private void FormasPagamento_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        #endregion
    }
}
