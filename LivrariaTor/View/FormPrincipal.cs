﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LivrariaTor.Persistencia;
using LivrariaTor.Controller;
using LivrariaTor.View;
using System.IO;

namespace LivrariaTor
{
    public partial class FormPrincipal : Form
    {
        private List<LivroEnt> Livros = new List<LivroEnt>();
        private LivroController LivroController = new LivroController();
        private int ImgControle1 = 0; 
        private int ImgControle2 = 0; 
        private int ImgControle3 = 0; 
        public FormPrincipal()
        {
            InitializeComponent();
            Livros = LivroController.PegaTodosLivros();
        }
        
        #region DE FUNCIONALIDADE DO FORMULARIO
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void picboxCarrinho_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<LivrariaTor.View.Carrinho>();

        }  

        private void LklLivros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Catalogodelivros form_listalivros = new Catalogodelivros();
            form_listalivros.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AbrirFormulario<LivrariaTor.View.Informacoes>();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AbrirFormulario<LivrariaTor.View.Maisvendidos>();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmUsuario form_
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["FrmCadastro"] == null)
            //    btnCadastro.BackColor = Color.FromArgb(4);
            //if (Application.OpenForms["FrmLivros"] == null)
            //    btnCadastro.BackColor = Color.FromArgb(4);
            //if (Application.OpenForms["FrmVendas"] == null)
            //    btnCadastro.BackColor = Color.FromArgb(4);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            PopularLista();
        }
        private void PopularLista()
        {
            if (Livros.Count >= 3)
            {
                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text  = Livros[0].Titulo;

                using (MemoryStream stream = new MemoryStream(Livros[1].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG2.Image = imagem;
                }
                lblTitulo2.Text  = Livros[1].Titulo;

                using (MemoryStream stream = new MemoryStream(Livros[2].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG3.Image = imagem;
                }
                lblTitulo3.Text  = Livros[2].Titulo;
            }else if(Livros.Count == 2)
            {
                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text = Livros[0].Titulo;

                using (MemoryStream stream = new MemoryStream(Livros[1].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG2.Image = imagem;
                }
                lblTitulo2.Text = Livros[1].Titulo;

                pnlIMG3.Visible = false;
            }
            else if(Livros.Count == 1)
            {
                using (MemoryStream stream = new MemoryStream(Livros[0].Imagem))
                {
                    // Crie um objeto Image a partir do MemoryStream
                    Image imagem = Image.FromStream(stream);

                    // Use a imagem conforme necessário
                    // Por exemplo, atribua-a a uma PictureBox
                    picboxIMG1.Image = imagem;
                }
                lblTitulo1.Text = Livros[0].Titulo;

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

        private void btnSetaDireita_Click(object sender, EventArgs e)
        {

        }

        private void btnSetaEsquerda_Click(object sender, EventArgs e)
        {

        }
    }
}
