
namespace LivrariaTor.View
{
    partial class Formas_de_pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formas_de_pagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxCarrinho = new System.Windows.Forms.PictureBox();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.picboxCarrinho);
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 57);
            this.panel1.TabIndex = 17;
            // 
            // picboxCarrinho
            // 
            this.picboxCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.picboxCarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.BackgroundImage")));
            this.picboxCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxCarrinho.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.ErrorImage")));
            this.picboxCarrinho.InitialImage = ((System.Drawing.Image)(resources.GetObject("picboxCarrinho.InitialImage")));
            this.picboxCarrinho.Location = new System.Drawing.Point(11, 2);
            this.picboxCarrinho.Margin = new System.Windows.Forms.Padding(2);
            this.picboxCarrinho.Name = "picboxCarrinho";
            this.picboxCarrinho.Size = new System.Drawing.Size(49, 47);
            this.picboxCarrinho.TabIndex = 9;
            this.picboxCarrinho.TabStop = false;
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(78, 15);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(281, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Formas de pagamento";
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.Purple;
            this.btnEntrar.Location = new System.Drawing.Point(271, 305);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(201, 36);
            this.btnEntrar.TabIndex = 26;
            this.btnEntrar.Text = "Confirmar o pagamento";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // Formas_de_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formas_de_pagamento";
            this.Text = "Formas_de_pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxCarrinho;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Button btnEntrar;
    }
}