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

        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {

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
    }
}
