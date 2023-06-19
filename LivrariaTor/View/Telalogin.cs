using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class Telalogin : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public Telalogin()
        {
            InitializeComponent();
        }

        private void Telalogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioEnt usuario = null;
                    
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    txtEmail.Focus();
                    throw new Exception("O campo email não pode ser vazio!");
                }

                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    txtSenha.Focus();
                    throw new Exception("O campo senha não pode ser vazio!");
                }

                usuario = usuarioController.PegaLogin(txtEmail.Text, txtSenha.Text);

                if (usuario != null)
                {
                    VariaveisGlobais.UsuarioLogado = usuario;
                    MessageBox.Show($"Seja bem vindo {usuario.Nome}", "Logado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPrincipal form_principal = new FormPrincipal();
                    form_principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nenhum usuario foi encontrado que conrresponda a esse email e senha no banco de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUsuario form_cadastro = new FrmUsuario();
            form_cadastro.TextoBotao = "Cadastrar";
            form_cadastro.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
