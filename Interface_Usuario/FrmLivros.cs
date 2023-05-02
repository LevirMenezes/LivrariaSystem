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

namespace Interface_Usuario
{




    public partial class FrmLivros : Form
    {

        private LivroPrototype livroOriginal;



        public FrmLivros()
        {
            InitializeComponent();

            // Cria um livro original para ser usado como protótipo

            livroOriginal = new LivroPrototype()
            {
                Titulo = "A Arte da Guerra",
                Autor = "Sun Tzu",
                Editora = "Martin Claret",
                Preço = "29.90",
                Ano = 2019
            };

            


        }

        // Classe base para os livros
        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Editora { get; set; }
             public string Preço { get; set; }
             public int Ano { get; set; }
        }

        // Classe que implementa o padrão Prototype
        public class LivroPrototype : Livro
        {
            public LivroPrototype Clone()
            {

                return (LivroPrototype)this.MemberwiseClone();
            }
        }

        private void btnCadastroLivro_Click_1(object sender, EventArgs e)
        {

            // Cria um novo livro a partir do livro original
            LivroPrototype novoLivro = livroOriginal.Clone();

            // Configura as propriedades do novo livro
            novoLivro.Titulo = txtTitulo.Text;
           
            novoLivro.Editora = txtEditora.Text;
           
            novoLivro.Ano = int.Parse(txtAnoPublicacao.Text);

            // Salva o novo livro no banco de dados ou em outra fonte de dados

            string connectionString = ConfigurationManager.ConnectionStrings["Prototype_livraria"].
          ConnectionString; SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into tbLivro(Titulo, Autor, Editora,Preco, Ano)" +
                "values (@Titulo,@Autor,@Editora,@Preco, @Ano)";
            command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
            command.Parameters.AddWithValue("@Autor", txtAutor.Text);
            command.Parameters.AddWithValue("@Editora", txtEditora.Text);
            command.Parameters.AddWithValue("@Preco", txtPreco.Text);
            command.Parameters.AddWithValue("@Ano", txtAnoPublicacao.Text);
            command.ExecuteNonQuery();
            connection.Close();




            MessageBox.Show($"Título: {novoLivro.Titulo}\nAutor: {novoLivro.Autor}\n Editora: {novoLivro.Editora}\n Preço: {novoLivro.Preço}\n Ano: {novoLivro.Ano} Confirme os dados!");

            MessageBox.Show("Livro cadastrado com sucesso!");
        }
    

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
