using System.Globalization;
namespace ListaSix
{
    class Exe1 
    {
        static void Main(string[]args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(r);
        }
    }
}