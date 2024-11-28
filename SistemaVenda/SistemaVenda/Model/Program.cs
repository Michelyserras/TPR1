using SistemaVenda.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente c1 = new Cliente("Mi", 22, 123456);
        c1.exibirCliente();
    }
}