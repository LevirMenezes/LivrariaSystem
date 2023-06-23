
namespace LivrariaTor.View
{
    partial class TelaAdm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.btnRelatorioCliente = new System.Windows.Forms.Button();
            this.btnRelatorioEstoque = new System.Windows.Forms.Button();
            this.btnTelaPrincipal = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 16;
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(11, 13);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(181, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Administrador";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(161, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cadastrar Livro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioVendas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioVendas.ForeColor = System.Drawing.Color.Purple;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(163, 324);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(178, 68);
            this.btnRelatorioVendas.TabIndex = 20;
            this.btnRelatorioVendas.Text = "Relatório de vendas";
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // btnRelatorioCliente
            // 
            this.btnRelatorioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioCliente.ForeColor = System.Drawing.Color.Purple;
            this.btnRelatorioCliente.Location = new System.Drawing.Point(503, 205);
            this.btnRelatorioCliente.Name = "btnRelatorioCliente";
            this.btnRelatorioCliente.Size = new System.Drawing.Size(178, 68);
            this.btnRelatorioCliente.TabIndex = 21;
            this.btnRelatorioCliente.Text = "Relatório de clientes";
            this.btnRelatorioCliente.UseVisualStyleBackColor = true;
            this.btnRelatorioCliente.Click += new System.EventHandler(this.btnRelatorioCliente_Click);
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioEstoque.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioEstoque.ForeColor = System.Drawing.Color.Purple;
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(503, 326);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(178, 68);
            this.btnRelatorioEstoque.TabIndex = 22;
            this.btnRelatorioEstoque.Text = "Relatório de estoque";
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);
            // 
            // btnTelaPrincipal
            // 
            this.btnTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.btnTelaPrincipal.Location = new System.Drawing.Point(16, 79);
            this.btnTelaPrincipal.Name = "btnTelaPrincipal";
            this.btnTelaPrincipal.Size = new System.Drawing.Size(119, 33);
            this.btnTelaPrincipal.TabIndex = 23;
            this.btnTelaPrincipal.Text = "Tela inicial";
            this.btnTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnTelaPrincipal.Click += new System.EventHandler(this.btnTelaPrincipal_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Purple;
            this.btnLogOut.Location = new System.Drawing.Point(730, 558);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 37);
            this.btnLogOut.TabIndex = 24;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnTelaPrincipal);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Controls.Add(this.btnRelatorioCliente);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAdm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRelatorioVendas;
        private System.Windows.Forms.Button btnRelatorioCliente;
        private System.Windows.Forms.Button btnRelatorioEstoque;
        private System.Windows.Forms.Button btnTelaPrincipal;
        private System.Windows.Forms.Button btnLogOut;
    }
}