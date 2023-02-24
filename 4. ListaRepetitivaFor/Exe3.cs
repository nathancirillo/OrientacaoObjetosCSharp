using System.Globalization;

namespace ListaFour
{
    class Exe3
    {
        static void Main(string[]args)
        {
            Console.Write("Quantos casos de teste você deseja? ");
            int quantity = int.Parse(Console.ReadLine());
            decimal[] allAverages = new decimal[quantity]; 

            for(int i=0; i<quantity;i++)
            {
                Console.Write("Informe três números (separados por espaço): ");
                string[] numbers = Console.ReadLine().Split(" ");
                allAverages[i] = ((decimal.Parse(numbers[0],CultureInfo.InvariantCulture)* 0.2m) + 
                                  (decimal.Parse(numbers[1], CultureInfo.InvariantCulture)* 0.3m) + 
                                  (decimal.Parse(numbers[2], CultureInfo.InvariantCulture)* 0.5m));
            }

            Console.WriteLine("Médias: "); 
            for(int i=0;i<allAverages.Count();i++)
            {
                Console.WriteLine(allAverages[i].ToString("F1"));
            }
        }
    }
}