using LivrariaTor.Persistencia;
using LivrariaTor.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LivrariaTor.View
{
    public partial class ItemUsuario : UserControl
    {
        private string _nome;
        private string _email;
        private string _cpf;
        private string _telefone;
        private Image  _imagem;

        public UsuarioEnt Usuario { get; set; }

        public string     Nome     { get => _nome;     set { _nome     = value; lblNomeUsuario.Text = value; } }
                          
        public string     Email    { get => _email;    set { _email    = value; lblEmail.Text       = value; } }
                          
        public string     Cpf      { get => _cpf;      set { _cpf      = value; lblCPF.Text         = value; } }
                          
        public string     Telefone { get => _telefone; set { _telefone = value; lblTelefone.Text    = value; } }
                          
        public Image      Imagem   { get => _imagem;   set { _imagem   = value; picboxLivro.Image   = value; } }


        public event EventHandler<ItemUsuarioEventArgs> ItemClicado;

        public ItemUsuario()
        {
            InitializeComponent();
        }

        private void ItemUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ItemUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ItemUsuario_Click(object sender, EventArgs e)
        {
            ItemClicado?.Invoke(this, new ItemUsuarioEventArgs(Usuario, Imagem));
        }

        private void ItemUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
