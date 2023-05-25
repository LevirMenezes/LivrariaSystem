
namespace Interface_Usuario
{
    partial class FrmVendas
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.btnSairVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 4;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.Purple;
            this.lblCadastroLivro.Location = new System.Drawing.Point(202, 50);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(138, 19);
            this.lblCadastroLivro.TabIndex = 6;
            this.lblCadastroLivro.Text = "Controle de vendas";
            // 
            // btnSairVendas
            // 
            this.btnSairVendas.Location = new System.Drawing.Point(500, 12);
            this.btnSairVendas.Name = "btnSairVendas";
            this.btnSairVendas.Size = new System.Drawing.Size(74, 22);
            this.btnSairVendas.TabIndex = 7;
            this.btnSairVendas.Text = "Sair";
            this.btnSairVendas.UseVisualStyleBackColor = true;
            this.btnSairVendas.Click += new System.EventHandler(this.btnSairVendas_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 329);
            this.Controls.Add(this.btnSairVendas);
            this.Controls.Add(this.lblCadastroLivro);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.Button btnSairVendas;
    }
}