using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class EnderecoController
    {
        private EnderecoModel EnderecoModels = new EnderecoModel();

        public string InserirEditora(EnderecoEnt endereco)
        {
            return EnderecoModels.Insert(endereco);
        }

        public string AtualizarEditora(EnderecoEnt endereco)
        {
            return EnderecoModels.Update(endereco);
        }

        public string DeletarEditora(int id)
        {
            return EnderecoModels.Delete(id);
        }

        public List<EnderecoEnt> PegaTodosEditoras()
        {
            return EnderecoModels.GetAll();
        }

        public EnderecoEnt PegaEditoraPorId(int id)
        {
            return EnderecoModels.GetById(id);
        }
    }
}
