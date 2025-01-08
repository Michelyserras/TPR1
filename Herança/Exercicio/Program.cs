using Exercicio;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaPoupanca c1 = new ContaPoupanca(1001, 0001, 10, "Michely");
        ContaCorrente c2 = new ContaCorrente(1002, 0002, 4000.2, "Fernando");

        Console.WriteLine("Conta Poupança : ");
        Console.WriteLine("\tTitular: {0}", c1.Titular);
        Console.WriteLine("\tAgencia: {0}", c1.Agencia);
        Console.WriteLine("\tConta: {0}", c1.Conta);
        Console.WriteLine("\tSaldo: {0:c}", c1.Saldo);
        c1.creditar(1000);
        Console.WriteLine("\tSaldo atual após acrescentar valor:  {0:c}", c1.Saldo);

       
        Console.WriteLine("\n\n Conta Corrente : ");
        Console.WriteLine("\tTitular: {0}", c2.Titular);
        Console.WriteLine("\tAgencia: {0}", c2.Agencia);
        Console.WriteLine("\tConta: {0}", c2.Conta);
        Console.WriteLine("\tSaldo: {0:c}", c2.Saldo);
        c2.debitar(100);
        Console.WriteLine("\tSaldo atual após debitar valor:  {0:c}", c2.Saldo);

    }
}