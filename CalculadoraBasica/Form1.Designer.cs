namespace CalculadoraBasica {
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.val2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.val1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelResultado);
            this.groupBox1.Controls.Add(this.multiplicar);
            this.groupBox1.Controls.Add(this.dividir);
            this.groupBox1.Controls.Add(this.subtrair);
            this.groupBox1.Controls.Add(this.soma);
            this.groupBox1.Controls.Add(this.val2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.val1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(278, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora básica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(89, 216);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(118, 25);
            this.labelResultado.TabIndex = 17;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(228, 144);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(80, 33);
            this.multiplicar.TabIndex = 16;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click_1);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(142, 144);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(80, 33);
            this.dividir.TabIndex = 15;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click_1);
            // 
            // subtrair
            // 
            this.subtrair.Location = new System.Drawing.Point(228, 99);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(80, 33);
            this.subtrair.TabIndex = 14;
            this.subtrair.Text = "Subtrair";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click_1);
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(142, 99);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(80, 33);
            this.soma.TabIndex = 13;
            this.soma.Text = "Somar ";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click_1);
            // 
            // val2
            // 
            this.val2.Location = new System.Drawing.Point(254, 62);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(94, 20);
            this.val2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor2";
            // 
            // val1
            // 
            this.val1.Location = new System.Drawing.Point(94, 62);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(94, 20);
            this.val1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.Label label1;
    }
}

