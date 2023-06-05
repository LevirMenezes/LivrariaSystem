using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System.Collections.Generic;

namespace LivrariaTor.Controller
{
    public class LivroController
    {
        private LivroModel LivroModels = new LivroModel();

        public string InserirLivro(LivroEnt livro)
        {
            return LivroModels.Insert(livro);
        }

        public string AtualizarLivro(LivroEnt livro)
        {
            return LivroModels.Update(livro);
        }

        public string DeletarLivro(int id)
        {
            return LivroModels.Delete(id);
        }

        public List<LivroEnt> PegaTodosLivros()
        {
            return LivroModels.GetAll();
        }

        public LivroEnt PegaLivroPorId(int id)
        {
            return LivroModels.GetById(id);
        }
    }
}
