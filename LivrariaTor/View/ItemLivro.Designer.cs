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
            this.lblTituloLivro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.Location = new System.Drawing.Point(161, 17);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(597, 24);
            this.lblTituloLivro.TabIndex = 1;
            this.lblTituloLivro.Text = "Clean Code";
            this.lblTituloLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            this.lblTituloLivro.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.lblTituloLivro.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // lblDescricaoLivro
            // 
            this.lblDescricaoLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoLivro.Location = new System.Drawing.Point(172, 52);
            this.lblDescricaoLivro.Name = "lblDescricaoLivro";
            this.lblDescricaoLivro.Size = new System.Drawing.Size(576, 37);
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
            this.lblPrecoLivro.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLivro.Location = new System.Drawing.Point(192, 102);
            this.lblPrecoLivro.Name = "lblPrecoLivro";
            this.lblPrecoLivro.Size = new System.Drawing.Size(59, 23);
            this.lblPrecoLivro.TabIndex = 3;
            this.lblPrecoLivro.Text = "79,99";
            this.lblPrecoLivro.Click += new System.EventHandler(this.ItemLivro_Click);
            this.lblPrecoLivro.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.lblPrecoLivro.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "R$";
            this.label4.Click += new System.EventHandler(this.ItemLivro_Click);
            this.label4.MouseEnter += new System.EventHandler(this.ItemLivro_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.ItemLivro_MouseLeave);
            // 
            // picboxLivro
            // 
            this.picboxLivro.Location = new System.Drawing.Point(21, 11);
            this.picboxLivro.Name = "picboxLivro";
            this.picboxLivro.Size = new System.Drawing.Size(109, 123);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 143);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.ItemLivro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(142, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 8);
            this.panel2.TabIndex = 6;
            // 
            // ItemLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecoLivro);
            this.Controls.Add(this.lblDescricaoLivro);
            this.Controls.Add(this.lblTituloLivro);
            this.Name = "ItemLivro";
            this.Size = new System.Drawing.Size(765, 143);
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
