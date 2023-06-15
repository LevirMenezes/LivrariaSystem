namespace LivrariaTor.View
{
    partial class ItemLivroCarrossel
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
            this.pnlLivro = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecoLivro = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.pnlLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLivro
            // 
            this.pnlLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.pnlLivro.Controls.Add(this.label4);
            this.pnlLivro.Controls.Add(this.lblPrecoLivro);
            this.pnlLivro.Controls.Add(this.btnComprar);
            this.pnlLivro.Controls.Add(this.lblTitulo);
            this.pnlLivro.Controls.Add(this.picboxLivro);
            this.pnlLivro.Location = new System.Drawing.Point(12, 11);
            this.pnlLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLivro.Name = "pnlLivro";
            this.pnlLivro.Size = new System.Drawing.Size(192, 314);
            this.pnlLivro.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$";
            // 
            // lblPrecoLivro
            // 
            this.lblPrecoLivro.AutoSize = true;
            this.lblPrecoLivro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLivro.Location = new System.Drawing.Point(67, 214);
            this.lblPrecoLivro.Name = "lblPrecoLivro";
            this.lblPrecoLivro.Size = new System.Drawing.Size(66, 26);
            this.lblPrecoLivro.TabIndex = 5;
            this.lblPrecoLivro.Text = "79,99";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(58, 261);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(76, 27);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(66, 180);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // picboxLivro
            // 
            this.picboxLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxLivro.Image = global::LivrariaTor.Properties.Resources.livro_clean_code;
            this.picboxLivro.Location = new System.Drawing.Point(32, 28);
            this.picboxLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(126, 144);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            // 
            // ItemLivroCarrossel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnlLivro);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemLivroCarrossel";
            this.Size = new System.Drawing.Size(218, 339);
            this.pnlLivro.ResumeLayout(false);
            this.pnlLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLivro;
        private System.Windows.Forms.PictureBox picboxLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecoLivro;
    }
}
