using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class EditoraController
    {
        private EditoraModel EditoraModels = new EditoraModel();

        public string InserirEditora(EditoraEnt editora)
        {
            return EditoraModels.Insert(editora);
        }

        public string AtualizarEditora(EditoraEnt editora)
        {
            return EditoraModels.Update(editora);
        }

        public string DeletarEditora(int id)
        {
            return EditoraModels.Delete(id);
        }

        public List<EditoraEnt> PegaTodosEditoras()
        {
            return EditoraModels.GetAll();
        }

        public EditoraEnt PegaEditoraPorId(int id)
        {
            return EditoraModels.GetById(id);
        }

        public EditoraEnt PegarId()
        {
            return EditoraModels.GetId();
        }
    }
}
