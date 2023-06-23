using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class FormasPagamento : Form
    {
        #region Variaveis

        private PedidoController pedidoController          = new PedidoController();
        private PedidoEnt        Pedido                    = null;
        private int              CbxControleFormaPagamento = 0;

        #endregion

        #region Inicialização

        public FormasPagamento()
        {
            InitializeComponent();
        }

        private void FormasPagamento_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        #endregion

        #region Metodos

        private void CarregarInformacoes()
        {
            Pedido = pedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            if (Pedido == null)
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
                lblTotal.Text            = Pedido.PrecoTotal.ToString("F2");
            }
        }

        #endregion

        #region Buttons e Cliques

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                string end = string.Empty;
                if (CbxControleFormaPagamento == 0)
                    throw new Exception("É obrigatório escolher uma forma de pagamento!");

                if (string.IsNullOrEmpty(mtbxNunCartao.Text.Replace(" ", "").Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Número do Cartão do Titular!");

                if (string.IsNullOrEmpty(tbxNomeTitular.Text.Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Nome do Titular!");

                if (string.IsNullOrEmpty(mtbxCpfTitular.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Cpf do Titular!");
                else
                    end = mtbxCpfTitular.Text.Replace(",", "").Replace(".", "").Replace("-", "").Trim();

                if (string.IsNullOrEmpty(mtbxTelefoneTitular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-","").Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Telefone do Titular!");

                if (string.IsNullOrEmpty(mtbxValidadeCartao.Text.Replace("/", "").Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Validada do Cartão do Titular!");

                if (string.IsNullOrEmpty(tbxCodSeguranca.Text.Trim()))
                    throw new Exception("É obrigatório o preenchimento do campo Cod de Segurança do Cartão do Titular!");

                if (end.Length != 11)
                    throw new Exception("O cpf precisa ter 11 números!");

                if (mtbxTelefoneTitular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Trim().Length != 11)
                    throw new Exception("O telefone precisa ter 11 números!");

                if (mtbxNunCartao.Text.Replace(" ", "").Trim().Length != 16)
                    throw new Exception("O numero do cartão precisa ter 16 numeros!");

                if (mtbxValidadeCartao.Text.Replace("/", "").Trim().Length != 6)
                    throw new Exception("por favor insira uma data nesse modelo ex.: 04/2024!");

                Pedido.IdFormaPagamento = CbxControleFormaPagamento;
                string respPedido = pedidoController.AtualizarPedido(Pedido);
                if(respPedido == "OK")
                {
                    DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else 
                {
                    throw new Exception("Erro ao finalizar o pedido, por favor verique os dados e tente novamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("mensagem: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region ItemClique

        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            CbxControleFormaPagamento = 1;
        }

        private void rbtnDebito_CheckedChanged(object sender, EventArgs e)
        {
            CbxControleFormaPagamento = 2;
        }

        #endregion
    }
}
