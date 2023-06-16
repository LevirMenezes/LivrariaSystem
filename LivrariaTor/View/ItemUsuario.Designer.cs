
using System;

namespace LivrariaTor.View
{
    partial class ItemUsuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.Location = new System.Drawing.Point(176, 12);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(597, 24);
            this.lblTituloLivro.TabIndex = 1;
            this.lblTituloLivro.Text = "Usuário";
            this.lblTituloLivro.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.lblTituloLivro.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.lblTituloLivro.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picboxLivro);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 143);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.ItemUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(141, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 8);
            this.panel2.TabIndex = 6;
            // 
            // picboxLivro
            // 
            this.picboxLivro.Image = global::LivrariaTor.Properties.Resources.Milena_Souza_Silva;
            this.picboxLivro.Location = new System.Drawing.Point(21, 11);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(109, 123);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            this.picboxLivro.Click += new System.EventHandler(this.ItemUsuario_Click);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(177, 47);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Milena Daniela Souza Silva";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(177, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "millenamia02@gmail.com";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(459, 94);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(127, 20);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "(69) 99310-6458";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(463, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(108, 20);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "03350151230";
            // 
            // ItemUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloLivro);
            this.Name = "ItemUsuario";
            this.Size = new System.Drawing.Size(765, 143);
            this.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ItemUsuario_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItemUsuario_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItemUsuario_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItemLivro_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
    }
}
