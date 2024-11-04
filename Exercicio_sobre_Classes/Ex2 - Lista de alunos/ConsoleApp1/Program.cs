using System;
using System.Collections.Generic;
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
            Aluno novoAluno = new Aluno();
            List<Aluno> Turma = new List<Aluno>();

            do {
                op = menu();

                switch (op) {
                    case 1:
                        novoAluno = novoAluno.CadastrarAluno();
                        Turma.Add(novoAluno);
                        break;
                    case 2:
                        foreach(Aluno pessoa in Turma) {
                            Console.WriteLine($"Ra: {pessoa.RA} \nNome: {pessoa.Nome}");
                            for(int i=0; i<pessoa.Nota.Length; i++) {
                                Console.WriteLine($"Nota {i + 1} = {pessoa.Nota[i]}");
                            }
                            Console.WriteLine();
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
