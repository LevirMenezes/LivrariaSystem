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
        private EnderecoEnt        Endereco           = null;
        public  string             TextoBotao         = string.Empty;

        public FrmUsuario(UsuarioEnt usuario = null)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        #region Cliques

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            if (TextoBotao == "Cadastrar")
                Cadastrar();
            else if (TextoBotao == "Editar")
                Editar();
            else
                Deletar();
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
            if (VariaveisGlobais.UsuarioLogado == null)
            {
                Telalogin form_login = new Telalogin();
                form_login.Show();
                this.Close();
            }
            else
            {
                if (VariaveisGlobais.UsuarioLogado.Adm == 0)
                {
                    FormPrincipal form_principal = new FormPrincipal();
                    form_principal.Show();
                    this.Close();
                }
                else
                {
                    Listadeusuarios form_listausuarios = new Listadeusuarios();
                    form_listausuarios.Show();
                    this.Close();
                }
            }
        }

        #endregion

        #region Metodos

        private void Cadastrar()
        {
            try
            {
                #region Verificação do campo vazio

                if (string.IsNullOrEmpty(CaminhoDaImagem))
                {
                    btnSelecionarIMG.Focus();
                    throw new Exception("O Campo Imagem não pode ser vazio! Por favor selecione uma imagem.");
                }

                if (string.IsNullOrEmpty(tbxNome.Text.Trim()))
                {
                    tbxNome.Focus();
                    tbxNome.BackColor = Color.Red;
                    throw new Exception("Por favor, Preecha o campo Nome.");
                }

                if (string.IsNullOrEmpty(mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim()))
                {
                    mtbxTelefone.Focus();
                    throw new Exception("Por favor, Preencha o campo telefone do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxCpf.Text.Replace("-", "").Replace(".", "").Trim()))
                {
                    mtbxCpf.Focus();
                    throw new Exception("Por favor, Preencha o campo cpf de usuario.");
                }

                if (string.IsNullOrEmpty(tbxEmail.Text.Trim()))
                {
                    tbxEmail.Focus();
                    throw new Exception("Por favor, Preencha o campo email do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxSenha.Text.Trim()))
                {
                    mtbxSenha.Focus();
                    throw new Exception("Por favor, Preencha o campo senha do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxConfirmarSenha.Text.Trim()))
                {
                    mtbxConfirmarSenha.Focus();
                    throw new Exception("Por favor, Preencha o campo confirmação de senha do usuario.");
                }

                if (mtbxConfirmarSenha.Text.Trim() != mtbxSenha.Text.Trim())
                {
                    mtbxSenha.Focus();
                    throw new Exception("As senhas digitas são diferentes, por favor digite senhas iguais.");
                }

                if (string.IsNullOrEmpty(tbxCEP.Text.Trim()))
                {
                    tbxCEP.Focus();
                    throw new Exception("Por favor, Preencha o campo CEP do usuario.");
                }

                if (string.IsNullOrEmpty(tbxNumero.Text.Trim()))
                {
                    tbxNumero.Focus();
                    throw new Exception("Por favor, Preencha o campo Numero do usuario.");
                }

                if (string.IsNullOrEmpty(tbxBairro.Text.Trim()))
                {
                    tbxBairro.Focus();
                    throw new Exception("Por favor, Preencha o campo Bairro do usuario.");
                }

                if (string.IsNullOrEmpty(tbxCidade.Text.Trim()))
                {
                    tbxCidade.Focus();
                    throw new Exception("Por favor, Preencha o campo Cidade do usuario.");
                }

                if (string.IsNullOrEmpty(tbxEstado.Text.Trim()))
                {
                    tbxEstado.Focus();
                    throw new Exception("Por favor, Preencha o campo Estado do usuario.");
                }

                #endregion

                #region Validações de negocio

                if (UsuarioController.PegaCPF(mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim()) != null)
                    throw new Exception("Esse cpf já pertence a outro usuário!");

                if (UsuarioController.PegaEmail(tbxEmail.Text.Trim()) != null)
                    throw new Exception("Esse email já pertence a outro usuário!");

                if (tbxEstado.TextLength != 2)
                    throw new Exception("Por Favor, Preencha o campo estado apenas com a Sigla do estado! Ex.: RO -> RONDÔNIA.");

                #endregion

                byte[] imagemBytes = File.ReadAllBytes(CaminhoDaImagem);
                UsuarioEnt usuario = new UsuarioEnt();
                usuario.Nome = tbxNome.Text.Trim();
                usuario.Telefone = mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
                usuario.Cpf = mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim();
                usuario.Email = tbxEmail.Text.Trim();
                usuario.Senha = mtbxSenha.Text.Trim();
                usuario.Imagem = imagemBytes;

                EnderecoEnt endereco = new EnderecoEnt();
                endereco.Cep = tbxCEP.Text.Trim();
                endereco.Numero = tbxNumero.Text.Trim();
                endereco.Rua = tbxRua.Text.Trim();
                endereco.Bairro = tbxBairro.Text.Trim();
                endereco.Cidade = tbxCidade.Text.Trim();
                endereco.Estado = tbxEstado.Text.Trim();

                string resposta = UsuarioController.InserirUsuario(usuario);
                string respEnd = string.Empty;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("O cadastro falhou: " + ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                #region Verificação do campo vazio

                if (string.IsNullOrEmpty(CaminhoDaImagem) && Usuario.Imagem == null)
                {
                    btnSelecionarIMG.Focus();
                    throw new Exception("O Campo Imagem não pode ser vazio! Por favor selecione uma imagem.");
                }

                if (string.IsNullOrEmpty(tbxNome.Text.Trim()))
                {
                    tbxNome.Focus();
                    tbxNome.BackColor = Color.Red;
                    throw new Exception("Por favor, Preecha o campo Nome.");
                }

                if (string.IsNullOrEmpty(mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim()))
                {
                    mtbxTelefone.Focus();
                    throw new Exception("Por favor, Preencha o campo telefone do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxCpf.Text.Replace("-", "").Replace(".", "").Trim()))
                {
                    mtbxCpf.Focus();
                    throw new Exception("Por favor, Preencha o campo cpf de usuario.");
                }

                if (string.IsNullOrEmpty(tbxEmail.Text.Trim()))
                {
                    tbxEmail.Focus();
                    throw new Exception("Por favor, Preencha o campo email do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxSenha.Text.Trim()))
                {
                    mtbxSenha.Focus();
                    throw new Exception("Por favor, Preencha o campo senha do usuario.");
                }

                if (string.IsNullOrEmpty(mtbxConfirmarSenha.Text.Trim()))
                {
                    mtbxConfirmarSenha.Focus();
                    throw new Exception("Por favor, Preencha o campo confirmação de senha do usuario.");
                }

                if (mtbxConfirmarSenha.Text.Trim() != mtbxSenha.Text.Trim())
                {
                    mtbxSenha.Focus();
                    throw new Exception("As senhas digitas são diferentes, por favor digite senhas iguais.");
                }

                if (string.IsNullOrEmpty(tbxCEP.Text.Trim()))
                {
                    tbxCEP.Focus();
                    throw new Exception("Por favor, Preencha o campo CEP do usuario.");
                }

                if (string.IsNullOrEmpty(tbxNumero.Text.Trim()))
                {
                    tbxNumero.Focus();
                    throw new Exception("Por favor, Preencha o campo Numero do usuario.");
                }

                if (string.IsNullOrEmpty(tbxBairro.Text.Trim()))
                {
                    tbxBairro.Focus();
                    throw new Exception("Por favor, Preencha o campo Bairro do usuario.");
                }

                if (string.IsNullOrEmpty(tbxCidade.Text.Trim()))
                {
                    tbxCidade.Focus();
                    throw new Exception("Por favor, Preencha o campo Cidade do usuario.");
                }

                if (string.IsNullOrEmpty(tbxEstado.Text.Trim()))
                {
                    tbxEstado.Focus();
                    throw new Exception("Por favor, Preencha o campo Estado do usuario.");
                }

                #endregion

                #region Validações de negocio

                if (mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim() != Usuario.Cpf && UsuarioController.PegaCPF(mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim()) != null)
                    throw new Exception("Esse cpf já pertence a outro usuário!");

                if (tbxEmail.Text.Trim() != Usuario.Email && UsuarioController.PegaEmail(tbxEmail.Text.Trim()) != null)
                    throw new Exception("Esse email já pertence a outro usuário!");

                if(tbxEstado.TextLength != 2)
                    throw new Exception("Por Favor, Preencha o campo estado apenas com a Sigla do estado! Ex.: RO -> RONDÔNIA.");

                #endregion

                byte[] imagemBytes = string.IsNullOrEmpty(CaminhoDaImagem) ? Usuario.Imagem : File.ReadAllBytes(CaminhoDaImagem);
                UsuarioEnt usuario = new UsuarioEnt();
                usuario.Id         = Usuario.Id;
                usuario.Nome       = tbxNome.Text.Trim();
                usuario.Telefone   = mtbxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
                usuario.Cpf        = mtbxCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "").Trim();
                usuario.Email      = tbxEmail.Text.Trim();
                usuario.Senha      = mtbxSenha.Text.Trim();
                usuario.Imagem     = imagemBytes;

                EnderecoEnt endereco = new EnderecoEnt();
                endereco.Id          = Endereco.Id;
                endereco.Cep         = tbxCEP.Text.Trim();
                endereco.Numero      = tbxNumero.Text.Trim();
                endereco.Rua         = tbxRua.Text.Trim();
                endereco.Bairro      = tbxBairro.Text.Trim();
                endereco.Cidade      = tbxCidade.Text.Trim();
                endereco.Estado      = tbxEstado.Text.Trim();
                endereco.IdUsuario   = Usuario.Id;

                string resposta = UsuarioController.AtualizarUsuario(usuario);
                if (resposta == "OK")
                {
                    string respEnd = EnderecoController.AtualizarEndereco(endereco);
                    if (respEnd == "OK")
                        MessageBox.Show("Perfil Atualizado com Sucesso!");
                    else
                        MessageBox.Show("Falha ao tentar atualizar o perfil do usuario!");
                }
                else
                    MessageBox.Show("Falha ao tentar atualizar o perfil do usuario!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar o perfil: " + ex.Message, "Falha ao Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletar()
        {

        }

        private string FormataCPF(string cpf)
        {
            return cpf.Substring(0, 3) + "." +
                   cpf.Substring(3, 3) + "." +
                   cpf.Substring(6, 3) + "-" +
                   cpf.Substring(9);
        }

        private string FormataTelefone(string tel)
        {
            return "(" + tel.Substring(0, 2) + ")" +
                   " " + tel.Substring(2, 1) + " " +
                   tel.Substring(3, 4) + "-" +
                   tel.Substring(7);
        }

        private void CarregarInformacoes()
        {
            Endereco                = EnderecoController.PegaEnderecoPorIdUsuario(Usuario.Id);
            picboxImgUser.Image     = Usuario.ByteToIMG();
            tbxNome.Text            = Usuario.Nome;
            mtbxTelefone.Text       = FormataTelefone(Usuario.Telefone);
            mtbxCpf.Text            = FormataCPF(Usuario.Cpf);
            tbxEmail.Text           = Usuario.Email;
            mtbxSenha.Text          = Usuario.Senha;
            mtbxConfirmarSenha.Text = Usuario.Senha;    

            tbxCEP.Text             = Endereco.Cep;
            tbxRua.Text             = Endereco.Rua;
            tbxNumero.Text          = Endereco.Numero;
            tbxBairro.Text          = Endereco.Bairro;
            tbxCidade.Text          = Endereco.Cidade;
            tbxEstado.Text          = Endereco.Estado;
        }

        #endregion
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            btnCadastroUsuario.Text = TextoBotao;

            if(TextoBotao != "Cadastrar")
            {
                CarregarInformacoes();

                if(TextoBotao == "Deletar")
                {
                    picboxImgUser.Enabled      = false;
                    tbxNome.Enabled            = false;
                    mtbxTelefone.Enabled       = false;
                    mtbxCpf.Enabled            = false;
                    tbxEmail.Enabled           = false;
                    mtbxSenha.Enabled          = false;
                    mtbxConfirmarSenha.Enabled = false;

                    tbxCEP.Enabled             = false;
                    tbxRua.Enabled             = false;
                    tbxNumero.Enabled          = false;
                    tbxBairro.Enabled          = false;
                    tbxCidade.Enabled          = false;
                    tbxEstado.Enabled          = false;
                }
            }
            
        }
    }
}
