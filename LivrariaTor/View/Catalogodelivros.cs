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
    public partial class Catalogodelivros : Form
    {
        private LivroController LivroController = new LivroController();
        private List<LivroEnt> Livros;
        public Catalogodelivros()
        {
            InitializeComponent();
            Livros = LivroController.PegaTodosLivros();
        }

        private void Catalogodelivros_Load(object sender, EventArgs e)
        {
            PopularLista();
        }

        private void PopularLista()
        {
            List<ItemLivro> ItensLivro = new List<ItemLivro>(); 
            
            foreach (LivroEnt livro in Livros)
            {
                ItemLivro item = new ItemLivro();
                item.ImagemLivro = Properties.Resources.livro_clean_code;
                item.Title       = livro.Titulo;
                item.Descricao   = livro.Descricao;
                item.PrecoLivro  = livro.Preco;
                item.Width       = flowLayoutPanel1.Width;

                ItensLivro.Add(item);   
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
