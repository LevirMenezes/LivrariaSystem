
namespace LivrariaTor.View
{
    partial class FormasPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormasPagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxCarrinho = new System.Windows.Forms.PictureBox();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.btnConfirmarPagamento = new System.Windows.Forms.Button();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtbxCpfUsuario = new System.Windows.Forms.MaskedTextBox();
            this.mtbxTelefoneUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfUsuario = new System.Windows.Forms.Label();
            this.lblTelefoneUsuario = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.tbxNomeUsuario = new System.Windows.Forms.TextBox();
            this.gbxFormasPagamento = new System.Windows.Forms.GroupBox();
            this.rbtnDebito = new System.Windows.Forms.RadioButton();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.tbxCodSeguranca = new System.Windows.Forms.TextBox();
            this.tbxNomeTitular = new System.Windows.Forms.TextBox();
            this.lblCodSeguranca = new System.Windows.Forms.Label();
            this.lblValidadeCartao = new System.Windows.Forms.Label();
            this.lblTelefoneTitular = new System.Windows.Forms.Label();
            this.lblCpfTitular = new System.Windows.Forms.Label();
            this.lblNomeTitular = new System.Windows.Forms.Label();
            this.lblNunCartao = new System.Windows.Forms.Label();
            this.gbxInfoUsuario = new System.Windows.Forms.GroupBox();
            this.gbxInfoPagamento = new System.Windows.Forms.GroupBox();
            this.mtbxNunCartao = new System.Windows.Forms.MaskedTextBox();
            this.mtbxValidadeCartao = new System.Windows.Forms.MaskedTextBox();
            this.mtbxCpfTitular = new System.Windows.Forms.MaskedTextBox();
            this.mtbxTelefoneTitular = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).BeginInit();
            this.gbxFormasPagamento.SuspendLayout();
            this.gbxInfoUsuario.SuspendLayout();
            this.gbxInfoPagamento.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 57);
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
            // btnConfirmarPagamento
            // 
            this.btnConfirmarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPagamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPagamento.ForeColor = System.Drawing.Color.Purple;
            this.btnConfirmarPagamento.Location = new System.Drawing.Point(667, 587);
            this.btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            this.btnConfirmarPagamento.Size = new System.Drawing.Size(201, 36);
            this.btnConfirmarPagamento.TabIndex = 26;
            this.btnConfirmarPagamento.Text = "Confirmar o pagamento";
            this.btnConfirmarPagamento.UseVisualStyleBackColor = true;
            this.btnConfirmarPagamento.Click += new System.EventHandler(this.btnConfirmarPagamento_Click);
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(24, 86);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(133, 25);
            this.lblTotalAPagar.TabIndex = 27;
            this.lblTotalAPagar.Text = "Total a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(153, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(183, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 25);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0000,00";
            // 
            // mtbxCpfUsuario
            // 
            this.mtbxCpfUsuario.Enabled = false;
            this.mtbxCpfUsuario.Location = new System.Drawing.Point(97, 179);
            this.mtbxCpfUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxCpfUsuario.Mask = "000,000,000-00";
            this.mtbxCpfUsuario.Name = "mtbxCpfUsuario";
            this.mtbxCpfUsuario.Size = new System.Drawing.Size(282, 26);
            this.mtbxCpfUsuario.TabIndex = 35;
            // 
            // mtbxTelefoneUsuario
            // 
            this.mtbxTelefoneUsuario.Enabled = false;
            this.mtbxTelefoneUsuario.Location = new System.Drawing.Point(97, 119);
            this.mtbxTelefoneUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTelefoneUsuario.Mask = "(00) 0 0000-0000";
            this.mtbxTelefoneUsuario.Name = "mtbxTelefoneUsuario";
            this.mtbxTelefoneUsuario.Size = new System.Drawing.Size(282, 26);
            this.mtbxTelefoneUsuario.TabIndex = 34;
            // 
            // lblCpfUsuario
            // 
            this.lblCpfUsuario.AutoSize = true;
            this.lblCpfUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblCpfUsuario.Location = new System.Drawing.Point(18, 183);
            this.lblCpfUsuario.Name = "lblCpfUsuario";
            this.lblCpfUsuario.Size = new System.Drawing.Size(38, 19);
            this.lblCpfUsuario.TabIndex = 33;
            this.lblCpfUsuario.Text = "Cpf:";
            // 
            // lblTelefoneUsuario
            // 
            this.lblTelefoneUsuario.AutoSize = true;
            this.lblTelefoneUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblTelefoneUsuario.Location = new System.Drawing.Point(14, 123);
            this.lblTelefoneUsuario.Name = "lblTelefoneUsuario";
            this.lblTelefoneUsuario.Size = new System.Drawing.Size(72, 19);
            this.lblTelefoneUsuario.TabIndex = 32;
            this.lblTelefoneUsuario.Text = "Telefone:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblNomeUsuario.Location = new System.Drawing.Point(14, 59);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(54, 19);
            this.lblNomeUsuario.TabIndex = 31;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // tbxNomeUsuario
            // 
            this.tbxNomeUsuario.Enabled = false;
            this.tbxNomeUsuario.Location = new System.Drawing.Point(97, 56);
            this.tbxNomeUsuario.Name = "tbxNomeUsuario";
            this.tbxNomeUsuario.Size = new System.Drawing.Size(282, 26);
            this.tbxNomeUsuario.TabIndex = 30;
            // 
            // gbxFormasPagamento
            // 
            this.gbxFormasPagamento.Controls.Add(this.rbtnDebito);
            this.gbxFormasPagamento.Controls.Add(this.rbtnCredito);
            this.gbxFormasPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxFormasPagamento.Location = new System.Drawing.Point(29, 156);
            this.gbxFormasPagamento.Name = "gbxFormasPagamento";
            this.gbxFormasPagamento.Size = new System.Drawing.Size(404, 146);
            this.gbxFormasPagamento.TabIndex = 36;
            this.gbxFormasPagamento.TabStop = false;
            this.gbxFormasPagamento.Text = "Formas de Pagamento";
            // 
            // rbtnDebito
            // 
            this.rbtnDebito.AutoSize = true;
            this.rbtnDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDebito.Location = new System.Drawing.Point(6, 87);
            this.rbtnDebito.Name = "rbtnDebito";
            this.rbtnDebito.Size = new System.Drawing.Size(148, 24);
            this.rbtnDebito.TabIndex = 1;
            this.rbtnDebito.TabStop = true;
            this.rbtnDebito.Text = "Cartão de Débito";
            this.rbtnDebito.UseVisualStyleBackColor = true;
            this.rbtnDebito.CheckedChanged += new System.EventHandler(this.rbtnDebito_CheckedChanged);
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnCredito.Location = new System.Drawing.Point(6, 40);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(152, 24);
            this.rbtnCredito.TabIndex = 0;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Cartão de Crédito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            this.rbtnCredito.CheckedChanged += new System.EventHandler(this.rbtnCredito_CheckedChanged);
            // 
            // tbxCodSeguranca
            // 
            this.tbxCodSeguranca.Location = new System.Drawing.Point(154, 351);
            this.tbxCodSeguranca.Name = "tbxCodSeguranca";
            this.tbxCodSeguranca.Size = new System.Drawing.Size(263, 26);
            this.tbxCodSeguranca.TabIndex = 50;
            // 
            // tbxNomeTitular
            // 
            this.tbxNomeTitular.Location = new System.Drawing.Point(154, 97);
            this.tbxNomeTitular.Name = "tbxNomeTitular";
            this.tbxNomeTitular.Size = new System.Drawing.Size(261, 26);
            this.tbxNomeTitular.TabIndex = 47;
            // 
            // lblCodSeguranca
            // 
            this.lblCodSeguranca.AutoSize = true;
            this.lblCodSeguranca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSeguranca.ForeColor = System.Drawing.Color.Purple;
            this.lblCodSeguranca.Location = new System.Drawing.Point(14, 357);
            this.lblCodSeguranca.Name = "lblCodSeguranca";
            this.lblCodSeguranca.Size = new System.Drawing.Size(139, 19);
            this.lblCodSeguranca.TabIndex = 46;
            this.lblCodSeguranca.Text = "Cód. de Segurança:";
            // 
            // lblValidadeCartao
            // 
            this.lblValidadeCartao.AutoSize = true;
            this.lblValidadeCartao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidadeCartao.ForeColor = System.Drawing.Color.Purple;
            this.lblValidadeCartao.Location = new System.Drawing.Point(14, 295);
            this.lblValidadeCartao.Name = "lblValidadeCartao";
            this.lblValidadeCartao.Size = new System.Drawing.Size(129, 19);
            this.lblValidadeCartao.TabIndex = 45;
            this.lblValidadeCartao.Text = "Data de Validade:";
            // 
            // lblTelefoneTitular
            // 
            this.lblTelefoneTitular.AutoSize = true;
            this.lblTelefoneTitular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneTitular.ForeColor = System.Drawing.Color.Purple;
            this.lblTelefoneTitular.Location = new System.Drawing.Point(14, 233);
            this.lblTelefoneTitular.Name = "lblTelefoneTitular";
            this.lblTelefoneTitular.Size = new System.Drawing.Size(141, 19);
            this.lblTelefoneTitular.TabIndex = 44;
            this.lblTelefoneTitular.Text = "Telefone do Titular:";
            // 
            // lblCpfTitular
            // 
            this.lblCpfTitular.AutoSize = true;
            this.lblCpfTitular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfTitular.ForeColor = System.Drawing.Color.Purple;
            this.lblCpfTitular.Location = new System.Drawing.Point(14, 167);
            this.lblCpfTitular.Name = "lblCpfTitular";
            this.lblCpfTitular.Size = new System.Drawing.Size(107, 19);
            this.lblCpfTitular.TabIndex = 43;
            this.lblCpfTitular.Text = "Cpf do Titular:";
            // 
            // lblNomeTitular
            // 
            this.lblNomeTitular.AutoSize = true;
            this.lblNomeTitular.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeTitular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitular.ForeColor = System.Drawing.Color.Purple;
            this.lblNomeTitular.Location = new System.Drawing.Point(11, 97);
            this.lblNomeTitular.Name = "lblNomeTitular";
            this.lblNomeTitular.Size = new System.Drawing.Size(124, 19);
            this.lblNomeTitular.TabIndex = 42;
            this.lblNomeTitular.Text = "Nome no Cartão:";
            // 
            // lblNunCartao
            // 
            this.lblNunCartao.AutoSize = true;
            this.lblNunCartao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNunCartao.ForeColor = System.Drawing.Color.Purple;
            this.lblNunCartao.Location = new System.Drawing.Point(11, 33);
            this.lblNunCartao.Name = "lblNunCartao";
            this.lblNunCartao.Size = new System.Drawing.Size(102, 19);
            this.lblNunCartao.TabIndex = 41;
            this.lblNunCartao.Text = "N° do Cartão:";
            // 
            // gbxInfoUsuario
            // 
            this.gbxInfoUsuario.Controls.Add(this.lblNomeUsuario);
            this.gbxInfoUsuario.Controls.Add(this.tbxNomeUsuario);
            this.gbxInfoUsuario.Controls.Add(this.lblTelefoneUsuario);
            this.gbxInfoUsuario.Controls.Add(this.lblCpfUsuario);
            this.gbxInfoUsuario.Controls.Add(this.mtbxTelefoneUsuario);
            this.gbxInfoUsuario.Controls.Add(this.mtbxCpfUsuario);
            this.gbxInfoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxInfoUsuario.Location = new System.Drawing.Point(29, 330);
            this.gbxInfoUsuario.Name = "gbxInfoUsuario";
            this.gbxInfoUsuario.Size = new System.Drawing.Size(404, 226);
            this.gbxInfoUsuario.TabIndex = 51;
            this.gbxInfoUsuario.TabStop = false;
            this.gbxInfoUsuario.Text = "Informações do Usuário";
            // 
            // gbxInfoPagamento
            // 
            this.gbxInfoPagamento.Controls.Add(this.mtbxNunCartao);
            this.gbxInfoPagamento.Controls.Add(this.mtbxValidadeCartao);
            this.gbxInfoPagamento.Controls.Add(this.mtbxCpfTitular);
            this.gbxInfoPagamento.Controls.Add(this.mtbxTelefoneTitular);
            this.gbxInfoPagamento.Controls.Add(this.lblNunCartao);
            this.gbxInfoPagamento.Controls.Add(this.tbxCodSeguranca);
            this.gbxInfoPagamento.Controls.Add(this.lblNomeTitular);
            this.gbxInfoPagamento.Controls.Add(this.lblCpfTitular);
            this.gbxInfoPagamento.Controls.Add(this.tbxNomeTitular);
            this.gbxInfoPagamento.Controls.Add(this.lblTelefoneTitular);
            this.gbxInfoPagamento.Controls.Add(this.lblCodSeguranca);
            this.gbxInfoPagamento.Controls.Add(this.lblValidadeCartao);
            this.gbxInfoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxInfoPagamento.Location = new System.Drawing.Point(439, 156);
            this.gbxInfoPagamento.Name = "gbxInfoPagamento";
            this.gbxInfoPagamento.Size = new System.Drawing.Size(429, 400);
            this.gbxInfoPagamento.TabIndex = 52;
            this.gbxInfoPagamento.TabStop = false;
            this.gbxInfoPagamento.Text = "Informações de Pagamento";
            // 
            // mtbxNunCartao
            // 
            this.mtbxNunCartao.Location = new System.Drawing.Point(154, 29);
            this.mtbxNunCartao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxNunCartao.Mask = "0000 0000 0000 0000";
            this.mtbxNunCartao.Name = "mtbxNunCartao";
            this.mtbxNunCartao.Size = new System.Drawing.Size(261, 26);
            this.mtbxNunCartao.TabIndex = 51;
            // 
            // mtbxValidadeCartao
            // 
            this.mtbxValidadeCartao.Location = new System.Drawing.Point(154, 293);
            this.mtbxValidadeCartao.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxValidadeCartao.Mask = "00/0000";
            this.mtbxValidadeCartao.Name = "mtbxValidadeCartao";
            this.mtbxValidadeCartao.Size = new System.Drawing.Size(263, 26);
            this.mtbxValidadeCartao.TabIndex = 36;
            // 
            // mtbxCpfTitular
            // 
            this.mtbxCpfTitular.Location = new System.Drawing.Point(154, 163);
            this.mtbxCpfTitular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxCpfTitular.Mask = "000,000,000-00";
            this.mtbxCpfTitular.Name = "mtbxCpfTitular";
            this.mtbxCpfTitular.Size = new System.Drawing.Size(261, 26);
            this.mtbxCpfTitular.TabIndex = 36;
            // 
            // mtbxTelefoneTitular
            // 
            this.mtbxTelefoneTitular.Location = new System.Drawing.Point(154, 230);
            this.mtbxTelefoneTitular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTelefoneTitular.Mask = "(00) 0 0000-0000";
            this.mtbxTelefoneTitular.Name = "mtbxTelefoneTitular";
            this.mtbxTelefoneTitular.Size = new System.Drawing.Size(263, 26);
            this.mtbxTelefoneTitular.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Purple;
            this.btnCancelar.Location = new System.Drawing.Point(29, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 36);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxInfoPagamento);
            this.Controls.Add(this.gbxInfoUsuario);
            this.Controls.Add(this.gbxFormasPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.btnConfirmarPagamento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas_de_pagamento";
            this.Load += new System.EventHandler(this.FormasPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarrinho)).EndInit();
            this.gbxFormasPagamento.ResumeLayout(false);
            this.gbxFormasPagamento.PerformLayout();
            this.gbxInfoUsuario.ResumeLayout(false);
            this.gbxInfoUsuario.PerformLayout();
            this.gbxInfoPagamento.ResumeLayout(false);
            this.gbxInfoPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxCarrinho;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.Button btnConfirmarPagamento;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox mtbxCpfUsuario;
        private System.Windows.Forms.MaskedTextBox mtbxTelefoneUsuario;
        private System.Windows.Forms.Label lblCpfUsuario;
        private System.Windows.Forms.Label lblTelefoneUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox tbxNomeUsuario;
        private System.Windows.Forms.GroupBox gbxFormasPagamento;
        private System.Windows.Forms.RadioButton rbtnDebito;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.TextBox tbxCodSeguranca;
        private System.Windows.Forms.TextBox tbxNomeTitular;
        private System.Windows.Forms.Label lblCodSeguranca;
        private System.Windows.Forms.Label lblValidadeCartao;
        private System.Windows.Forms.Label lblTelefoneTitular;
        private System.Windows.Forms.Label lblCpfTitular;
        private System.Windows.Forms.Label lblNomeTitular;
        private System.Windows.Forms.Label lblNunCartao;
        private System.Windows.Forms.GroupBox gbxInfoUsuario;
        private System.Windows.Forms.GroupBox gbxInfoPagamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtbxValidadeCartao;
        private System.Windows.Forms.MaskedTextBox mtbxCpfTitular;
        private System.Windows.Forms.MaskedTextBox mtbxTelefoneTitular;
        private System.Windows.Forms.MaskedTextBox mtbxNunCartao;
    }
}