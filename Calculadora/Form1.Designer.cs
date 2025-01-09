namespace Calculadora {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMult = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.bSum = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(75, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "+/-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(138, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bDiv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bDiv.FlatAppearance.BorderSize = 0;
            this.bDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.ForeColor = System.Drawing.Color.White;
            this.bDiv.Location = new System.Drawing.Point(202, 75);
            this.bDiv.Margin = new System.Windows.Forms.Padding(0);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(57, 54);
            this.bDiv.TabIndex = 4;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bMult
            // 
            this.bMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bMult.FlatAppearance.BorderSize = 0;
            this.bMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMult.ForeColor = System.Drawing.Color.White;
            this.bMult.Location = new System.Drawing.Point(202, 135);
            this.bMult.Margin = new System.Windows.Forms.Padding(0);
            this.bMult.Name = "bMult";
            this.bMult.Size = new System.Drawing.Size(57, 54);
            this.bMult.TabIndex = 8;
            this.bMult.Text = "X";
            this.bMult.UseVisualStyleBackColor = false;
            this.bMult.Click += new System.EventHandler(this.bMult_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.Gray;
            this.n3.FlatAppearance.BorderSize = 0;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.Color.White;
            this.n3.Location = new System.Drawing.Point(139, 135);
            this.n3.Margin = new System.Windows.Forms.Padding(0);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(57, 54);
            this.n3.TabIndex = 7;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.button6_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.Gray;
            this.n2.FlatAppearance.BorderSize = 0;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.Color.White;
            this.n2.Location = new System.Drawing.Point(76, 135);
            this.n2.Margin = new System.Windows.Forms.Padding(0);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(57, 54);
            this.n2.TabIndex = 6;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.Gray;
            this.n1.FlatAppearance.BorderSize = 0;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.Color.White;
            this.n1.Location = new System.Drawing.Point(13, 135);
            this.n1.Margin = new System.Windows.Forms.Padding(0);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(57, 54);
            this.n1.TabIndex = 5;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bSub.FlatAppearance.BorderSize = 0;
            this.bSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSub.ForeColor = System.Drawing.Color.White;
            this.bSub.Location = new System.Drawing.Point(202, 195);
            this.bSub.Margin = new System.Windows.Forms.Padding(0);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(57, 54);
            this.bSub.TabIndex = 12;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.Gray;
            this.n6.FlatAppearance.BorderSize = 0;
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.Color.White;
            this.n6.Location = new System.Drawing.Point(139, 195);
            this.n6.Margin = new System.Windows.Forms.Padding(0);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(57, 54);
            this.n6.TabIndex = 11;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.Gray;
            this.n5.FlatAppearance.BorderSize = 0;
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.Color.White;
            this.n5.Location = new System.Drawing.Point(76, 195);
            this.n5.Margin = new System.Windows.Forms.Padding(0);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(57, 54);
            this.n5.TabIndex = 10;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.Gray;
            this.n4.FlatAppearance.BorderSize = 0;
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.Color.White;
            this.n4.Location = new System.Drawing.Point(13, 195);
            this.n4.Margin = new System.Windows.Forms.Padding(0);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(57, 54);
            this.n4.TabIndex = 9;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // bSum
            // 
            this.bSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bSum.FlatAppearance.BorderSize = 0;
            this.bSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSum.ForeColor = System.Drawing.Color.White;
            this.bSum.Location = new System.Drawing.Point(202, 255);
            this.bSum.Margin = new System.Windows.Forms.Padding(0);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(57, 54);
            this.bSum.TabIndex = 16;
            this.bSum.Text = "+";
            this.bSum.UseVisualStyleBackColor = false;
            this.bSum.Click += new System.EventHandler(this.bSum_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.Gray;
            this.n9.FlatAppearance.BorderSize = 0;
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.ForeColor = System.Drawing.Color.White;
            this.n9.Location = new System.Drawing.Point(139, 255);
            this.n9.Margin = new System.Windows.Forms.Padding(0);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(57, 54);
            this.n9.TabIndex = 15;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.Gray;
            this.n8.FlatAppearance.BorderSize = 0;
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.ForeColor = System.Drawing.Color.White;
            this.n8.Location = new System.Drawing.Point(76, 255);
            this.n8.Margin = new System.Windows.Forms.Padding(0);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(57, 54);
            this.n8.TabIndex = 14;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.Gray;
            this.n7.FlatAppearance.BorderSize = 0;
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.ForeColor = System.Drawing.Color.White;
            this.n7.Location = new System.Drawing.Point(13, 255);
            this.n7.Margin = new System.Windows.Forms.Padding(0);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(57, 54);
            this.n7.TabIndex = 13;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.Gray;
            this.n0.FlatAppearance.BorderSize = 0;
            this.n0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.ForeColor = System.Drawing.Color.White;
            this.n0.Location = new System.Drawing.Point(14, 315);
            this.n0.Margin = new System.Windows.Forms.Padding(0);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(118, 54);
            this.n0.TabIndex = 17;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(139, 315);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 54);
            this.button18.TabIndex = 18;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bEqual.FlatAppearance.BorderSize = 0;
            this.bEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.ForeColor = System.Drawing.Color.White;
            this.bEqual.Location = new System.Drawing.Point(201, 315);
            this.bEqual.Margin = new System.Windows.Forms.Padding(0);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(57, 54);
            this.bEqual.TabIndex = 19;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(266, 375);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.bSum);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.bMult);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMult;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button bEqual;
    }
}

