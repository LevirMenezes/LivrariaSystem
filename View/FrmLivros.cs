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

        public FrmLivros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string caminhoDaImagem = openFileDialog1.FileName;
            pictureBox7.Image      = Image.FromFile(caminhoDaImagem);
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title  = "Selecionar Imagem";
            openFileDialog1.ShowDialog();
        }
    }
}
