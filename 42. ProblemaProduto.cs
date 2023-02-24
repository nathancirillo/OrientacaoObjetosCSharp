using MyClasses;
using System.Globalization; 

namespace CourseVsCode
{
    class ProgramProduto 
    {
        static void Main(string[]args)
        {
            Produto p = new Produto();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p, CultureInfo.InvariantCulture);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicinarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}