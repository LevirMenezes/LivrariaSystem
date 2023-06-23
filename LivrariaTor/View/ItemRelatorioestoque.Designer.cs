
using System;

namespace LivrariaTor.View
{
    partial class ItemRelatorioestoque
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
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblAnopublicacao = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.Location = new System.Drawing.Point(188, 12);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(589, 24);
            this.lblTituloLivro.TabIndex = 1;
            this.lblTituloLivro.Text = "Título do livro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.picboxLivro);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 200);
            this.panel1.TabIndex = 5;
            // 
            // picboxLivro
            // 
            this.picboxLivro.Image = global::LivrariaTor.Properties.Resources.img_colorida;
            this.picboxLivro.Location = new System.Drawing.Point(11, 11);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(139, 170);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(594, 58);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(594, 120);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(69, 20);
            this.lblEstoque.TabIndex = 9;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblAnopublicacao
            // 
            this.lblAnopublicacao.AutoSize = true;
            this.lblAnopublicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnopublicacao.Location = new System.Drawing.Point(188, 59);
            this.lblAnopublicacao.Name = "lblAnopublicacao";
            this.lblAnopublicacao.Size = new System.Drawing.Size(140, 20);
            this.lblAnopublicacao.TabIndex = 10;
            this.lblAnopublicacao.Text = "Ano de publicação";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(188, 120);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(47, 20);
            this.lblIsbn.TabIndex = 11;
            this.lblIsbn.Text = "ISBN";
            // 
            // ItemRelatorioestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblAnopublicacao);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloLivro);
            this.Name = "ItemRelatorioestoque";
            this.Size = new System.Drawing.Size(766, 204);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.PictureBox picboxLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblAnopublicacao;
        private System.Windows.Forms.Label lblIsbn;
    }
}
