using Polimorfismo;

internal class Program {
    private static void Main(string[] args) {
        int id = 0, op = 0;

        Televisao televisao = new Televisao(1, "Smart", "Samsung", 2000.0, "4K", "40 polegadas");
        Guitarra guitarra = new Guitarra(2,"Eletrica", "Tagima", 2000.0, "azul", 12);
        Notebook note = new Notebook(3, "notebook gamer", "dell", 5000.0, "Windows", "AMD", "256gb");
      

        CestaDeProdutos cesta = new CestaDeProdutos();


        do {
            op = menu();
            switch (op) {
                case 1:
                    Console.WriteLine("Produtos cadastrados: ");
                    ExibirProdutos(televisao, guitarra, note);

                    Console.WriteLine("\n Informe o id do produto que será inserido na cesta de compras: ");
                    id = int.Parse(Console.ReadLine());

                    if (id == 1) {
                        cesta.AdicionarProduto(new Televisao(televisao.id, televisao.tipo, televisao.marca, televisao.preco, televisao.resolucao, televisao.tamanhoDaTela));
                    }
                    if(id == 2) {
                        
                        cesta.AdicionarProduto(new Guitarra(guitarra.id,guitarra.tipo, guitarra.marca, guitarra.preco, guitarra.cor, guitarra.qtdDeCordas));
                    }
                    if(id == 3) {
                        cesta.AdicionarProduto(new Notebook(note.id, note.tipo, note.marca, note.preco, note.sistemaOp, note.processador, note.capArmazenamento));
                    }
                    break;
                case 2:
                    Console.WriteLine("Valores Reajustados ");
                    ReajustarValor(televisao, guitarra, note);
                    ExibirProdutos(televisao, guitarra, note);
                    
                    break;
                case 3:
                    cesta.ExibirItens();
                    break;
                case 4:
                    Console.WriteLine("Total da Compra: {0:c}", cesta.CalcularTotal());
                    break;
                default:
                    break;
            }
   
        } while (op != 5);
    }

    public static void ReajustarValor(Televisao tv, Guitarra g, Notebook note) {
        tv.reajustarPreco();
        g.reajustarPreco();
        note.reajustarPreco();
    }

    public static void ExibirProdutos(Televisao tv, Guitarra g, Notebook note) {
        tv.exibirProduto();
        Console.WriteLine(" ");
        g.exibirProduto();
        Console.WriteLine(" ");
        note.exibirProduto();
    }
    public static int menu() {
        Console.WriteLine("Informe uma opção: \n\t [1] - Incluir um dos Produtos na lista \n\t [2] - Reajustar preço de todos os produtos  \n\t [3] - Exibir cesta de produtos \n\t [4] - Exibir total da compra \n\t [5] - Sair ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }
}