﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaTor.Persistencia
{
    public class UsuarioEnt
    {
        private int id;      
        private string nome;    
        private string telefone;
        private string cpf;     
        private string email;   
        private string senha;   
        private int adm;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Adm { get => adm; set => adm = value; }
    }
}
