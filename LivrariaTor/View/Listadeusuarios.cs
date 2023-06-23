using LivrariaTor.Controller;
using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class Listadeusuarios : Form
    {
        private UsuarioController UsuarioController  = new UsuarioController();
        private List<UsuarioEnt>  Usuarios;
        private UsuarioEnt        UsuarioSelecionado = null;

        public Listadeusuarios()
        {
            InitializeComponent();
            Usuarios = UsuarioController.PegaTodosUsuarios();
        }

        private void Listadeusuarios_Load(object sender, EventArgs e)
        {
            lblNome.Visible = false;
            PopularLista();
        }

        private void PopularLista()
        {
            List<ItemUsuario> ItensUsuario = new List<ItemUsuario>();

            // Verifica se tem algum item no FlowLayout, se tiver algum item ele limpa o layout
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            foreach (UsuarioEnt usuario in Usuarios)
            {
                Image img         = usuario.ByteToIMG();
                ItemUsuario item  = new ItemUsuario();
                item.Usuario      = usuario;
                item.Imagem       = (img == null ? Properties.Resources.user_add_21977 : img);
                item.Nome         = usuario.Nome;
                item.Email        = usuario.Email;
                item.Cpf          = usuario.Cpf;
                item.Telefone     = usuario.Telefone;
                item.ItemClicado += ItemClicadoHandler;

                ItensUsuario.Add(item);
                
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void ItemClicadoHandler(object sender, ItemUsuarioEventArgs e)
        {
            UsuarioSelecionado  = e.Usuario;
            picboxUsuario.Image = e.Imagem;
            lblNome.Text        = e.Usuario.Nome.Split(' ')[0];
            lblNome.Visible = true; 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioSelecionado == null)
                    throw new Exception("");
                FrmUsuario form_editar = new FrmUsuario(UsuarioSelecionado);
                form_editar.TextoBotao = "Salvar";
                form_editar.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Usuario selecionado! Por Favor Selecione um Usuario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmUsuario form_cadastrar = new FrmUsuario();
            form_cadastrar.TextoBotao = "Cadastrar";
            form_cadastrar.Show();
            this.Hide();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioSelecionado == null)
                    throw new Exception("");
                FrmUsuario form_deletar = new FrmUsuario(UsuarioSelecionado);
                form_deletar.TextoBotao = "Deletar";
                form_deletar.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Usuario selecionado! Por Favor Selecione um Usuario.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaAdm form_adm = new TelaAdm();
            form_adm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
