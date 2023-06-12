using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class FormaPagamentoController
    {
        private FormaPagamentoModel FormaPagamentoModels = new FormaPagamentoModel();

        public string InserirEditora(FormaPagamentoEnt formaPagamento)
        {
            return FormaPagamentoModels.Insert(formaPagamento);
        }

        public string AtualizarEditora(FormaPagamentoEnt formaPagamento)
        {
            return FormaPagamentoModels.Update(formaPagamento);
        }

        public string DeletarEditora(int id)
        {
            return FormaPagamentoModels.Delete(id);
        }

        public List<FormaPagamentoEnt> PegaTodosEditoras()
        {
            return FormaPagamentoModels.GetAll();
        }

        public FormaPagamentoEnt PegaEditoraPorId(int id)
        {
            return FormaPagamentoModels.GetById(id);
        }
    }
}
