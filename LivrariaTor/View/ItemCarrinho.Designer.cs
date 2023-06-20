namespace LivrariaTor.View
{
    partial class ItemCarrinho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxIMG = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.lblReaisAux = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.cbxQuantidade = new System.Windows.Forms.ComboBox();
            this.btnIMGFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIMGFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.picboxIMG);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 148);
            this.panel1.TabIndex = 0;
            // 
            // picboxIMG
            // 
            this.picboxIMG.Image = global::LivrariaTor.Properties.Resources.books_3025;
            this.picboxIMG.Location = new System.Drawing.Point(10, 10);
            this.picboxIMG.Name = "picboxIMG";
            this.picboxIMG.Size = new System.Drawing.Size(100, 126);
            this.picboxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxIMG.TabIndex = 0;
            this.picboxIMG.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(100, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 10);
            this.panel2.TabIndex = 7;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloLivro.Location = new System.Drawing.Point(126, 10);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(147, 46);
            this.lblTituloLivro.TabIndex = 8;
            this.lblTituloLivro.Text = "Titulo do Livro";
            // 
            // lblReaisAux
            // 
            this.lblReaisAux.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReaisAux.AutoSize = true;
            this.lblReaisAux.BackColor = System.Drawing.Color.Transparent;
            this.lblReaisAux.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblReaisAux.Location = new System.Drawing.Point(124, 105);
            this.lblReaisAux.Name = "lblReaisAux";
            this.lblReaisAux.Size = new System.Drawing.Size(48, 31);
            this.lblReaisAux.TabIndex = 11;
            this.lblReaisAux.Text = "R$";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(166, 105);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(105, 31);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "0000,00";
            // 
            // cbxQuantidade
            // 
            this.cbxQuantidade.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxQuantidade.FormattingEnabled = true;
            this.cbxQuantidade.Location = new System.Drawing.Point(130, 59);
            this.cbxQuantidade.Name = "cbxQuantidade";
            this.cbxQuantidade.Size = new System.Drawing.Size(59, 21);
            this.cbxQuantidade.TabIndex = 12;
            // 
            // btnIMGFechar
            // 
            this.btnIMGFechar.Image = global::LivrariaTor.Properties.Resources.icons8_excluir_100;
            this.btnIMGFechar.Location = new System.Drawing.Point(287, 5);
            this.btnIMGFechar.Name = "btnIMGFechar";
            this.btnIMGFechar.Size = new System.Drawing.Size(26, 26);
            this.btnIMGFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIMGFechar.TabIndex = 13;
            this.btnIMGFechar.TabStop = false;
            // 
            // ItemCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnIMGFechar);
            this.Controls.Add(this.cbxQuantidade);
            this.Controls.Add(this.lblReaisAux);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTituloLivro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemCarrinho";
            this.Size = new System.Drawing.Size(319, 148);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIMGFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxIMG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblReaisAux;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox cbxQuantidade;
        private System.Windows.Forms.PictureBox btnIMGFechar;
    }
}
