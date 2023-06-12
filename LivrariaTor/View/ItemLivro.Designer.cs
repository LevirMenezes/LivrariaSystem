namespace LivrariaTor.View
{
    partial class ItemLivro
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
            this.lblDescricaoLivro = new System.Windows.Forms.Label();
            this.lblPrecoLivro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picboxLivro = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.Location = new System.Drawing.Point(212, 34);
            this.lblTituloLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(796, 30);
            this.lblTituloLivro.TabIndex = 1;
            this.lblTituloLivro.Text = "Clean Code";
            this.lblTituloLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            this.lblTituloLivro.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.lblTituloLivro.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // lblDescricaoLivro
            // 
            this.lblDescricaoLivro.Location = new System.Drawing.Point(229, 64);
            this.lblDescricaoLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoLivro.Name = "lblDescricaoLivro";
            this.lblDescricaoLivro.Size = new System.Drawing.Size(768, 46);
            this.lblDescricaoLivro.TabIndex = 2;
            this.lblDescricaoLivro.Text = "O livro Clean Code.";
            this.lblDescricaoLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            this.lblDescricaoLivro.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.lblDescricaoLivro.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // lblPrecoLivro
            // 
            this.lblPrecoLivro.AutoSize = true;
            this.lblPrecoLivro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLivro.Location = new System.Drawing.Point(256, 126);
            this.lblPrecoLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoLivro.Name = "lblPrecoLivro";
            this.lblPrecoLivro.Size = new System.Drawing.Size(82, 31);
            this.lblPrecoLivro.TabIndex = 3;
            this.lblPrecoLivro.Text = "79,99";
            this.lblPrecoLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            this.lblPrecoLivro.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.lblPrecoLivro.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "R$";
            this.label4.Click += new System.EventHandler(this.ItemLivro_Click);
            this.label4.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // picboxLivro
            // 
            this.picboxLivro.Image = global::LivrariaTor.Properties.Resources.livro_clean_code;
            this.picboxLivro.Location = new System.Drawing.Point(28, 14);
            this.picboxLivro.Margin = new System.Windows.Forms.Padding(4);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(145, 151);
            this.picboxLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLivro.TabIndex = 0;
            this.picboxLivro.TabStop = false;
            this.picboxLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.picboxLivro);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 176);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.ItemLivro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(190, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 10);
            this.panel2.TabIndex = 6;
            // 
            // ItemLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecoLivro);
            this.Controls.Add(this.lblDescricaoLivro);
            this.Controls.Add(this.lblTituloLivro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemLivro";
            this.Size = new System.Drawing.Size(1020, 176);
            this.Click += new System.EventHandler(this.ItemLivro_Click);
            this.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLivro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblDescricaoLivro;
        private System.Windows.Forms.Label lblPrecoLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
