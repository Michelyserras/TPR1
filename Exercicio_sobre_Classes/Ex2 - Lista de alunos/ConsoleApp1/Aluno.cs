using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Aluno {
        

        public int RA { get; set; }
        public String Nome { get; set; }
        public int[] Nota  { get; set; }

        public Aluno() {
            Nota = new int[4];
        }

        public Aluno CadastrarAluno() {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o Ra do aluno: ");
            aluno.RA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            for (int i = 0; i < aluno.Nota.Length; i++) {
                Console.WriteLine($"Informe a {i + 1}a nota");
                aluno.Nota[i] = Convert.ToInt32(Console.ReadLine());
            }

            return aluno;
        }

        public double calcularMediaPonderada() {
            int[] pesos = { 1, 1, 1, 7 };
            double somaNotasPonderadas = 0;
            int somaPesos = 0;

            for (int i = 0; i < Nota.Length; i++) {
                somaNotasPonderadas += Nota[i] * pesos[i]; // Multiplica a nota pelo peso
                somaPesos += pesos[i]; // Soma os pesos
            }

            // Calcula a média ponderada
            double mediaPonderada = somaNotasPonderadas / somaPesos;
            return mediaPonderada;
        }
        public string Situacao(Aluno aluno) {
            double media = calcularMediaPonderada(); 
            if(media >= 6) {
                return "Aprovado";
            }
            else if(media >= 4 && media < 6) {
                return "Recuperação";
            }
            else if(media < 4) {
                return "Reprovado";
            }
            return "Situação indefinida";
        }

    }

}
