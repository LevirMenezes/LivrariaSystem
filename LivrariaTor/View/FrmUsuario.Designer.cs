
namespace LivrariaTor
{
    partial class FrmUsuario
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
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblTelefoneUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.mtbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbxSenha = new System.Windows.Forms.MaskedTextBox();
            this.mtbxCpf = new System.Windows.Forms.MaskedTextBox();
            this.picboxImgUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbxConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxCEP = new System.Windows.Forms.TextBox();
            this.btnSelecionarIMG = new System.Windows.Forms.Button();
            this.tbxRua = new System.Windows.Forms.TextBox();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.tbxEstado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(178, 221);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(282, 20);
            this.tbxNome.TabIndex = 0;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(181, 422);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(282, 20);
            this.tbxEmail.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Purple;
            this.btnSair.Location = new System.Drawing.Point(597, 600);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 24);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuario.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastroUsuario.Location = new System.Drawing.Point(722, 600);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(112, 24);
            this.btnCadastroUsuario.TabIndex = 4;
            this.btnCadastroUsuario.Text = "Cadastrar";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroLivro_Click);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.Purple;
            this.lblNomeCompleto.Location = new System.Drawing.Point(52, 217);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(54, 19);
            this.lblNomeCompleto.TabIndex = 7;
            this.lblNomeCompleto.Text = "Nome:";
            // 
            // lblTelefoneUsuario
            // 
            this.lblTelefoneUsuario.AutoSize = true;
            this.lblTelefoneUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblTelefoneUsuario.Location = new System.Drawing.Point(52, 286);
            this.lblTelefoneUsuario.Name = "lblTelefoneUsuario";
            this.lblTelefoneUsuario.Size = new System.Drawing.Size(72, 19);
            this.lblTelefoneUsuario.TabIndex = 8;
            this.lblTelefoneUsuario.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(56, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cpf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(56, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(56, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Senha:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 57);
            this.panel1.TabIndex = 14;
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(10, 11);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(143, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Livraria Tor";
            // 
            // mtbxTelefone
            // 
            this.mtbxTelefone.Location = new System.Drawing.Point(178, 288);
            this.mtbxTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbxTelefone.Mask = "(00) 0 0000-0000";
            this.mtbxTelefone.Name = "mtbxTelefone";
            this.mtbxTelefone.Size = new System.Drawing.Size(282, 20);
            this.mtbxTelefone.TabIndex = 16;
            // 
            // mtbxSenha
            // 
            this.mtbxSenha.Location = new System.Drawing.Point(181, 486);
            this.mtbxSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbxSenha.Name = "mtbxSenha";
            this.mtbxSenha.PasswordChar = '*';
            this.mtbxSenha.Size = new System.Drawing.Size(282, 20);
            this.mtbxSenha.TabIndex = 17;
            // 
            // mtbxCpf
            // 
            this.mtbxCpf.Location = new System.Drawing.Point(181, 356);
            this.mtbxCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbxCpf.Mask = "000.000.000-00";
            this.mtbxCpf.Name = "mtbxCpf";
            this.mtbxCpf.Size = new System.Drawing.Size(282, 20);
            this.mtbxCpf.TabIndex = 18;
            // 
            // picboxImgUser
            // 
            this.picboxImgUser.Image = global::LivrariaTor.Properties.Resources.user_add_21977;
            this.picboxImgUser.Location = new System.Drawing.Point(55, 62);
            this.picboxImgUser.Name = "picboxImgUser";
            this.picboxImgUser.Size = new System.Drawing.Size(106, 106);
            this.picboxImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImgUser.TabIndex = 19;
            this.picboxImgUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(56, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirmar Senha:";
            // 
            // mtbxConfirmarSenha
            // 
            this.mtbxConfirmarSenha.Location = new System.Drawing.Point(181, 544);
            this.mtbxConfirmarSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbxConfirmarSenha.Name = "mtbxConfirmarSenha";
            this.mtbxConfirmarSenha.PasswordChar = '*';
            this.mtbxConfirmarSenha.Size = new System.Drawing.Size(282, 20);
            this.mtbxConfirmarSenha.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(486, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(486, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(486, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(486, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(483, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Rua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(483, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "CEP:";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(555, 354);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(282, 20);
            this.tbxNumero.TabIndex = 23;
            // 
            // tbxCEP
            // 
            this.tbxCEP.Location = new System.Drawing.Point(553, 219);
            this.tbxCEP.Name = "tbxCEP";
            this.tbxCEP.Size = new System.Drawing.Size(282, 20);
            this.tbxCEP.TabIndex = 22;
            // 
            // btnSelecionarIMG
            // 
            this.btnSelecionarIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarIMG.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarIMG.ForeColor = System.Drawing.Color.Purple;
            this.btnSelecionarIMG.Location = new System.Drawing.Point(55, 177);
            this.btnSelecionarIMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionarIMG.Name = "btnSelecionarIMG";
            this.btnSelecionarIMG.Size = new System.Drawing.Size(106, 24);
            this.btnSelecionarIMG.TabIndex = 34;
            this.btnSelecionarIMG.Text = "Selecionar";
            this.btnSelecionarIMG.UseVisualStyleBackColor = true;
            this.btnSelecionarIMG.Click += new System.EventHandler(this.btnSelecionarIMG_Click);
            // 
            // tbxRua
            // 
            this.tbxRua.Location = new System.Drawing.Point(553, 287);
            this.tbxRua.Name = "tbxRua";
            this.tbxRua.Size = new System.Drawing.Size(282, 20);
            this.tbxRua.TabIndex = 35;
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(555, 421);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(282, 20);
            this.tbxBairro.TabIndex = 36;
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(555, 484);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(282, 20);
            this.tbxCidade.TabIndex = 37;
            // 
            // tbxEstado
            // 
            this.tbxEstado.Location = new System.Drawing.Point(555, 543);
            this.tbxEstado.Name = "tbxEstado";
            this.tbxEstado.Size = new System.Drawing.Size(282, 20);
            this.tbxEstado.TabIndex = 38;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.tbxEstado);
            this.Controls.Add(this.tbxCidade);
            this.Controls.Add(this.tbxBairro);
            this.Controls.Add(this.tbxRua);
            this.Controls.Add(this.btnSelecionarIMG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxCEP);
            this.Controls.Add(this.mtbxConfirmarSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxImgUser);
            this.Controls.Add(this.mtbxCpf);
            this.Controls.Add(this.mtbxSenha);
            this.Controls.Add(this.mtbxTelefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTelefoneUsuario);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblTelefoneUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.MaskedTextBox mtbxTelefone;
        private System.Windows.Forms.MaskedTextBox mtbxSenha;
        private System.Windows.Forms.MaskedTextBox mtbxCpf;
        private System.Windows.Forms.PictureBox picboxImgUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxCEP;
        private System.Windows.Forms.Button btnSelecionarIMG;
        private System.Windows.Forms.TextBox tbxRua;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.TextBox tbxEstado;
    }
}