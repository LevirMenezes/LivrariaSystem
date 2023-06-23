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

    public partial class FrmRelatorioVenda : Form
    {
        private ItensPedidoController ItensPedidoController = new ItensPedidoController();
        private List<ItensPedidoEnt> itensPedido;

        public FrmRelatorioVenda()
        {
            InitializeComponent();
            
            
        }

        private void PopularLista()
        {
            List<ItensPedido> itensPedido = new List<ItensPedido>();
 
        }

        private void RelatoriodeVenda_Load(object sender, EventArgs e)
        {
            PopularLista();
        }


    }

    
}
