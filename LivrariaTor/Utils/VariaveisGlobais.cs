using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Utils
{
    public static class VariaveisGlobais
    {
        public static UsuarioEnt UsuarioLogado { get; set; }

        public static string FormataCPF(string cpf)
        {
            return cpf.Substring(0, 3) + "." +
                   cpf.Substring(3, 3) + "." +
                   cpf.Substring(6, 3) + "-" +
                   cpf.Substring(9);
        }

        public static string FormataTelefone(string tel)
        {
            return "(" + tel.Substring(0, 2) + ")" +
                   " " + tel.Substring(2, 1) + " " +
                   tel.Substring(3, 4) + "-" +
                   tel.Substring(7);
        }

    }
}
