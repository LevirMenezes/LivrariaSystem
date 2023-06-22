using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LivrariaTor.Utils
{
    public class ItemCarrinhoEventArgs : EventArgs
    {
        public ItensPedidoEnt Item { get; set; }
        public Image Imagem { get; set; }

        public ItemCarrinhoEventArgs(ItensPedidoEnt item, Image img)
        {
            Item   = item;
            Imagem = img;
        }
    }
}
