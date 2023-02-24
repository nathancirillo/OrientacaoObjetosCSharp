using System.Globalization; 

namespace ListaOne
{
    class ExeFive
    {
        static void Main(string[]args)
        {
            Console.Write("PEÇA 1 - CÓDIGO, Nº E VALOR (separados por espaço): ");
            string[] dadosP1 = Console.ReadLine().Split(' '); 
            Console.Write("PEÇA 2 - CÓDIGO, Nº E VALOR (separados por espaço): "); 
            string[] dadosP2 = Console.ReadLine().Split(' ');
            double totalP1 = double.Parse(dadosP1[1], CultureInfo.InvariantCulture) * double.Parse(dadosP1[2], CultureInfo.InvariantCulture);  
            double totalP2 = double.Parse(dadosP2[1], CultureInfo.InvariantCulture) * double.Parse(dadosP2[2], CultureInfo.InvariantCulture); 
            Console.WriteLine($"VALOR A PAGAR: R$ {(totalP1 + totalP2):F2}", CultureInfo.InvariantCulture); 
        }
    }
}