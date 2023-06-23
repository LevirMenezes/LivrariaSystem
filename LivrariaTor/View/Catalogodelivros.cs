using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class Catalogodelivros : Form
    {
        #region Variaveis

        private LivroController       LivroController       = new LivroController();
        private PedidoController      PedidoController      = new PedidoController();
        private ItensPedidoController ItensPedidoController = new ItensPedidoController();
        private LivroEnt              LivroSelecionado      = null;
        private List<LivroEnt>        Livros;
        private bool                  Config                = true;
        private int                   CbxControl            = 0;

        #endregion

        #region Inicialização

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
                btnCadastrarLivro.Visible    = true;
                btnEditarLivro.Visible       = true;
                btnDeletarLivro.Visible      = true;
            }
            else
            {
                btnCadastrarLivro.Visible = false;
                btnEditarLivro.Visible    = false;
                btnDeletarLivro.Visible   = false;
                cbxQuantidade.Enabled     = false;
            }
        }

        #endregion

        #region Metodos
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

        private void PopulaCombobox()
        {
            List<EnumQuantidade> lista = new List<EnumQuantidade>();
            if (LivroSelecionado != null)
            {
                for (int i = 1; i <= LivroSelecionado.Estoque; i++)
                {
                    EnumQuantidade item = new EnumQuantidade();
                    item.numInt    = i;
                    item.numString = i.ToString();

                    lista.Add(item);
                }
            }
            cbxQuantidade.DataSource    = lista;
            cbxQuantidade.DisplayMember = "numString";
            cbxQuantidade.SelectedIndex = 0;
        }

        #endregion

        #region Buttons e cliques

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
            if (VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                TelaAdm form_adm = new TelaAdm();
                form_adm.Show();
                this.Close();
            }
            else
            {
                FormPrincipal form_principal = new FormPrincipal();
                form_principal.Show();
                this.Close();
            }
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if(LivroSelecionado == null)
            {
                MessageBox.Show("Selecione um livro por favor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PedidoEnt Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);

            if (Pedido == null)
            {
                PedidoController.InserirPedido(VariaveisGlobais.UsuarioLogado.Id);
                Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            }

            ItensPedidoEnt VerificaItem = ItensPedidoController.PegaItemPorLivro(LivroSelecionado.Id, VariaveisGlobais.UsuarioLogado.Id);
            if (VerificaItem != null && VerificaItem.Id != 0)
            {
                MessageBox.Show("Esse Livro já está no carrinho!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItensPedidoEnt item = new ItensPedidoEnt();
            item.Quantidade     = (cbxQuantidade.SelectedIndex + 1);
            item.IdLivro        = LivroSelecionado.Id;
            item.IdPedido       = Pedido.Id;
            item.PrecoUnidade   = LivroSelecionado.Preco;

            string respItem = ItensPedidoController.InserirItem(item);

            if (respItem == "OK")
                MessageBox.Show("Livro adicionado ao carrinho!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("O Livro não foi adicionado, por favor tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region ItemClique
        private void ItemClicadoHandler(object sender, ItemLivroEventArgs e)
        {
            // Aqui você tem acesso às informações do item clicado
            string  Titulo    = e.Livro.Titulo;
            decimal Preco     = e.Livro.Preco;
            Image   imagem    = e.Imagem;

            if(VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                lblPreco.Visible             = false;
                btnAdicionarCarrinho.Visible = false;
                lblTitulo.Visible            = false;
                cbxQuantidade.Visible        = false;
            }
            else
            {
                lblPreco.Visible             = true;
                btnAdicionarCarrinho.Visible = true;
                lblTitulo.Visible            = true;
                cbxQuantidade.Visible        = true;
                cbxQuantidade.Enabled        = true;
            }

            LivroSelecionado  = e.Livro;
            picboxLivro.Image = imagem;
            lblTitulo.Text    = Titulo;
            lblPreco.Text     = "R$ " + Preco.ToString("F2");
            Config            = true;

            PopulaCombobox();

        }

        #endregion

        private void cbxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Config)
            {
                cbxQuantidade.SelectedIndex = 0;
                CbxControl                  = cbxQuantidade.SelectedIndex + 1;
                Config                      = false;
            }
            else
            {
                CbxControl = cbxQuantidade.SelectedIndex + 1;
            }
        }
    }
}
