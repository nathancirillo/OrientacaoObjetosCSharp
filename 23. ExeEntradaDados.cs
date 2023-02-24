using System; 
using System.Globalization; 
namespace CourseVsCode
{
    class ExeEntradaDados
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine(); 
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Entre com o preço de um produto:");
            decimal precoProduto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' '); 
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

        }
    }
}