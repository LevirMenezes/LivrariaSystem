using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LivrariaTor
{
    public partial class FrmUsuario : Form
    {
        private UsuarioController UsuarioController = new UsuarioController();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            UsuarioEnt usuario = new UsuarioEnt();
            usuario.Nome     = tbxNome.Text;
            usuario.Telefone = mtbxTelefone.Text;
            usuario.Cpf      = mtbxCpf.Text;
            usuario.Email    = tbxEmail.Text;
            usuario.Senha    = mtbxSenha.Text;

            string resposta = UsuarioController.InserirUsuario(usuario);

            System.Windows.Forms.MessageBox.Show(resposta, "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
