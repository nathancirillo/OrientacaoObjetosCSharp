using System.Globalization; 

namespace ListaTwo
{
    class ExeSix
    {
        public static void Main(string[]args)
        {
           System.Console.Write("Informe um valor numérico entre 0 e 100: ");
           double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           if(value < 0 || value > 100)
           {
                System.Console.WriteLine("Valor Inválido. Deve estar entre 0 e 100.");
                return; 
           }

           if(value <= 25)
           {
                System.Console.WriteLine("Intervalo [0,25].");
           }
           else if(value <= 50)
           {
                System.Console.WriteLine("Intervalo [25,50].");
           }
           else if(value <= 75)
           {
                System.Console.WriteLine("Intervalo [50,75].");
           }
           else
           {
                System.Console.WriteLine("Intervalo [75,100].");
           }

        }
    }
}