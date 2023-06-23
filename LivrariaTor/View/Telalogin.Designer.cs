
namespace LivrariaTor.View
{
    partial class Telalogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telalogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lblLivraria = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llblCadastrar = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 57);
            this.panel1.TabIndex = 19;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(780, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 32);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 1;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblLivraria
            // 
            this.lblLivraria.AutoSize = true;
            this.lblLivraria.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.lblLivraria.Location = new System.Drawing.Point(385, 106);
            this.lblLivraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLivraria.Name = "lblLivraria";
            this.lblLivraria.Size = new System.Drawing.Size(76, 30);
            this.lblLivraria.TabIndex = 4;
            this.lblLivraria.Text = "Login";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(225, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(318, 229);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 20);
            this.txtSenha.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(225, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Senha";
            // 
            // llblCadastrar
            // 
            this.llblCadastrar.AutoSize = true;
            this.llblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCadastrar.Location = new System.Drawing.Point(382, 261);
            this.llblCadastrar.Name = "llblCadastrar";
            this.llblCadastrar.Size = new System.Drawing.Size(107, 20);
            this.llblCadastrar.TabIndex = 24;
            this.llblCadastrar.TabStop = true;
            this.llblCadastrar.Text = "Cadastre-se";
            this.llblCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCadastrar_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(22)))), ((int)(((byte)(143)))));
            this.btnEntrar.Location = new System.Drawing.Point(366, 314);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(124, 29);
            this.btnEntrar.TabIndex = 25;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Telalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 445);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.llblCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLivraria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Telalogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telalogin";
            this.Load += new System.EventHandler(this.Telalogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLivraria;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblCadastrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}