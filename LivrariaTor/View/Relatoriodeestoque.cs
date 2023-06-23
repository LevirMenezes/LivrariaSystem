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
        private LivroEnt LivroSelecionado = null;

        public Relatoriodeestoque()
        {
            InitializeComponent();
            Livros = LivroController.PegaLivroEstoque();
        }

        private void RelatorioRelatoriodeestoque_Load(object sender, EventArgs e)
        {
            PopularLista();
        }

        private void PopularLista()
        {
            List<ItemRelatorioestoque> ItensRelatorio = new List<ItemRelatorioestoque>();

            // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }


            foreach (LivroEnt livro in Livros)
            {
                Image img = livro.ByteToIMG();
                ItemRelatorioestoque item = new ItemRelatorioestoque();
                item.Livro = livro;
                item.ImagemLivro = (img == null ? Properties.Resources.adicionar_foto : img);
                item.Title = livro.Titulo;
                item.PrecoLivro = livro.Preco;

                item.Width = flowLayoutPanel1.Width;

                ItensRelatorio.Add(item);

                flowLayoutPanel1.Controls.Add(item);
            }
        }

       
    }
}
