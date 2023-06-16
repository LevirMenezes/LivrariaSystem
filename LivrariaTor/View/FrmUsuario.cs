using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LivrariaTor
{
    public partial class FrmUsuario : Form
    {
        private string CaminhoDaImagem              = string.Empty;
        private UsuarioController UsuarioController = new UsuarioController();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            UsuarioEnt usuario   = new UsuarioEnt();
            usuario.Nome         = tbxNome.Text;
            usuario.Telefone     = mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
            usuario.Cpf          = mtbxCpf.Text.Replace("-", "").Replace(".", "").Trim();
            usuario.Email        = tbxEmail.Text;
            usuario.Senha        = mtbxSenha.Text;

            EnderecoEnt endereco = new EnderecoEnt();
            endereco.Cep         = tbxCEP.Text;
            endereco.Numero      = tbxNumero.Text;
            endereco.Bairro      = tbxBairro.Text;
            endereco.Cidade      = tbxCidade.Text;
            endereco.Estado      = tbxEstado.Text;

            string resposta = UsuarioController.InserirUsuario(usuario);

            MessageBox.Show(resposta, "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelecionarIMG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title  = "Selecione uma foto";
                openFileDialog.Filter = "Arquivos de Imagem (*.jpg; *.jpeg; *.png; *.gif) | *.jpg; *.jpeg; *.png; *.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CaminhoDaImagem     = openFileDialog.FileName;
                    picboxImgUser.Image = Image.FromFile(CaminhoDaImagem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Selecionar a Imagem! Por Favor selecionar um formato de imagem válido." + ex.Message, "Falha ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
