using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        double num1;
        string op;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        private void button1_Click(object sender, EventArgs e) {
            // limpar a tela
            textBox1.Text = "0";
        }
        private void button18_Click(object sender, EventArgs e) {
            // virgula
            textBox1.Text = textBox1.Text + ",";
        }

        

        private void n1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "1";
            } else {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "2";
            } else {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            // botão 3 
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "3";
            } else {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "4";
            } else {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "5";
            } else {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "6";
            } else {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "7";
            } else {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "8";
            } else {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "9";
            } else {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e) {
            if (textBox1.Text == "0" && textBox1.Text != null) {
                textBox1.Text = "0";
            } else {
                textBox1.Text = textBox1.Text + "0";
            }
        }


        private void bDiv_Click(object sender, EventArgs e) {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
        }

        private void bMult_Click(object sender, EventArgs e) {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
        }

        private void bSub_Click(object sender, EventArgs e) {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "-";
        }

        private void bSum_Click(object sender, EventArgs e) {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "+";
        }

        private void bEqual_Click(object sender, EventArgs e) {
            double num2;
            double res;

            num2 = Convert.ToDouble(textBox1.Text);

            if(op == "+") {
                res = (num1 + num2);
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            if(op == "-") {
                res = (num1 - num2);
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            if(op == "*") {
                res = (num1 * num2);
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            if(op == "/") {
                if(num2 == 0) {
                    float fontSize = (float) (this.Width * 0.05); //ajusta o tamanho de acordo cp+om a proporção da tela

                    textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize); // redefinindo o tamanho da fonte
                    textBox1.Text = "Não é possivel dividir por 0";
                } else {
                    res = (num1 / num2);
                    textBox1.Text = Convert.ToString(res);
                    num1 = res;
                }

            }
            if(op == "%")
            {
                res = num1 / 100;
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            } 
            if(op == "+/-")
            {
                res = num1 * (-1);
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = "+/-";

        }
    }
}
