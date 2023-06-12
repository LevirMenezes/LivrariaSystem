using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class AutorController
    {
        private AutorModel AutorModels = new AutorModel();

        public string InserirAutor(AutorEnt autor)
        {
            return AutorModels.Insert(autor);
        }

        public string AtualizarAutor(AutorEnt autor)
        {
            return AutorModels.Update(autor);
        }

        public string DeletarAutor(int id)
        {
            return AutorModels.Delete(id);
        }

        public List<AutorEnt> PegaTodosAutores()
        {
            return AutorModels.GetAll();
        }

        public AutorEnt PegaAutorPorId(int id)
        {
            return AutorModels.GetById(id);
        }

        public AutorEnt PegaAutorPorLivroId(int idlivro)
        {
            return AutorModels.GetByLivroId(idlivro);
        }
    }
}
