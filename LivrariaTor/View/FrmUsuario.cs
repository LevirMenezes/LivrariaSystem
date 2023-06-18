using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using LivrariaTor.View;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LivrariaTor
{
    public partial class FrmUsuario : Form
    {
        private string CaminhoDaImagem                = string.Empty;
        private UsuarioController  UsuarioController  = new UsuarioController();
        private EnderecoController EnderecoController = new EnderecoController();
        private UsuarioEnt         Usuario            = null;

        public FrmUsuario(UsuarioEnt usuario = null)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CaminhoDaImagem))
                    throw new Exception("O Campo Imagem não pode ser vazio! Por favor selecione uma imagem.");

                if (string.IsNullOrEmpty(tbxNome.Text.Trim()))
                    throw new Exception("Por favor, Preecha o campo Nome.");

                if (string.IsNullOrEmpty(mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim()))
                    throw new Exception("Por favor, Preencha o campo telefone do usuario.");

                if (string.IsNullOrEmpty(mtbxCpf.Text.Replace("-", "").Replace(".", "").Trim()))
                    throw new Exception("Por favor, Preencha o campo cpf de usuario.");

                if (string.IsNullOrEmpty(tbxEmail.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo email do usuario.");

                if (string.IsNullOrEmpty(mtbxSenha.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo senha do usuario.");

                if (string.IsNullOrEmpty(mtbxConfirmarSenha.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo confirmação de senha do usuario.");

                if (mtbxConfirmarSenha.Text.Trim() != mtbxSenha.Text.Trim())
                    throw new Exception("As senhas digitas são diferentes, por favor digite senhas iguais.");

                if (string.IsNullOrEmpty(tbxCEP.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo CEP do usuario.");

                if (string.IsNullOrEmpty(tbxNumero.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo Numero do usuario.");

                if (string.IsNullOrEmpty(tbxBairro.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo Bairro do usuario.");

                if (string.IsNullOrEmpty(tbxCidade.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo Cidade do usuario.");

                if (string.IsNullOrEmpty(tbxEstado.Text.Trim()))
                    throw new Exception("Por favor, Preencha o campo Estado do usuario.");



                byte[] imagemBytes   = File.ReadAllBytes(CaminhoDaImagem);
                UsuarioEnt usuario   = new UsuarioEnt();
                usuario.Nome         = tbxNome.Text.Trim();
                usuario.Telefone     = mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
                usuario.Cpf          = mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim();
                usuario.Email        = tbxEmail.Text.Trim();
                usuario.Senha        = mtbxSenha.Text.Trim();
                usuario.Imagem       = imagemBytes;

                EnderecoEnt endereco = new EnderecoEnt();
                endereco.Cep         = tbxCEP.Text.Trim();
                endereco.Numero      = tbxNumero.Text.Trim();
                endereco.Rua         = tbxRua.Text.Trim();
                endereco.Bairro      = tbxBairro.Text.Trim();
                endereco.Cidade      = tbxCidade.Text.Trim();
                endereco.Estado      = tbxEstado.Text.Trim();

                string resposta = UsuarioController.InserirUsuario(usuario);
                string respEnd  = string.Empty;
                if (resposta == "OK")
                {
                    int idusuario = (UsuarioController.PegaId()).Id;
                    endereco.IdUsuario = idusuario;
                    respEnd = EnderecoController.InserirEndereco(endereco);
                    if (respEnd == "OK")
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (VariaveisGlobais.UsuarioLogado == null)
                        {
                            Telalogin form_login = new Telalogin();
                            form_login.Show();
                            this.Close();
                        }
                        else
                        {
                            Listadeusuarios form_listausuarios = new Listadeusuarios();
                            form_listausuarios.Show();
                            this.Close();
                        }
                        
                    }
                    else
                        throw new Exception(respEnd);
                }
                else
                    throw new Exception(resposta);
                    

            }catch(Exception ex)
            {
                MessageBox.Show("O cadastro falhou: " + ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }
    }
}
