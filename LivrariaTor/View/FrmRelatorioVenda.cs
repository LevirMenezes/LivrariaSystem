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
        private PedidoController PedidoController = new PedidoController();
        private List<RelatorioVendasEnt> ItensRelatorio;

        public FrmRelatorioVenda()
        {
            InitializeComponent();
        }

        private void PopularLista()
        {
            try
            {
                ItensRelatorio = PedidoController.PegaRelatoriosDeVendas();
                if (ItensRelatorio.Count <= 0)
                    throw new Exception("Não há itens de relatório de vendas para ser exibido!");

                List<ItemRelatoriodeVendas> ItemRelatorio = new List<ItemRelatoriodeVendas>();

                // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
                if (fpnlRelatorioVenda.Controls.Count > 0)
                {
                    fpnlRelatorioVenda.Controls.Clear();
                }


                foreach (RelatorioVendasEnt ItemRelat in ItensRelatorio)
                {
                    ItemRelatoriodeVendas item = new ItemRelatoriodeVendas();

                    item.Datadacompra    = ItemRelat.DataCompra.ToString();
                    item.Usuario         = ItemRelat.NomeUsuario.ToString();
                    item.Email           = ItemRelat.EmailUsuario.ToString();
                    item.Formaspagamento = ItemRelat.TipoPagamento.ToString();
                    item.PrecoLivro      = ItemRelat.PrecoLivro;
                    item.Quantidade      = ItemRelat.Quantidade;
                    item.Subtotal        = ItemRelat.Subtotal;
                    item.Width           = fpnlRelatorioVenda.Width;

                    ItemRelatorio.Add(item);

                    fpnlRelatorioVenda.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }

        private void FrmRelatorioVenda_Load(object sender, EventArgs e)
        {
            PopularLista();
        }

        private void picboxVoltar_Click(object sender, EventArgs e)
        {
            TelaAdm form_telaadm = new TelaAdm();
            form_telaadm.Show();
            this.Close();
        }
    }

    
}
