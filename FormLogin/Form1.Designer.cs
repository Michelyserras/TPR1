namespace FormLogin {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.Label();
            this.senhaText = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.senha);
            this.groupBox1.Controls.Add(this.senhaText);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Controls.Add(this.usuarioText);
            this.groupBox1.Location = new System.Drawing.Point(348, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(63, 185);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Entrar";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(25, 122);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(41, 13);
            this.senha.TabIndex = 3;
            this.senha.Text = "Senha:";
            // 
            // senhaText
            // 
            this.senhaText.Location = new System.Drawing.Point(22, 136);
            this.senhaText.Name = "senhaText";
            this.senhaText.PasswordChar = '*';
            this.senhaText.Size = new System.Drawing.Size(146, 20);
            this.senhaText.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(25, 62);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuário:";
            // 
            // usuarioText
            // 
            this.usuarioText.Location = new System.Drawing.Point(22, 76);
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(146, 20);
            this.usuarioText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.TextBox senhaText;
        private System.Windows.Forms.Button login;
    }
}

