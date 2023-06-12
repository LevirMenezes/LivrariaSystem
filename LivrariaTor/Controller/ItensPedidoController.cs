using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class ItensPedidoController
    {
        private ItensPedidoModel ItensPedidoModels = new ItensPedidoModel();

        public string InserirEditora(ItensPedidoEnt itemPedido)
        {
            return ItensPedidoModels.Insert(itemPedido);
        }

        public string AtualizarEditora(ItensPedidoEnt itemPedido)
        {
            return ItensPedidoModels.Update(itemPedido);
        }

        public string DeletarEditora(int id)
        {
            return ItensPedidoModels.Delete(id);
        }

        public List<ItensPedidoEnt> PegaTodosEditoras()
        {
            return ItensPedidoModels.GetAll();
        }

        public ItensPedidoEnt PegaEditoraPorId(int id)
        {
            return ItensPedidoModels.GetById(id);
        }
    }
}
