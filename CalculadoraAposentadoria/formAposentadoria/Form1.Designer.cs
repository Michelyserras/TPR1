namespace formAposentadoria {
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.anoContribuicao = new System.Windows.Forms.TextBox();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.femnino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.chkNegrito = new System.Windows.Forms.CheckBox();
            this.chkItalico = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.anoContribuicao);
            this.groupBox1.Controls.Add(this.masculino);
            this.groupBox1.Controls.Add(this.femnino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Anos de contribuição";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // anoContribuicao
            // 
            this.anoContribuicao.Location = new System.Drawing.Point(18, 211);
            this.anoContribuicao.Name = "anoContribuicao";
            this.anoContribuicao.Size = new System.Drawing.Size(155, 20);
            this.anoContribuicao.TabIndex = 7;
            this.anoContribuicao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(122, 159);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 6;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // femnino
            // 
            this.femnino.AutoSize = true;
            this.femnino.Location = new System.Drawing.Point(22, 159);
            this.femnino.Name = "femnino";
            this.femnino.Size = new System.Drawing.Size(67, 17);
            this.femnino.TabIndex = 5;
            this.femnino.TabStop = true;
            this.femnino.Text = "Feminino";
            this.femnino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(18, 100);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(155, 20);
            this.idade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(18, 46);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(155, 20);
            this.nome.TabIndex = 0;
            // 
            // chkNegrito
            // 
            this.chkNegrito.AutoSize = true;
            this.chkNegrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNegrito.Location = new System.Drawing.Point(314, 25);
            this.chkNegrito.Name = "chkNegrito";
            this.chkNegrito.Size = new System.Drawing.Size(35, 17);
            this.chkNegrito.TabIndex = 1;
            this.chkNegrito.Text = "N";
            this.chkNegrito.UseVisualStyleBackColor = true;
            this.chkNegrito.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // chkItalico
            // 
            this.chkItalico.AutoSize = true;
            this.chkItalico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalico.Location = new System.Drawing.Point(355, 25);
            this.chkItalico.Name = "chkItalico";
            this.chkItalico.Size = new System.Drawing.Size(31, 17);
            this.chkItalico.TabIndex = 2;
            this.chkItalico.Text = "/";
            this.chkItalico.UseVisualStyleBackColor = true;
            this.chkItalico.CheckedChanged += new System.EventHandler(this.chkItalico_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(382, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "A-";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(404, 25);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(20, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "A+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chkItalico);
            this.Controls.Add(this.chkNegrito);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anoContribuicao;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton femnino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkNegrito;
        private System.Windows.Forms.CheckBox chkItalico;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

