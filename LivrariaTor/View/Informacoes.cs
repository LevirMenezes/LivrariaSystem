using System;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class Informacoes : Form
    {
        #region Variaveis

        #endregion

        #region Inicialização

        public Informacoes()
        {
            InitializeComponent();
        }

        private void Informacoes_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Buttons e cliques

        private void picboxVoltarFormPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal form_principal = new FormPrincipal();
            form_principal.Show();
            this.Close();
        }

        #endregion

        #region ItemClique

        #endregion
    }
}
