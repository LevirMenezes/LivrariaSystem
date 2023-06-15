namespace LivrariaTor.View
{
    partial class ItemCarrossel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecoLivro = new System.Windows.Forms.Label();
            this.pnlLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLivro
            // 
            this.pnlLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.pnlLivro.Controls.Add(this.label4);
            this.pnlLivro.Controls.Add(this.lblPrecoLivro);
            this.pnlLivro.Controls.Add(this.button1);
            this.pnlLivro.Controls.Add(this.lblTitulo);
            this.pnlLivro.Controls.Add(this.pictureBox1);
            this.pnlLivro.Location = new System.Drawing.Point(16, 16);
            this.pnlLivro.Name = "pnlLivro";
            this.pnlLivro.Size = new System.Drawing.Size(256, 387);
            this.pnlLivro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::LivrariaTor.Properties.Resources.livro_clean_code;
            this.pictureBox1.Location = new System.Drawing.Point(43, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(88, 222);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$";
            // 
            // lblPrecoLivro
            // 
            this.lblPrecoLivro.AutoSize = true;
            this.lblPrecoLivro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLivro.Location = new System.Drawing.Point(89, 264);
            this.lblPrecoLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoLivro.Name = "lblPrecoLivro";
            this.lblPrecoLivro.Size = new System.Drawing.Size(82, 31);
            this.lblPrecoLivro.TabIndex = 5;
            this.lblPrecoLivro.Text = "79,99";
            // 
            // ItemCarrossel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLivro);
            this.Name = "ItemCarrossel";
            this.Size = new System.Drawing.Size(290, 423);
            this.pnlLivro.ResumeLayout(false);
            this.pnlLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLivro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecoLivro;
    }
}
