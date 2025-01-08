using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            int op = 0;
            String situacao = "";
            List<Aluno> Turma = new List<Aluno>();
            List<Aluno> Aprovado = new List<Aluno>();
            List<Aluno> Reprovado = new List<Aluno>();
            List<Aluno> Recuperacao = new List<Aluno>();
            do {
                op = menu();

                switch (op) {
                    case 1:
                        Aluno novoAluno = new Aluno().CadastrarAluno();
                        Turma.Add(novoAluno);
                        Console.WriteLine("Alunos cadastrados:");
                        foreach (var aluno in Turma) {
                            Console.WriteLine($"Nome: {aluno.Nome}, RA: {aluno.RA}");
                        }
                        break;

                    case 2:
                        foreach(Aluno pessoa in Turma) {
                            situacao = pessoa.Situacao(pessoa);
                            if (situacao == "Aprovado" && !Aprovado.Any(a => a.RA == pessoa.RA)) { // verifica se não há nenhum aluno com o mesmo ra na lista para não haver duplicações
                                Aprovado.Add(pessoa);
                            } else if (situacao == "Recuperação" && !Recuperacao.Any(a => a.RA == pessoa.RA)) {
                                Recuperacao.Add(pessoa);
                            } else if (situacao == "Reprovado" && !Reprovado.Any(a => a.RA == pessoa.RA)) {
                                Reprovado.Add(pessoa);
                            }
                        }

                        Console.WriteLine("\n Alunos Aprovados: ");
                        foreach(Aluno pessoa in Aprovado) {
                            Console.WriteLine($"\n\tNome: {pessoa.Nome} Media: {(pessoa.Nota.Sum()) / 4}\n\t");
                        }

                        Console.WriteLine("\n Alunos Em Recuperação: ");
                        foreach (Aluno pessoa in Recuperacao) {
                            Console.WriteLine($"\n\tNome: {pessoa.Nome} Media: {(pessoa.Nota.Sum()) / 4}\n\t");
                        }

                        Console.WriteLine("\n Alunos Reprovados: ");
                        foreach (Aluno pessoa in Reprovado) {
                            Console.WriteLine($"\n\tNome: {pessoa.Nome} Media: {(pessoa.Nota.Sum()) / 4}\n\t");
                        }
  
                        break;
                    default:
                        break;
                }

            } while (op != 0);

        }
   
        public static int menu() {
            Console.WriteLine("\nInforme uma opção: \n\t [1] Cadastrar Aluno \n\t [2] Exibir Situação \n\t [0] Sair ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
    }

    
}
