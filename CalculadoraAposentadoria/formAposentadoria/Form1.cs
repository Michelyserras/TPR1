using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formAposentadoria {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) {
            foreach(Control ctrl in groupBox1.Controls) {
                if (chkNegrito.Checked) {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size, ctrl.Font.Style | FontStyle.Bold);
                } else {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size, ctrl.Font.Style & ~FontStyle.Bold);
                }

            }

        }

        private void chkItalico_CheckedChanged(object sender, EventArgs e) {
            foreach (Control ctrl in groupBox1.Controls) {
                if (chkItalico.Checked) {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size, ctrl.Font.Style | FontStyle.Italic);
                } else {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size, ctrl.Font.Style & ~FontStyle.Italic);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int idadeUser = int.Parse(idade.Text.ToString());
            int anosTrabalhados = int.Parse(anoContribuicao.Text.ToString());
            int diferecaIdade = 0, diferencaAnosTra = 0;
            string nomeUser = nome.Text.ToString();

            if (femnino.Checked) {
                if(idadeUser > 0 && anosTrabalhados > 0) {
                    diferecaIdade = 60 - idadeUser;
                    diferencaAnosTra = 35 - anosTrabalhados;
                    MessageBox.Show($"Caro(a) {nomeUser}, faltam {diferecaIdade} anos para sua aposentadoria por idade e {diferencaAnosTra} anos de contribuição");
                }
               
            }
            else if (masculino.Checked) {
                if (idadeUser > 0 && anosTrabalhados > 0) {
                    diferecaIdade = 65 - idadeUser;
                    diferencaAnosTra = 35 - anosTrabalhados;
                    MessageBox.Show($"Caro(a) {nomeUser}, faltam {diferecaIdade} anos para sua aposentadoria por idade e {diferencaAnosTra} anos de contribuição");
                }

            }

        }
    }
}
