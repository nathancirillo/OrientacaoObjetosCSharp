using System.Globalization;

namespace CourseVsCode
{
    class MembrosDeInstancia
    {
        static void Main(string[]args)
        {
            Circulo circ = new Circulo();
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunferencia = circ.Circunferencia(raio);
            double volume = circ.Volume(raio);           
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + circ.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Circulo
    {
        public double Pi = 3.14; 

        public double Circunferencia(double r){
            return 2 * r * Pi; 
        }

        public double Volume(double r){
            return 4.0 / 3.0 * Pi * r * r * r; 
        }
    }


}