using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class PedidoController
    {
        private PedidoModel PedidoModels = new PedidoModel();

        public string InserirEditora(PedidoEnt pedido)
        {
            return PedidoModels.Insert(pedido);
        }

        public string AtualizarEditora(PedidoEnt pedido)
        {
            return PedidoModels.Update(pedido);
        }

        public string DeletarEditora(int id)
        {
            return PedidoModels.Delete(id);
        }

        public List<PedidoEnt> PegaTodosEditoras()
        {
            return PedidoModels.GetAll();
        }

        public PedidoEnt PegaEditoraPorId(int id)
        {
            return PedidoModels.GetById(id);
        }
    }
}
