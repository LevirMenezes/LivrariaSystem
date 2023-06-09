﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.Location = new System.Drawing.Point(176, 12);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(589, 24);
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
            this.panel1.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(141, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
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
            this.picboxLivro.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.picboxLivro.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(222, 48);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(210, 21);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Milena Daniela Souza Silva";
            this.lblNomeUsuario.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.lblNomeUsuario.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.lblNomeUsuario.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(223, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(199, 21);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "millenamia02@gmail.com";
            this.lblEmail.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.lblEmail.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.lblEmail.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(532, 94);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(132, 21);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "(69) 99310-6458";
            this.lblTelefone.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.lblTelefone.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.lblTelefone.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(531, 47);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(109, 21);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "03350151230";
            this.lblCPF.Click += new System.EventHandler(this.ItemUsuario_Click);
            this.lblCPF.MouseEnter += new System.EventHandler(this.ItemUsuario_MouseEnter);
            this.lblCPF.MouseLeave += new System.EventHandler(this.ItemUsuario_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // ItemUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        #endregion

        private System.Windows.Forms.PictureBox picboxLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
