﻿using LivrariaTor.Model;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Controller
{
    public class UsuarioController
    {
        private UsuarioModel UsuarioModel = new UsuarioModel();

        public string InserirUsuario(UsuarioEnt usuario)
        {
            return UsuarioModel.Insert(usuario);
        }

        public string AtualizarUsuario(UsuarioEnt usuario)
        {
            return UsuarioModel.Update(usuario);
        }

        public string DeletarUsuario(int id)
        {
            return UsuarioModel.Delete(id);
        }

        public List<UsuarioEnt> PegaTodosUsuarios()
        {
            return UsuarioModel.GetAll();
        }

        public UsuarioEnt PegaUsuarioPorId(int id)
        {
            return UsuarioModel.GetById(id);
        }

        public UsuarioEnt PegaLogin(string usuario, string senha)
        {
            return UsuarioModel.GetLogin(usuario, senha);
        }

        public UsuarioEnt PegaId()
        {
            return UsuarioModel.GetId();
        }

        public UsuarioEnt PegaCPF(string cpf)
        {
            return UsuarioModel.GetByCPF(cpf);
        }

        public UsuarioEnt PegaEmail(string email)
        {
            return UsuarioModel.GetByEmail(email);
        }

    }
}
