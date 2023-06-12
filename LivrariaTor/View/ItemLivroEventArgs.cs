using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
