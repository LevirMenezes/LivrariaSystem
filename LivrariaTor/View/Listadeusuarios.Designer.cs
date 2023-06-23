using System;

namespace LivrariaTor.View
{
    partial class Listadeusuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLivraria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.picboxUsuario = new System.Windows.Forms.PictureBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(11, 11);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(208, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Lista de usuários";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 57);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnVoltarTelaPrincipal);
            this.panel2.Controls.Add(this.btnDeletar);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.picboxUsuario);
            this.panel2.Controls.Add(this.lblPreco);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 583);
            this.panel2.TabIndex = 18;
            // 
            // btnVoltarTelaPrincipal
            // 
            this.btnVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarTelaPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.btnVoltarTelaPrincipal.Location = new System.Drawing.Point(12, 446);
            this.btnVoltarTelaPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarTelaPrincipal.Name = "btnVoltarTelaPrincipal";
            this.btnVoltarTelaPrincipal.Size = new System.Drawing.Size(168, 28);
            this.btnVoltarTelaPrincipal.TabIndex = 14;
            this.btnVoltarTelaPrincipal.Text = "Voltar";
            this.btnVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnVoltarTelaPrincipal.Click += new System.EventHandler(this.btnVoltarTelaPrincipal_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Purple;
            this.btnDeletar.Location = new System.Drawing.Point(12, 402);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(168, 28);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrar.Location = new System.Drawing.Point(94, 361);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 28);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Purple;
            this.btnEditar.Location = new System.Drawing.Point(12, 361);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(68, 28);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // picboxUsuario
            // 
            this.picboxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picboxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.picboxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxUsuario.Location = new System.Drawing.Point(36, 25);
            this.picboxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.picboxUsuario.Name = "picboxUsuario";
            this.picboxUsuario.Size = new System.Drawing.Size(130, 169);
            this.picboxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUsuario.TabIndex = 0;
            this.picboxUsuario.TabStop = false;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPreco.Location = new System.Drawing.Point(98, 398);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 20);
            this.lblPreco.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(76, 205);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 583);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Listadeusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listadeusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de livros";
            this.Load += new System.EventHandler(this.Listadeusuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picboxUsuario;
        private System.Windows.Forms.Button btnVoltarTelaPrincipal;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
    }
}