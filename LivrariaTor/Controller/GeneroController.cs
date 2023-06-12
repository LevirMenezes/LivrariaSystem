using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class GeneroController
    {
        private GeneroModel GeneroModels = new GeneroModel();

        public string InserirLivro(GeneroEnt autor)
        {
            return GeneroModels.Insert(autor);
        }

        public string AtualizarLivro(GeneroEnt autor)
        {
            return GeneroModels.Update(autor);
        }

        public string DeletarLivro(int id)
        {
            return GeneroModels.Delete(id);
        }

        public List<GeneroEnt> PegaTodosGeneros()
        {
            return GeneroModels.GetAll();
        }

        public GeneroEnt PegaGeneroPorId(int id)
        {
            return GeneroModels.GetById(id);
        }

        public GeneroEnt PegaGeneroPorLivroId(int idlivro)
        {
            return GeneroModels.GetByLivroId(idlivro);
        }
    }
}
