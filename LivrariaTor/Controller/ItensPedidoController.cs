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

        public string InserirItem(ItensPedidoEnt itemPedido)
        {
            return ItensPedidoModels.Insert(itemPedido);
        }

        public string AtualizarItem(ItensPedidoEnt itemPedido)
        {
            return ItensPedidoModels.UpdateItem(itemPedido);
        }

        public string AtualizarQuantidadeItem(ItensPedidoEnt itemPedido)
        {
            return ItensPedidoModels.UpdateQuantidade(itemPedido);
        }

        public string DeletarItem(int id)
        {
            return ItensPedidoModels.Delete(id);
        }

        public ItensPedidoEnt PegaItemPorId(int id)
        {
            return ItensPedidoModels.GetById(id);
        }

        public List<ItensPedidoEnt> PegaTodosItensPorUsuario(int idusuario)
        {
            return ItensPedidoModels.GetAllByUsuario(idusuario);
        }

        public ItensPedidoEnt PegaItemPorLivro(int idlivro, int idusuario)
        {
            return ItensPedidoModels.GetByLivroIdAndUsuarioId(idlivro, idusuario);
        }
    }
}
