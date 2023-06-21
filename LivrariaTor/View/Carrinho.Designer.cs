
namespace LivrariaTor.View
{
    partial class Carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxCarrinho = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.btnFinalizarComprar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReaisAux = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutCarrinho = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.picboxCarrinho);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 57);
            this.panel1.TabIndex = 16;
            // 
            // picboxCarrinho
            // 
            this.picboxCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.picboxCarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.BackgroundImage")));
            this.picboxCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxCarrinho.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.ErrorImage")));
            this.picboxCarrinho.InitialImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.InitialImage")));
            this.picboxCarrinho.Location = new System.Drawing.Point(23, 6);
            this.picboxCarrinho.Margin = new System.Windows.Forms.Padding(2);
            this.picboxCarrinho.Name = "picboxCarrinho";
            this.picboxCarrinho.Size = new System.Drawing.Size(49, 47);
            this.picboxCarrinho.TabIndex = 9;
            this.picboxCarrinho.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(289, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(89, 14);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(178, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Meu Carrinho";
            // 
            // btnFinalizarComprar
            // 
            this.btnFinalizarComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarComprar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarComprar.ForeColor = System.Drawing.Color.Purple;
            this.btnFinalizarComprar.Location = new System.Drawing.Point(6, 582);
            this.btnFinalizarComprar.Name = "btnFinalizarComprar";
            this.btnFinalizarComprar.Size = new System.Drawing.Size(319, 62);
            this.btnFinalizarComprar.TabIndex = 17;
            this.btnFinalizarComprar.Text = "Finalizar Compra";
            this.btnFinalizarComprar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblReaisAux);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 47);
            this.panel2.TabIndex = 18;
            // 
            // lblReaisAux
            // 
            this.lblReaisAux.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReaisAux.AutoSize = true;
            this.lblReaisAux.BackColor = System.Drawing.Color.Transparent;
            this.lblReaisAux.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblReaisAux.Location = new System.Drawing.Point(222, 14);
            this.lblReaisAux.Name = "lblReaisAux";
            this.lblReaisAux.Size = new System.Drawing.Size(29, 19);
            this.lblReaisAux.TabIndex = 2;
            this.lblReaisAux.Text = "R$";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(253, 14);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(61, 19);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "0000,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // flowLayoutCarrinho
            // 
            this.flowLayoutCarrinho.Location = new System.Drawing.Point(6, 62);
            this.flowLayoutCarrinho.Name = "flowLayoutCarrinho";
            this.flowLayoutCarrinho.Size = new System.Drawing.Size(319, 460);
            this.flowLayoutCarrinho.TabIndex = 19;
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.Purple;
            this.btnEntrar.Location = new System.Drawing.Point(253, 342);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(194, 29);
            this.btnEntrar.TabIndex = 26;
            this.btnEntrar.Text = "Finalizar compras";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 650);
            this.Controls.Add(this.flowLayoutCarrinho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFinalizarComprar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.Carrinho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.PictureBox picboxCarrinho;
        private System.Windows.Forms.Button btnFinalizarComprar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReaisAux;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCarrinho;
    }
}