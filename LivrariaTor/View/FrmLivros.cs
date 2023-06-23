using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using LivrariaTor.Persistencia;
using LivrariaTor.Controller;
using LivrariaTor.View;

namespace LivrariaTor
{
    public partial class FrmLivros : Form
    {
        #region Variaveis

        public  string TextoBotao      = string.Empty;
        private string CaminhoDaImagem = string.Empty;
        private LivroController   livroController    = new LivroController();
        private AutorController   autorController    = new AutorController();
        private EditoraController editoraController  = new EditoraController();
        private GeneroController  generoController   = new GeneroController();
        private int               CbxControleAutor;
        private int               CbxControleGenero;
        private int               CbxControleEditora;
        private LivroEnt          Livro = null;

        #endregion

        #region Inicialização

        public FrmLivros(LivroEnt livro = null)
        {
            InitializeComponent();

            Livro = livro;
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            PopularCbxAutor();
            PopularCbxEditora();
            PopularCbxGenero();
            btnCadastrar.Text = TextoBotao;

            if (Livro != null)
            {
                CarregarInformacoes();
                if (TextoBotao == "Deletar")
                {
                    txtTitulo.Enabled = false;
                    mTxtPreco.Enabled = false;
                    txtQtdEstoque.Enabled = false;
                    txtDescricaoLivro.Enabled = false;
                    txtIsbn.Enabled = false;
                    dtpAnoPublicacao.Enabled = false;
                    picboxSelecionarImagem.Enabled = false;
                    btnSelecionarImagem.Enabled = false;
                }
            }
        }

        #endregion

        #region Metodos

        private void CarregarInformacoes()
        {
            txtTitulo.Text               = Livro.Titulo;
            mTxtPreco.Text               = Livro.Preco.ToString().PadLeft(7, '0');
            txtQtdEstoque.Text           = Livro.Estoque.ToString();
            txtDescricaoLivro.Text       = Livro.Descricao;
            txtIsbn.Text                 = Livro.Isbn;
            dtpAnoPublicacao.Value       = Convert.ToDateTime(Livro.AnoPublicacao);
            if (Livro.Imagem != null)
            {
                using (MemoryStream stream = new MemoryStream(Livro.Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxSelecionarImagem.Image = imagem;
                }
            }
        }

        private void PopularCbxAutor()
        {
            List<AutorEnt> listaAutores = (autorController.PegaTodosAutores() == null ? new List<AutorEnt>() : autorController.PegaTodosAutores());
            AutorEnt autor = new AutorEnt();
            autor.Id = 999999999;
            autor.Nome = "Novo Autor";
            listaAutores.Add(autor);

            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxAutor.DataSource = listaAutores;

            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxAutor.DisplayMember = "Nome";

            if (Livro == null)
                CbxControleAutor = listaAutores[0].Id;
            else
            {
                int autorLivroid = (autorController.PegaAutorPorLivroId(Livro.Id)).Id;
                int indexSelecionado = 0;
                foreach(AutorEnt aut in listaAutores)
                {
                    if(aut.Id == autorLivroid)
                    {
                        CbxControleAutor = aut.Id;
                        cbxAutor.SelectedIndex = indexSelecionado;
                        cbxAutor.Enabled = false;
                    }
                    indexSelecionado++;
                }
            }
        }

        private void PopularCbxEditora()
        {
            List<EditoraEnt> listaEditoras = (editoraController.PegaTodosEditoras() == null ? new List<EditoraEnt>() : editoraController.PegaTodosEditoras());
            EditoraEnt editora = new EditoraEnt();
            editora.Id = 999999999;
            editora.Nome = "Nova Editora";
            listaEditoras.Add(editora);

            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxEditora.DisplayMember = "Nome";

            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxEditora.DataSource = listaEditoras;

            if (Livro == null)
                CbxControleEditora = listaEditoras[0].Id;
            else
            {
                int editoraLivroid = (editoraController.PegaEditoraPorId(Livro.IdEditora)).Id;
                int indexSelecionado = 0;
                foreach (EditoraEnt edit in listaEditoras)
                {
                    if (edit.Id == editoraLivroid)
                    {
                        CbxControleEditora = edit.Id;
                        cbxEditora.SelectedIndex = indexSelecionado;
                        cbxEditora.Enabled = false;
                    }
                    indexSelecionado++;
                }
            }
            
        }

        private void PopularCbxGenero()
        {
            List<GeneroEnt> listaGeneros = (generoController.PegaTodosGeneros() == null ? new List<GeneroEnt>() : generoController.PegaTodosGeneros());
            AutorEnt genero = new AutorEnt();
            
            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxGenero.DisplayMember = "Genero";

            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxGenero.DataSource = listaGeneros;

            if (Livro == null)
                CbxControleGenero = listaGeneros[0].Id;
            else
            {
                int generoLivroid = (generoController.PegaGeneroPorLivroId(Livro.Id)).Id;
                int indexSelecionado = 0;
                foreach (GeneroEnt gen in listaGeneros)
                {
                    if (gen.Id == generoLivroid)
                    {
                        CbxControleGenero = gen.Id;
                        cbxGenero.SelectedIndex = indexSelecionado;
                        cbxGenero.Enabled = false;
                        break;
                    }
                    indexSelecionado++;
                }
            }
        }

        private void LimparCampos()
        {
            PopularCbxAutor();
            PopularCbxEditora();
            PopularCbxGenero();
            txtTitulo.Text               = string.Empty;
            mTxtPreco.Text               = string.Empty;
            txtQtdEstoque.Text           = string.Empty;
            txtDescricaoLivro.Text       = string.Empty;  
            txtIsbn.Text                 = string.Empty;    
            dtpAnoPublicacao.Value       = DateTime.Now;
            txtNomeAutor.Text            = string.Empty;
            txtNomeEditora.Text          = string.Empty;
            txtTelefoneEditora.Text      = string.Empty;
            picboxSelecionarImagem.Image = null;
        }

        private void Cadastrar()
        {
            try
            {
                if (string.IsNullOrEmpty(CaminhoDaImagem))
                    throw new Exception("O Campo Imagem não pode ser vazio! Por favor selecione uma imagem.");

                if (CbxControleAutor == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Autor.");
                    
                if (CbxControleEditora == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Editora.");

                if (CbxControleGenero == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Genero.");

                if (string.IsNullOrEmpty(txtTitulo.Text))
                    throw new Exception("Por favor, Preecha o campo titulo.");

                if (string.IsNullOrEmpty(txtDescricaoLivro.Text))
                    throw new Exception("Por favor, Preencha o campo descricao do livro.");

                if (string.IsNullOrEmpty(txtQtdEstoque.Text))
                    throw new Exception("Por favor, Preencha o campo quantidade de estoque.");

                if (string.IsNullOrEmpty(mTxtPreco.Text.Replace("R$", "").Replace(".", "")))
                    throw new Exception("Por favor, Preencha o campo preço do livro.");

                if (string.IsNullOrEmpty(txtIsbn.Text))
                    throw new Exception("Por favor, Preencha o campo Isbn do livro.");

                string respAutor    = string.Empty;
                string respEditora  = string.Empty;
                string respLivro    = string.Empty;

                int    generoid     = CbxControleGenero;
                int    autorid      = 0;

                byte[] imagemBytes  = File.ReadAllBytes(CaminhoDaImagem);
                LivroEnt livro      = new LivroEnt();
                livro.Titulo        = txtTitulo.Text;
                livro.Preco         = Convert.ToDecimal(mTxtPreco.Text.Replace("R$", "").Replace("0",""));
                livro.Descricao     = txtDescricaoLivro.Text;
                livro.Estoque       = Convert.ToInt32(txtQtdEstoque.Text);
                livro.AnoPublicacao = (dtpAnoPublicacao.Value).ToString();
                livro.Isbn          = txtIsbn.Text;
                livro.Imagem        = imagemBytes;
                if (CbxControleEditora != 999999999)
                {
                    livro.IdEditora = CbxControleEditora;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNomeEditora.Text))
                        throw new Exception("Por favor, Preencha o campo Isbn do livro.");

                    if (string.IsNullOrEmpty(txtTelefoneEditora.Text))
                        throw new Exception("Por favor, Preencha o campo Isbn do livro.");

                    EditoraEnt editora = new EditoraEnt();
                    editora.Telefone = txtTelefoneEditora.Text;
                    editora.Nome     = txtNomeEditora.Text;

                    respEditora =  editoraController.InserirEditora(editora);

                    if (respEditora == "OK")
                    {
                        editora.Id = (editoraController.PegarId()).Id;

                        livro.IdEditora = editora.Id;
                    }
                    else
                    {
                        throw new Exception(respEditora);
                    }
                }

                if (CbxControleAutor == 999999999)
                {
                    if (string.IsNullOrEmpty(txtNomeAutor.Text))
                        throw new Exception("Por favor, Preencha o campo nome do novo autor.");

                    AutorEnt autor = new AutorEnt();
                    autor.Nome     = txtNomeAutor.Text;

                    respAutor      = autorController.InserirAutor(autor);

                    if (respAutor == "OK")
                    {
                        autorid = (autorController.PegarId()).Id;
                    }
                }
                else
                {
                    autorid = CbxControleAutor;
                }

                
                if (autorid != 0 && generoid != 0 && livro.IdEditora != 0) 
                { 
                    respLivro = livroController.InserirLivro(livro, autorid, generoid);
                    if (respLivro == "OK")
                    {
                        MessageBox.Show("O cadastro foi efetuado com sucesso!", "Situação Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Catalogodelivros form_catalogo = new Catalogodelivros();
                        form_catalogo.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(respLivro);
                    }
                }
                else
                {
                    throw new Exception("Por favor, verifique os dados do cadastro, pois há algo de errado!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Livro" + ex.Message, "Resposta Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                if (Livro.Imagem == null && string.IsNullOrEmpty(CaminhoDaImagem))
                    throw new Exception("O Campo Imagem não pode ser vazio! Por favor selecione uma imagem.");

                if (CbxControleAutor == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Autor.");

                if (CbxControleEditora == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Editora.");

                if (CbxControleGenero == 0)
                    throw new Exception("Por favor, selecione uma opçao na listagem de Genero.");

                if (string.IsNullOrEmpty(txtTitulo.Text))
                    throw new Exception("Por favor, Preecha o campo titulo.");

                if (string.IsNullOrEmpty(txtDescricaoLivro.Text))
                    throw new Exception("Por favor, Preencha o campo descricao do livro.");

                if (string.IsNullOrEmpty(txtQtdEstoque.Text))
                    throw new Exception("Por favor, Preencha o campo quantidade de estoque.");

                if (string.IsNullOrEmpty(mTxtPreco.Text.Replace("R$", "").Replace(".", "")))
                    throw new Exception("Por favor, Preencha o campo preço do livro.");

                if (string.IsNullOrEmpty(txtIsbn.Text))
                    throw new Exception("Por favor, Preencha o campo Isbn do livro.");


                byte[] imagemBytes  = File.ReadAllBytes(CaminhoDaImagem);
                LivroEnt livro      = new LivroEnt();
                livro.Id            = Livro.Id;
                livro.Titulo        = txtTitulo.Text;
                livro.Preco         = Convert.ToDecimal(mTxtPreco.Text.Replace("R$", "").Replace("0", ""));
                livro.Descricao     = txtDescricaoLivro.Text;
                livro.Estoque       = Convert.ToInt32(txtQtdEstoque.Text);
                livro.AnoPublicacao = (dtpAnoPublicacao.Value).ToString();
                livro.Isbn          = txtIsbn.Text;
                livro.Imagem        = imagemBytes;
                livro.IdEditora = CbxControleEditora;

                string msg = livroController.AtualizarLivro(livro);

                if (msg == "OK")
                {
                    MessageBox.Show(msg, "Atualização do Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Catalogodelivros form_catalogo = new Catalogodelivros();

                    form_catalogo.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Livro" + ex, "Resposta Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletar()
        {
            try
            {
                string msg = livroController.DeletarLivro(Livro.Id);
                if (msg == "OK")
                {
                    MessageBox.Show($"O Livro: {Livro.Titulo}, foi deletado com Sucesso!", "Livro Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Catalogodelivros form_catalogo = new Catalogodelivros();
                    form_catalogo.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Falha ao Delatar: {Livro.Titulo}!", "Falhar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao deletar o Livro" + ex.Message, "Erro ao Deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Buttons e cliques

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione uma foto";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg; *.jpeg; *.png; *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CaminhoDaImagem = openFileDialog.FileName;
                picboxSelecionarImagem.Image = Image.FromFile(CaminhoDaImagem);

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(Livro != null)
            {
                if(TextoBotao == "Deletar")
                {
                    Deletar();
                }
                else
                {
                    Editar();
                }
            }
            else
            {
                Cadastrar();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Catalogodelivros form_catalogo = new Catalogodelivros();
            form_catalogo.Show();
            this.Close();
        }

        #endregion

        #region Item Clique

        private void cbxAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAutor.SelectedItem != null)
            {
                AutorEnt autor = ((AutorEnt)cbxAutor.SelectedItem);

                if(((AutorEnt)cbxAutor.SelectedItem).Id == 999999999)
                {
                    txtNomeAutor.Enabled = true;
                    CbxControleAutor     = 999999999;
                }
                else
                {
                    txtNomeAutor.Enabled = false;
                    CbxControleAutor     = autor.Id;
                }
            }
        }

        private void cbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAutor.SelectedItem != null)
            {
                GeneroEnt genero = ((GeneroEnt)cbxGenero.SelectedItem);
                CbxControleGenero = genero.Id;
            }
        }

        private void cbxEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxEditora.SelectedItem != null)
            {
                EditoraEnt editora = (EditoraEnt)cbxEditora.SelectedItem;

                if (((EditoraEnt)cbxEditora.SelectedItem).Id == 999999999)
                {
                    txtNomeEditora.Enabled     = true;
                    txtTelefoneEditora.Enabled = true;
                    CbxControleEditora         = editora.Id;
                }
                else
                {
                    txtNomeEditora.Enabled     = false;
                    txtTelefoneEditora.Enabled = false;
                    CbxControleEditora         = editora.Id;
                }
            }
        }

        #endregion

    }
}
