using System.Globalization;

namespace ListaTwo
{
    class ExeSeven
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("INFORME A COORDENADA X: ");
            double coordX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("INFORME A COORDENADA Y: ");
            double coordY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(coordX == 0 && coordY == 0)
            {
                Console.WriteLine("Origem!");
            }

            if(coordX > 0 && coordY > 0)
            {
                Console.WriteLine("Q1!");
            }

            if(coordX < 0 && coordY > 0)
            {
                Console.WriteLine("Q2!");
            }

            if(coordX < 0 && coordY < 0)
            {
                Console.WriteLine("Q3!");
            }

            if(coordX > 0 && coordY < 0)
            {
                Console.WriteLine("Q4");
            }
            
        }
    }
}