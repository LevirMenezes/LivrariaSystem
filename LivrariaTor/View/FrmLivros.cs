using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //add
using System.Data.SqlClient; //add
using System.IO;
using LivrariaTor.Persistencia;
using LivrariaTor.Controller;
using System.Windows.Interop;

namespace LivrariaTor
{
    public partial class FrmLivros : Form
    {
        #region Variaveis

        private string CaminhoDaImagem = string.Empty;
        private LivroController   livroController    = new LivroController();
        private AutorController   autorController    = new AutorController();
        private EditoraController editoraController  = new EditoraController();
        private GeneroController  generoController   = new GeneroController();
        private int               CbxControleAutor   = 0;
        private int               CbxControleGenero  = 0;
        private int               CbxControleEditora = 0;

        #endregion
        public FrmLivros()
        {
            InitializeComponent();
        }

        #region Metodos

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            PopularCbxAutor();
            PopularCbxEditora();
            PopularCbxGenero();
        }

        private void PopularCbxAutor()
        {
            List<AutorEnt> listaAutores = (autorController.PegaTodosAutores() == null ? new List<AutorEnt>() : autorController.PegaTodosAutores());
            AutorEnt autor = new AutorEnt();
            autor.Id = 999999999;
            autor.Nome = "Novo Autor";
            listaAutores.Add(autor);
            CbxControleAutor = listaAutores[0].Id;


            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxAutor.DataSource = listaAutores;

            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxAutor.DisplayMember = "Nome";
        }

        private void PopularCbxEditora()
        {
            List<EditoraEnt> listaEditoras = (editoraController.PegaTodosEditoras() == null ? new List<EditoraEnt>() : editoraController.PegaTodosEditoras());
            EditoraEnt editora = new EditoraEnt();
            editora.Id = 999999999;
            editora.Nome = "Nova Editora";
            listaEditoras.Add(editora);
            CbxControleEditora = listaEditoras[0].Id;

            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxEditora.DisplayMember = "Nome";

            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxEditora.DataSource = listaEditoras;
        }

        private void PopularCbxGenero()
        {
            List<GeneroEnt> listaGeneros = (generoController.PegaTodosGeneros() == null ? new List<GeneroEnt>() : generoController.PegaTodosGeneros());
            AutorEnt genero = new AutorEnt();
            CbxControleGenero = listaGeneros[0].Id;
            // Defina a propriedade DisplayMember para o nome da propriedade do objeto que deseja exibir como texto no ComboBox
            cbxGenero.DisplayMember = "Genero";

            // Atribua a lista de objetos à propriedade DataSource do ComboBox
            cbxGenero.DataSource = listaGeneros;
        }

        #endregion

        #region Cliques

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

                byte[] imagemBytes  = File.ReadAllBytes(CaminhoDaImagem);
                LivroEnt livro      = new LivroEnt();
                livro.Titulo        = txtTitulo.Text;
                livro.Preco         = Convert.ToDecimal(mTxtPreco.Text.Replace("R$", ""));
                livro.Descricao     = txtDescricaoLivro.Text;
                livro.Estoque       = Convert.ToInt32(txtQtdEstoque.Text);
                livro.AnoPublicacao = (dtpAnoPublicacao.Value).ToString();
                livro.Isbn          = txtIsbn.Text;
                livro.Imagem        = imagemBytes;
                if (CbxControleEditora != 0)
                {
                    livro.IdEditora = CbxControleEditora;
                }
                else
                {
                    EditoraEnt editora = new EditoraEnt();
                    editora.Telefone = txtTelefoneEditora.Text;
                    editora.Nome     = txtTelefoneEditora.Text;

                    string resultado =  editoraController.InserirEditora(editora);

                    if (resultado == "OK")
                    {
                        editora = editoraController.PegarPorNome(editora.Nome);

                        livro.Id = editora.Id;
                    }
                }
                string msg = livroController.InserirLivro(livro);
                MessageBox.Show(msg, "Resposta Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Livro" + ex, "Resposta Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    CbxControleEditora         = 0;
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
