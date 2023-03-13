using System.Globalization;
namespace Course
{
    class OperadorTernario
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor em reais: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (valor < 20.0) ? valor * 0.1 : valor * 0.05;
            Console.WriteLine($"Valor = {valor} - Desconto = {desconto}.");
        }
    }
}