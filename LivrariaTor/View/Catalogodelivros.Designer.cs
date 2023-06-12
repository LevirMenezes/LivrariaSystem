
namespace LivrariaTor.View
{
    partial class Catalogodelivros
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
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.btnDeletarLivro = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(15, 14);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(294, 39);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Catálogo de livros";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 70);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.picboxLivro);
            this.panel2.Controls.Add(this.btnAdicionarCarrinho);
            this.panel2.Controls.Add(this.btnDeletarLivro);
            this.panel2.Controls.Add(this.btnCadastrarLivro);
            this.panel2.Controls.Add(this.btnEditarLivro);
            this.panel2.Controls.Add(this.lblPreco);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(1, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 974);
            this.panel2.TabIndex = 18;
            // 
            // picboxLivro
            // 
            this.picboxLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.picboxLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxLivro.Location = new System.Drawing.Point(48, 31);
            this.picboxLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(172, 207);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(48, 321);
            this.btnAdicionarCarrinho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(164, 38);
            this.btnAdicionarCarrinho.TabIndex = 7;
            this.btnAdicionarCarrinho.Text = "Adiocionar ao Carrinho";
            this.btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            // 
            // btnDeletarLivro
            // 
            this.btnDeletarLivro.Location = new System.Drawing.Point(48, 503);
            this.btnDeletarLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletarLivro.Name = "btnDeletarLivro";
            this.btnDeletarLivro.Size = new System.Drawing.Size(164, 34);
            this.btnDeletarLivro.TabIndex = 6;
            this.btnDeletarLivro.Text = "Deletar";
            this.btnDeletarLivro.UseVisualStyleBackColor = true;
            this.btnDeletarLivro.Click += new System.EventHandler(this.btnDeletarLivro_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(132, 455);
            this.btnCadastrarLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(80, 34);
            this.btnCadastrarLivro.TabIndex = 4;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.Location = new System.Drawing.Point(48, 455);
            this.btnEditarLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(77, 34);
            this.btnEditarLivro.TabIndex = 3;
            this.btnEditarLivro.Text = "Editar";
            this.btnEditarLivro.UseVisualStyleBackColor = true;
            this.btnEditarLivro.Click += new System.EventHandler(this.btnEditarLivro_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPreco.Location = new System.Drawing.Point(131, 283);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(90, 25);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "R$ 00,00";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(101, 252);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(267, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(931, 718);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Catalogodelivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Catalogodelivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de livros";
            this.Load += new System.EventHandler(this.Catalogodelivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDeletarLivro;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnEditarLivro;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarCarrinho;
        private System.Windows.Forms.PictureBox picboxLivro;
    }
}