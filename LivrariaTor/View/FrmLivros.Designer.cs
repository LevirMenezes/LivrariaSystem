
namespace LivrariaTor
{
    partial class FrmLivros
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
            this.mTxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTelefoneUsuario = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cbxAutor = new System.Windows.Forms.ComboBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.picboxSelecionarImagem = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoneEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpAnoPublicacao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescricaoLivro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSelecionarImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.lblLivraria);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 70);
            this.panel1.TabIndex = 14;
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.White;
            this.lblLivraria.Location = new System.Drawing.Point(13, 14);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(181, 41);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Livraria Tor";
            // 
            // mTxtPreco
            // 
            this.mTxtPreco.Location = new System.Drawing.Point(152, 129);
            this.mTxtPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mTxtPreco.Mask = "$ 9999.99";
            this.mTxtPreco.Name = "mTxtPreco";
            this.mTxtPreco.Size = new System.Drawing.Size(375, 22);
            this.mTxtPreco.TabIndex = 29;
            this.mTxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(16, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Qtd. Estoque:";
            // 
            // lblTelefoneUsuario
            // 
            this.lblTelefoneUsuario.AutoSize = true;
            this.lblTelefoneUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneUsuario.ForeColor = System.Drawing.Color.Purple;
            this.lblTelefoneUsuario.Location = new System.Drawing.Point(17, 132);
            this.lblTelefoneUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneUsuario.Name = "lblTelefoneUsuario";
            this.lblTelefoneUsuario.Size = new System.Drawing.Size(66, 23);
            this.lblTelefoneUsuario.TabIndex = 25;
            this.lblTelefoneUsuario.Text = "Preço:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.Purple;
            this.lblNomeCompleto.Location = new System.Drawing.Point(16, 58);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(67, 23);
            this.lblNomeCompleto.TabIndex = 24;
            this.lblNomeCompleto.Text = "Titulo:";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Purple;
            this.btnSair.Location = new System.Drawing.Point(277, 747);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 30);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrar.Location = new System.Drawing.Point(760, 747);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 30);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Location = new System.Drawing.Point(152, 199);
            this.txtQtdEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(375, 22);
            this.txtQtdEstoque.TabIndex = 21;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(152, 60);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(375, 22);
            this.txtTitulo.TabIndex = 20;
            // 
            // cbxAutor
            // 
            this.cbxAutor.FormattingEnabled = true;
            this.cbxAutor.Location = new System.Drawing.Point(148, 22);
            this.cbxAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAutor.Name = "cbxAutor";
            this.cbxAutor.Size = new System.Drawing.Size(375, 24);
            this.cbxAutor.TabIndex = 33;
            this.cbxAutor.SelectedIndexChanged += new System.EventHandler(this.cbxAutor_SelectedIndexChanged);
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(152, 270);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(375, 24);
            this.cbxGenero.TabIndex = 34;
            this.cbxGenero.SelectedIndexChanged += new System.EventHandler(this.cbxGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome:";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Enabled = false;
            this.txtNomeAutor.Location = new System.Drawing.Point(147, 96);
            this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(375, 22);
            this.txtNomeAutor.TabIndex = 35;
            // 
            // picboxSelecionarImagem
            // 
            this.picboxSelecionarImagem.Image = global::LivrariaTor.Properties.Resources.adicionar_foto;
            this.picboxSelecionarImagem.Location = new System.Drawing.Point(139, 84);
            this.picboxSelecionarImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxSelecionarImagem.Name = "picboxSelecionarImagem";
            this.picboxSelecionarImagem.Size = new System.Drawing.Size(229, 177);
            this.picboxSelecionarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSelecionarImagem.TabIndex = 32;
            this.picboxSelecionarImagem.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.Purple;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(140, 278);
            this.btnSelecionarImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(229, 30);
            this.btnSelecionarImagem.TabIndex = 37;
            this.btnSelecionarImagem.Text = "Selecionar";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefoneEditora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeEditora);
            this.groupBox1.Controls.Add(this.cbxEditora);
            this.groupBox1.Location = new System.Drawing.Point(23, 465);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(532, 242);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(13, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Telefone:";
            // 
            // txtTelefoneEditora
            // 
            this.txtTelefoneEditora.Enabled = false;
            this.txtTelefoneEditora.Location = new System.Drawing.Point(147, 170);
            this.txtTelefoneEditora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefoneEditora.Name = "txtTelefoneEditora";
            this.txtTelefoneEditora.Size = new System.Drawing.Size(375, 22);
            this.txtTelefoneEditora.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Editora:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Enabled = false;
            this.txtNomeEditora.Location = new System.Drawing.Point(147, 108);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(375, 22);
            this.txtNomeEditora.TabIndex = 41;
            // 
            // cbxEditora
            // 
            this.cbxEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(148, 39);
            this.cbxEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(375, 24);
            this.cbxEditora.TabIndex = 42;
            this.cbxEditora.SelectedIndexChanged += new System.EventHandler(this.cbxEditora_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxAutor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeAutor);
            this.groupBox2.Location = new System.Drawing.Point(23, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 143);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpAnoPublicacao);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtIsbn);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDescricaoLivro);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTitulo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtQtdEstoque);
            this.groupBox3.Controls.Add(this.cbxGenero);
            this.groupBox3.Controls.Add(this.lblNomeCompleto);
            this.groupBox3.Controls.Add(this.lblTelefoneUsuario);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mTxtPreco);
            this.groupBox3.Location = new System.Drawing.Point(583, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(532, 608);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livro";
            // 
            // dtpAnoPublicacao
            // 
            this.dtpAnoPublicacao.Location = new System.Drawing.Point(152, 494);
            this.dtpAnoPublicacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAnoPublicacao.Name = "dtpAnoPublicacao";
            this.dtpAnoPublicacao.Size = new System.Drawing.Size(375, 22);
            this.dtpAnoPublicacao.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(16, 494);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Publicação:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(152, 431);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(375, 22);
            this.txtIsbn.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(16, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Isbn:";
            // 
            // txtDescricaoLivro
            // 
            this.txtDescricaoLivro.Location = new System.Drawing.Point(152, 366);
            this.txtDescricaoLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricaoLivro.Name = "txtDescricaoLivro";
            this.txtDescricaoLivro.Size = new System.Drawing.Size(375, 22);
            this.txtDescricaoLivro.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(16, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Descricao:";
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.picboxSelecionarImagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro";
            this.Load += new System.EventHandler(this.FrmLivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSelecionarImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.PictureBox picboxSelecionarImagem;
        private System.Windows.Forms.MaskedTextBox mTxtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTelefoneUsuario;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbxAutor;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoneEditora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpAnoPublicacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescricaoLivro;
        private System.Windows.Forms.Label label8;
    }
}