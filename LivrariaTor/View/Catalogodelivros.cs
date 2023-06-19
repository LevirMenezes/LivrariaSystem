using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
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
    public partial class Catalogodelivros : Form
    {
        private LivroController LivroController  = new LivroController();
        private List<LivroEnt>  Livros;
        private LivroEnt        LivroSelecionado = null;

        public Catalogodelivros()
        {
            InitializeComponent();
            Livros = LivroController.PegaTodosLivros();
        }

        private void Catalogodelivros_Load(object sender, EventArgs e)
        {
            PopularLista();

            if(VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                btnAdicionarCarrinho.Visible = false;
            }
            else
            {
                btnCadastrarLivro.Visible = false;
                btnEditarLivro.Visible    = false;
                btnDeletarLivro.Visible   = false;
            }
        }

        private void PopularLista()
        {
            List<ItemLivro> ItensLivro = new List<ItemLivro>();

            // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }


            foreach (LivroEnt livro in Livros)
            {
                Image img = livro.ByteToIMG();
                ItemLivro item = new ItemLivro();
                item.Livro       = livro;
                item.ImagemLivro = (img == null ? Properties.Resources.adicionar_foto : img);
                item.Title       = livro.Titulo;
                item.Descricao   = livro.Descricao;
                item.PrecoLivro  = livro.Preco;
                item.Width       = flowLayoutPanel1.Width;
                item.ItemClicado += ItemClicadoHandler;

                ItensLivro.Add(item);   
                
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void ItemClicadoHandler(object sender, ItemLivroEventArgs e)
        {
            // Aqui você tem acesso às informações do item clicado
            string  Titulo    = e.Livro.Titulo;
            decimal Preco     = e.Livro.Preco;
            Image   imagem    = e.Imagem;

            lblTitulo.Visible            = false;
            lblPreco.Visible             = false;
            btnAdicionarCarrinho.Visible = false;

            LivroSelecionado    = e.Livro;
            picboxLivro.Image = imagem;
            lblTitulo.Text    = Titulo;
            lblPreco.Text     = "R$ " + Preco.ToString("F2");
        }

        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (LivroSelecionado == null)
                    throw new Exception("");
                FrmLivros Form_Editar = new FrmLivros(LivroSelecionado);
                Form_Editar.TextoBotao = "Salvar";

                Form_Editar.Show();

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Livro selecionado! Por Favor Selecione um Livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            FrmLivros Form_Cadastrar = new FrmLivros();
            Form_Cadastrar.TextoBotao = "Cadastrar";
            Form_Cadastrar.Show();
            this.Hide();
        }

        private void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (LivroSelecionado == null)
                    throw new Exception("");
                FrmLivros Form_Deletar = new FrmLivros(LivroSelecionado);
                Form_Deletar.TextoBotao = "Deletar";
                Form_Deletar.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Livro selecionado! Por Favor Selecione um Livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal form_principal = new FormPrincipal();
            form_principal.Show();
            this.Close();
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {

        }
    }
}
