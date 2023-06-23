using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
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
    public partial class Relatoriodeestoque : Form
    {
        private LivroController LivroController = new LivroController();
        private List<LivroEnt> Livros;

        public Relatoriodeestoque()
        {
            InitializeComponent();
            Livros = LivroController.PegaLivroEstoque();
        }

        private void PopularLista()
        {
            List<ItemRelatorioestoque> ItensRelatorio = new List<ItemRelatorioestoque>();

            // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
            if (fpnlEstoque.Controls.Count > 0)
            {
                fpnlEstoque.Controls.Clear();
            }

            foreach (LivroEnt livro in Livros)
            {
                Image img = livro.ByteToIMG();
                ItemRelatorioestoque item = new ItemRelatorioestoque();
                item.ImagemLivro          = (img == null ? Properties.Resources.adicionar_foto : img);
                item.Title                = livro.Titulo;
                item.PrecoLivro           = livro.Preco;
                item.Isbn                 = livro.Isbn;
                item.AnodePublicacao      = livro.AnoPublicacao;
                item.Estoque              = livro.Estoque;

                item.Width                = fpnlEstoque.Width;

                ItensRelatorio.Add(item);

                fpnlEstoque.Controls.Add(item);
            }
        }

        private void Relatoriodeestoque_Load(object sender, EventArgs e)
        {
            PopularLista();
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaAdm form_telaadm = new TelaAdm();
            form_telaadm.Show();
            this.Close();
        }
    }
}
