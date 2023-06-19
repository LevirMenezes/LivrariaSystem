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

        public string InserirEndereco(EnderecoEnt endereco)
        {
            return EnderecoModels.Insert(endereco);
        }

        public string AtualizarEndereco(EnderecoEnt endereco)
        {
            return EnderecoModels.Update(endereco);
        }

        public string DeletarEndereco(int id)
        {
            return EnderecoModels.Delete(id);
        }

        public List<EnderecoEnt> PegaTodosEnderecos()
        {
            return EnderecoModels.GetAll();
        }

        public EnderecoEnt PegaEnderecoPorId(int id)
        {
            return EnderecoModels.GetById(id);
        }

        public EnderecoEnt PegaEnderecoPorIdUsuario(int idusuario)
        {
            return EnderecoModels.GetByUsuarioId(idusuario);
        }
    }
}
