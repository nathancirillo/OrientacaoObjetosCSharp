using System.Globalization;
using MyClasses;
namespace Course
{
    class Construtores
    {
        static void Main(string[] args)
        {
            ProdutoComConstrutor prod = new ProdutoComConstrutor("TV", 900.0);
            Console.WriteLine("Produto Atual:\n" + prod);

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preco do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ProdutoComConstrutor novoProd = new ProdutoComConstrutor(nome, preco, quantidade);
            Console.WriteLine("Novo Produto:\n" + novoProd);

            Console.Write("Adicionar itens aos novos produtos: ");
            novoProd.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Novo Produto Atualizado:\n" + novoProd);

            Console.Write("Remover itens dos novos produtos: ");
            novoProd.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Novo Produto Atualizado:\n" + novoProd);


            ProdutoComConstrutor outroProd = new ProdutoComConstrutor
            {
                Nome = "Teste",
                Preco = 23,
                Quantidade = 10
            };

            Console.WriteLine(outroProd);
        }
    }
}