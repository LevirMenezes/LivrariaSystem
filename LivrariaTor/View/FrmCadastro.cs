using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Usuario
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();

        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastroLivro_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Captura posição de tamanho antes de maximizar para restaurar

        int lx, ly;
        int sw, sh;

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnNormal.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnmaximizar.Visible = false;
            btnNormal.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        
    }
}
