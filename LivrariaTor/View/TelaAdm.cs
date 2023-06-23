using LivrariaTor.Utils;
using System;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }

        private void btnRelatorioCliente_Click(object sender, EventArgs e)
        {
            Listadeusuarios form_listausuarios = new Listadeusuarios();
            form_listausuarios.Show();
            this.Close();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            FrmRelatorioVenda Form_relatoriodevendas = new FrmRelatorioVenda();
            Form_relatoriodevendas.Show();
            this.Close();
        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {
            Relatoriodeestoque form_relatoriodeestoque = new Relatoriodeestoque();
            form_relatoriodeestoque.Show();
            this.Close();
        }

        private void btnTelaPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal form_principal = new FormPrincipal();
            form_principal.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Telalogin form_login = new Telalogin();
            form_login.Show();
            this.Close();
            VariaveisGlobais.UsuarioLogado = null;
        }

        private void btnLivrosCadastrados_Click(object sender, EventArgs e)
        {
            Catalogodelivros form_catalogodelivros = new Catalogodelivros();
            form_catalogodelivros.Show();
            this.Close();
            
        }
    }
}
