using LivrariaTor.Persistencia;
using System;
using System.Drawing;

namespace LivrariaTor.View
{
    public class ItemLivroEventArgs : EventArgs
    {
        public LivroEnt Livro { get; set; }

        public Image Imagem { get; set; }

        public ItemLivroEventArgs(LivroEnt livro, Image imagem)
        {
            Livro  = livro;
            Imagem = imagem;
        }
    }
}
