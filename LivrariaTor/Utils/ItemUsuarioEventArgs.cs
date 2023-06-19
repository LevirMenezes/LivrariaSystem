using LivrariaTor.Persistencia;
using System;
using System.Drawing;

namespace LivrariaTor.Utils
{
    public class ItemUsuarioEventArgs : EventArgs
    {
        public UsuarioEnt Usuario { get; set; }

        public Image Imagem { get; set; }

        public ItemUsuarioEventArgs(UsuarioEnt usuario, Image imagem)
        {
            Usuario = usuario;
            Imagem  = imagem;
        }
    }
}
