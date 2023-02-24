using System.Globalization;

namespace CourseVsCode
{
    class MembrosEstaticosDois
    {         
        static void Main(string[]args)
        {            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunferencia = CirculoEstatico.Circunferencia(raio);
            double volume = CirculoEstatico.Volume(raio);           
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + CirculoEstatico.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }  
            
    }


    static class CirculoEstatico
    {
        public static double Pi = 3.14; 


        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio; 
        }

        public static double Circunferencia(double raio)
        {
            return 2 * raio * Pi; 
        }

    }

}