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

        public string InserirPedido(int idusuario)
        {
            return PedidoModels.Insert(idusuario);
        }

        public string AtualizarPedido(PedidoEnt pedido)
        {
            return PedidoModels.Update(pedido);
        }

        public string DeletarPedido(int id)
        {
            return PedidoModels.Delete(id);
        }

        public List<PedidoEnt> PegaTodosPedidos()
        {
            return PedidoModels.GetAll();
        }

        public PedidoEnt PegaPedidoPorId(int id)
        {
            return PedidoModels.GetById(id);
        }

        public PedidoEnt PegaPedidoPorUsuarioId(int idusuario)
        {
            return PedidoModels.GetByUsuarioId(idusuario);
        }
    }
}
