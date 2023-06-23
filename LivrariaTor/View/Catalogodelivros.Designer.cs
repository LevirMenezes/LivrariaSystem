
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
            this.picboxPesquisa = new System.Windows.Forms.PictureBox();
            this.tbxPesquisa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxQuantidade = new System.Windows.Forms.ComboBox();
            this.btnVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.btnDeletarLivro = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPesquisa)).BeginInit();
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
            this.lblLivraria.Location = new System.Drawing.Point(11, 11);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(233, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Catálogo de livros";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.picboxPesquisa);
            this.panel1.Controls.Add(this.tbxPesquisa);
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 57);
            this.panel1.TabIndex = 15;
            // 
            // picboxPesquisa
            // 
            this.picboxPesquisa.Image = global::LivrariaTor.Properties.Resources.lupa_pesquisar;
            this.picboxPesquisa.Location = new System.Drawing.Point(656, 7);
            this.picboxPesquisa.Name = "picboxPesquisa";
            this.picboxPesquisa.Size = new System.Drawing.Size(43, 44);
            this.picboxPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPesquisa.TabIndex = 6;
            this.picboxPesquisa.TabStop = false;
            this.picboxPesquisa.Click += new System.EventHandler(this.picboxPesquisa_Click);
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPesquisa.Location = new System.Drawing.Point(262, 21);
            this.tbxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPesquisa.Name = "tbxPesquisa";
            this.tbxPesquisa.Size = new System.Drawing.Size(377, 20);
            this.tbxPesquisa.TabIndex = 5;
            this.tbxPesquisa.TextChanged += new System.EventHandler(this.tbxPesquisa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.cbxQuantidade);
            this.panel2.Controls.Add(this.btnVoltarTelaPrincipal);
            this.panel2.Controls.Add(this.picboxLivro);
            this.panel2.Controls.Add(this.btnAdicionarCarrinho);
            this.panel2.Controls.Add(this.btnDeletarLivro);
            this.panel2.Controls.Add(this.btnCadastrarLivro);
            this.panel2.Controls.Add(this.btnEditarLivro);
            this.panel2.Controls.Add(this.lblPreco);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 583);
            this.panel2.TabIndex = 18;
            // 
            // cbxQuantidade
            // 
            this.cbxQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantidade.FormattingEnabled = true;
            this.cbxQuantidade.Location = new System.Drawing.Point(26, 230);
            this.cbxQuantidade.Name = "cbxQuantidade";
            this.cbxQuantidade.Size = new System.Drawing.Size(54, 21);
            this.cbxQuantidade.TabIndex = 11;
            this.cbxQuantidade.SelectedIndexChanged += new System.EventHandler(this.cbxQuantidade_SelectedIndexChanged);
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
            this.btnVoltarTelaPrincipal.TabIndex = 10;
            this.btnVoltarTelaPrincipal.Text = "Voltar";
            this.btnVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnVoltarTelaPrincipal.Click += new System.EventHandler(this.btnVoltarTelaPrincipal_Click);
            // 
            // picboxLivro
            // 
            this.picboxLivro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picboxLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.picboxLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxLivro.Location = new System.Drawing.Point(26, 25);
            this.picboxLivro.Margin = new System.Windows.Forms.Padding(2);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(150, 169);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCarrinho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCarrinho.ForeColor = System.Drawing.Color.Purple;
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(12, 268);
            this.btnAdicionarCarrinho.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(168, 54);
            this.btnAdicionarCarrinho.TabIndex = 7;
            this.btnAdicionarCarrinho.Text = "Adicionar ao Carrinho";
            this.btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            this.btnAdicionarCarrinho.Click += new System.EventHandler(this.btnAdicionarCarrinho_Click);
            // 
            // btnDeletarLivro
            // 
            this.btnDeletarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLivro.ForeColor = System.Drawing.Color.Purple;
            this.btnDeletarLivro.Location = new System.Drawing.Point(12, 402);
            this.btnDeletarLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarLivro.Name = "btnDeletarLivro";
            this.btnDeletarLivro.Size = new System.Drawing.Size(168, 28);
            this.btnDeletarLivro.TabIndex = 6;
            this.btnDeletarLivro.Text = "Deletar";
            this.btnDeletarLivro.UseVisualStyleBackColor = true;
            this.btnDeletarLivro.Click += new System.EventHandler(this.btnDeletarLivro_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLivro.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(94, 361);
            this.btnCadastrarLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(88, 28);
            this.btnCadastrarLivro.TabIndex = 4;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLivro.ForeColor = System.Drawing.Color.Purple;
            this.btnEditarLivro.Location = new System.Drawing.Point(12, 361);
            this.btnEditarLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(68, 28);
            this.btnEditarLivro.TabIndex = 3;
            this.btnEditarLivro.Text = "Editar";
            this.btnEditarLivro.UseVisualStyleBackColor = true;
            this.btnEditarLivro.Click += new System.EventHandler(this.btnEditarLivro_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreco.Location = new System.Drawing.Point(98, 230);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(69, 19);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "R$ 00,00";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(76, 205);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 583);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Catalogodelivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogodelivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de livros";
            this.Load += new System.EventHandler(this.Catalogodelivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPesquisa)).EndInit();
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
        private System.Windows.Forms.Button btnVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox picboxPesquisa;
        public System.Windows.Forms.TextBox tbxPesquisa;
        private System.Windows.Forms.ComboBox cbxQuantidade;
    }
}