using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LivrariaTor.Persistencia;
using LivrariaTor.Controller;
using LivrariaTor.View;
using System.IO;
using LivrariaTor.Utils;

namespace LivrariaTor
{
    public partial class FormPrincipal : Form
    {
        #region Variaveis

        private List<LivroEnt>        Livros                = new List<LivroEnt>();
        private LivroController       LivroController       = new LivroController();
        private ItensPedidoController ItensPedidoController = new ItensPedidoController();
        private PedidoController      PedidoController      = new PedidoController();

        private int ImgControle1 = 0; 
        private int ImgControle2 = 0; 
        private int ImgControle3 = 0;

        #endregion

        #region Inicialização

        public FormPrincipal()
        {
            InitializeComponent();
            Livros = LivroController.PegaTodosLivros();
            if (VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                btnTelaAdm.Visible       = true;
                btnTelaAdm.Enabled       = true;
                btnComprar1.Enabled      = false;
                btnComprar2.Enabled      = false;
                btnComprar3.Enabled      = false;
                cbxEstoqueLivro1.Enabled = false;
                cbxEstoqueLivro2.Enabled = false;
                cbxEstoqueLivro3.Enabled = false;
            }
            else
            {
                btnTelaAdm.Visible       = false;
                btnTelaAdm.Enabled       = false;
                btnComprar1.Enabled      = true;
                btnComprar2.Enabled      = true;
                btnComprar3.Enabled      = true;
                cbxEstoqueLivro1.Enabled = true;
                cbxEstoqueLivro2.Enabled = true;
                cbxEstoqueLivro3.Enabled = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (VariaveisGlobais.UsuarioLogado.Imagem != null)
                picboxUser.Image = VariaveisGlobais.UsuarioLogado.ByteToIMG();
            PopularLista();
        }

        #endregion

        #region Metodo

        private void PopularLista()
        {
            if (Livros.Count >= 3)
            {
                #region Livro 1

                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text = Livros[0].Titulo;
                lblPreco1.Text = Livros[0].Preco.ToString("F2");

                List<EnumQuantidade> listaNum1 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[0].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum1.Add(enume);
                }

                cbxEstoqueLivro1.DataSource = listaNum1;
                cbxEstoqueLivro1.DisplayMember = "numString";

                #endregion

                #region Livro 2

                using (MemoryStream stream = new MemoryStream(Livros[1].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG2.Image = imagem;
                }
                lblTitulo2.Text = Livros[1].Titulo;
                lblPreco2.Text = Livros[1].Preco.ToString("F2");

                List<EnumQuantidade> listaNum2 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[1].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum2.Add(enume);
                }

                cbxEstoqueLivro2.DataSource = listaNum2;
                cbxEstoqueLivro2.DisplayMember = "numString";

                #endregion

                #region Livro 3

                using (MemoryStream stream = new MemoryStream(Livros[2].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG3.Image = imagem;
                }
                lblTitulo3.Text = Livros[2].Titulo;
                lblPreco3.Text = Livros[2].Preco.ToString("F2");

                List<EnumQuantidade> listaNum3 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[2].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum3.Add(enume);
                }

                cbxEstoqueLivro3.DataSource = listaNum3;
                cbxEstoqueLivro3.DisplayMember = "numString";

                #endregion

            }
            else if (Livros.Count == 2)
            {
                #region Livro 1

                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text = Livros[0].Titulo;
                lblPreco1.Text = Livros[0].Preco.ToString("F2");

                List<EnumQuantidade> listaNum1 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[0].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum1.Add(enume);
                }

                cbxEstoqueLivro1.DataSource = listaNum1;
                cbxEstoqueLivro1.DisplayMember = "numString";

                #endregion

                #region Livro 2

                using (MemoryStream stream = new MemoryStream(Livros[1].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG2.Image = imagem;
                }
                lblTitulo2.Text = Livros[1].Titulo;
                lblPreco2.Text = Livros[1].Preco.ToString("F2");

                List<EnumQuantidade> listaNum2 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[1].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum2.Add(enume);
                }

                cbxEstoqueLivro2.DataSource = listaNum2;
                cbxEstoqueLivro2.DisplayMember = "numString";

                #endregion

                pnlIMG3.Visible = false;
            }
            else if (Livros.Count == 1)
            {
                #region Livro 1

                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text = Livros[0].Titulo;
                lblPreco1.Text = Livros[0].Preco.ToString("F2");

                List<EnumQuantidade> listaNum1 = new List<EnumQuantidade>();
                for (int i = 1; i <= Livros[0].Estoque; i++)
                {
                    EnumQuantidade enume = new EnumQuantidade();
                    enume.numInt = i;
                    enume.numString = i.ToString();
                    listaNum1.Add(enume);
                }

                cbxEstoqueLivro1.DataSource = listaNum1;
                cbxEstoqueLivro1.DisplayMember = "numString";

                #endregion

                pnlIMG2.Visible = false;
                pnlIMG3.Visible = false;
            }
            else
            {
                pnlIMG1.Visible = false;
                pnlIMG2.Visible = false;
                pnlIMG3.Visible = false;
            }
        }

        #endregion

        #region Buttons e cliques

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picboxCarrinho_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                MessageBox.Show("O adm não pode acessar o carrinho! Essa funcionalidade é única do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Carrinho form_carrinho = new Carrinho();
            //ialogResult resultado = form_carrinho.ShowDialog();

            // Defina a largura desejada para o Form filho
            int larguraFormFilho = 330;

            // Configure a posição e a largura do Form filho em relação ao Form pai
            int x = this.Left;
            int y = this.Top + (this.Height - form_carrinho.Height) / 2;

            form_carrinho.StartPosition = FormStartPosition.Manual;
            form_carrinho.Location = new Point(x, y);

            DialogResult resultado = form_carrinho.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FormasPagamento form_pagamento = new FormasPagamento();
                DialogResult result = form_pagamento.ShowDialog();
            
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Compra realizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Livros = LivroController.PegaTodosLivros();
                    PopularLista();
                }
            }
        }  

        private void LklLivros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Catalogodelivros form_listalivros = new Catalogodelivros();
            form_listalivros.Show();
            this.Hide();
        }

        private void LKlInformacoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Informacoes Form_informacoes = new Informacoes();
            Form_informacoes.Show();
            this.Hide();
        }

        private void LklMaisVendidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Essa funcionalidade ainda não está disponível!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void LKlLancamentos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Essa funcionalidade ainda não está disponível!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnComprar1_Click(object sender, EventArgs e)
        {
            PedidoEnt Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);

            if (Pedido == null)
            {
                PedidoController.InserirPedido(VariaveisGlobais.UsuarioLogado.Id);
                Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            }

            ItensPedidoEnt VerificaItem = ItensPedidoController.PegaItemPorLivro(Livros[0].Id, VariaveisGlobais.UsuarioLogado.Id);
            if (VerificaItem != null && VerificaItem.Id != 0)
            {
                MessageBox.Show("Esse Livro já está no carrinho!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItensPedidoEnt item = new ItensPedidoEnt();
            item.Quantidade     = (cbxEstoqueLivro1.SelectedIndex + 1);
            item.IdLivro        = Livros[0].Id;
            item.IdPedido       = Pedido.Id;
            item.PrecoUnidade   = Livros[0].Preco;

            string respItem = ItensPedidoController.InserirItem(item);

            if (respItem == "OK")
                MessageBox.Show("Livro adicionado ao carrinho!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("O Livro não foi adicionado, por favor tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnComprar2_Click(object sender, EventArgs e)
        {
            PedidoEnt Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);

            if (Pedido == null)
            {
                PedidoController.InserirPedido(VariaveisGlobais.UsuarioLogado.Id);
                Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            }

            ItensPedidoEnt VerificaItem = ItensPedidoController.PegaItemPorLivro(Livros[1].Id, VariaveisGlobais.UsuarioLogado.Id);
            if(VerificaItem != null && VerificaItem.Id != 0)
            {
                MessageBox.Show("Esse Livro já está no carrinho!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItensPedidoEnt item = new ItensPedidoEnt();
            item.Quantidade     = (cbxEstoqueLivro1.SelectedIndex + 1);
            item.IdLivro        = Livros[1].Id;
            item.IdPedido       = Pedido.Id;
            item.PrecoUnidade   = Livros[1].Preco;

            string respItem = ItensPedidoController.InserirItem(item);

            if (respItem == "OK")
                MessageBox.Show("Livro adicionado ao carrinho!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("O Livro não foi adicionado, por favor tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnComprar3_Click(object sender, EventArgs e)
        {
            PedidoEnt Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);

            if (Pedido == null)
            {
                PedidoController.InserirPedido(VariaveisGlobais.UsuarioLogado.Id);
                Pedido = PedidoController.PegaPedidoPorUsuarioId(VariaveisGlobais.UsuarioLogado.Id);
            }

            ItensPedidoEnt VerificaItem = ItensPedidoController.PegaItemPorLivro(Livros[2].Id, VariaveisGlobais.UsuarioLogado.Id);
            if (VerificaItem != null && VerificaItem.Id != 0)
            {
                MessageBox.Show("Esse Livro já está no carrinho!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItensPedidoEnt item = new ItensPedidoEnt();
            item.Quantidade = (cbxEstoqueLivro1.SelectedIndex + 1);
            item.IdLivro = Livros[2].Id;
            item.IdPedido = Pedido.Id;
            item.PrecoUnidade = Livros[2].Preco;

            string respItem = ItensPedidoController.InserirItem(item);

            if (respItem == "OK")
                MessageBox.Show("Livro Adicionado com Sucesso!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("O Livro não foi adicionado, por favor tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Telalogin form_login = new Telalogin();
            form_login.Show();
            this.Close();
            VariaveisGlobais.UsuarioLogado = null;
        }

        private void picboxUser_Click(object sender, EventArgs e)
        {
            if(VariaveisGlobais.UsuarioLogado.Adm == 1)
            {
                MessageBox.Show("O adm deve acessar o relatorio de usuarios cadastrados para editar seu perfil!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmUsuario form_cadastro = new FrmUsuario(VariaveisGlobais.UsuarioLogado);
            form_cadastro.TextoBotao = "Editar";
            form_cadastro.Show();
            this.Close();
        }

        private void btnTelaAdm_Click(object sender, EventArgs e)
        {
            TelaAdm form_adm = new TelaAdm();
            form_adm.Show();
            this.Close();
        }

        #endregion

        #region ItemClique

        #endregion
    }
}
