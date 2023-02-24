using System.Globalization; 

namespace ListaOne
{
    class ExeTwo
    {
        static void Main(string[]args)
        {
            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI * Math.Pow(raio,2);
            Console.WriteLine("Valor da área: {0}", area.ToString("F4"), CultureInfo.InvariantCulture); 
        }
    }
}