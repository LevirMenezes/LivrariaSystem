
using System;

namespace LivrariaTor.View
{
    partial class FrmRelatorioVenda
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
            this.btnVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.fpnlRelatorioVenda = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.lblLivraria.Size = new System.Drawing.Size(251, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Relatório de vendas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 57);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(179)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnVoltarTelaPrincipal);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 583);
            this.panel2.TabIndex = 18;
            // 
            // btnVoltarTelaPrincipal
            // 
            this.btnVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltarTelaPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.btnVoltarTelaPrincipal.Location = new System.Drawing.Point(15, 389);
            this.btnVoltarTelaPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarTelaPrincipal.Name = "btnVoltarTelaPrincipal";
            this.btnVoltarTelaPrincipal.Size = new System.Drawing.Size(150, 28);
            this.btnVoltarTelaPrincipal.TabIndex = 10;
            this.btnVoltarTelaPrincipal.Text = "Voltar";
            this.btnVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnVoltarTelaPrincipal.Click += new System.EventHandler(this.btnVoltarTelaPrincipal_Click);
            // 
            // fpnlRelatorioVenda
            // 
            this.fpnlRelatorioVenda.AutoScroll = true;
            this.fpnlRelatorioVenda.Location = new System.Drawing.Point(200, 57);
            this.fpnlRelatorioVenda.Name = "fpnlRelatorioVenda";
            this.fpnlRelatorioVenda.Size = new System.Drawing.Size(698, 583);
            this.fpnlRelatorioVenda.TabIndex = 19;
            // 
            // FrmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.fpnlRelatorioVenda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de livros";
          
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaAdm form_telaadm = new TelaAdm();
            form_telaadm.Show();
            this.Close();
        }

       

        #endregion


        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel fpnlRelatorioVenda;
        private System.Windows.Forms.Button btnVoltarTelaPrincipal;
    }
}