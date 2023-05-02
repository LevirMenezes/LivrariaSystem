
namespace Interface_Usuario
{
    partial class FormPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelConteiner = new System.Windows.Forms.Panel();
            this.painelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.PainelbarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panelConteiner.SuspendLayout();
            this.painelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PainelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PainelbarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConteiner
            // 
            this.panelConteiner.BackColor = System.Drawing.Color.Plum;
            this.panelConteiner.Controls.Add(this.painelFormularios);
            this.panelConteiner.Controls.Add(this.PainelMenu);
            this.panelConteiner.Controls.Add(this.PainelbarraTitulo);
            this.panelConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteiner.Location = new System.Drawing.Point(0, 0);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(900, 661);
            this.panelConteiner.TabIndex = 0;
            // 
            // painelFormularios
            // 
            this.painelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.painelFormularios.Controls.Add(this.pictureBox1);
            this.painelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFormularios.Location = new System.Drawing.Point(163, 40);
            this.painelFormularios.Name = "painelFormularios";
            this.painelFormularios.Size = new System.Drawing.Size(737, 621);
            this.painelFormularios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.MediumOrchid;
            this.PainelMenu.Controls.Add(this.label1);
            this.PainelMenu.Controls.Add(this.pictureBox2);
            this.PainelMenu.Controls.Add(this.btnVendas);
            this.PainelMenu.Controls.Add(this.btnLivros);
            this.PainelMenu.Controls.Add(this.btnCadastro);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 40);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(163, 621);
            this.PainelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(7, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "bookstore system";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnVendas.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.Indigo;
            this.btnVendas.Location = new System.Drawing.Point(0, 309);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(163, 43);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = " Relatório Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnLivros.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnLivros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLivros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.Indigo;
            this.btnLivros.Location = new System.Drawing.Point(0, 248);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(163, 43);
            this.btnLivros.TabIndex = 1;
            this.btnLivros.Text = "Cadastro de Livro";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnCadastro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Indigo;
            this.btnCadastro.Location = new System.Drawing.Point(0, 190);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(163, 43);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro do Funcionário";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // PainelbarraTitulo
            // 
            this.PainelbarraTitulo.BackColor = System.Drawing.Color.Purple;
            this.PainelbarraTitulo.Controls.Add(this.btnRestaurar);
            this.PainelbarraTitulo.Controls.Add(this.btnMinimizar);
            this.PainelbarraTitulo.Controls.Add(this.btnMaximizar);
            this.PainelbarraTitulo.Controls.Add(this.btnFechar);
            this.PainelbarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelbarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PainelbarraTitulo.Name = "PainelbarraTitulo";
            this.PainelbarraTitulo.Size = new System.Drawing.Size(900, 40);
            this.PainelbarraTitulo.TabIndex = 0;
            this.PainelbarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainelbarraTitulo_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(843, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(817, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(843, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(872, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(16, 16);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.panelConteiner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelConteiner.ResumeLayout(false);
            this.painelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PainelMenu.ResumeLayout(false);
            this.PainelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PainelbarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConteiner;
        private System.Windows.Forms.Panel painelFormularios;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Panel PainelbarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

