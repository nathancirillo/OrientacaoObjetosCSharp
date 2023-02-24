using System.Globalization; 

namespace ListaSeven
{
    class ExeMembrosEstaticos 
    {
        static void Main(string[]args)
        {
                
                Console.Write("Qual é a cotação do dólar? ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantos dólares você vai comprar? ");
                double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double total = ConversorDeMoeda.ConverterMoeda(cotacao, qtdDolar); 
                Console.WriteLine($"Valor a ser pago em reais = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}.");

        }
    }

}