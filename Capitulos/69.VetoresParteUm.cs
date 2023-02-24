using System.Globalization;

namespace Course
{
    public class VetoresParteUm
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o nº de pessoas: ");
            int num = int.Parse(Console.ReadLine());

            double[] alturas = new double[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Informe a altura {i + 1}:", CultureInfo.InvariantCulture);
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            double totalAlturas = 0.0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(alturas[i].ToString("F2"), CultureInfo.InvariantCulture);
                totalAlturas += alturas[i];
            }

            Console.WriteLine($"A média das alturas é: {(totalAlturas / num).ToString("F2", CultureInfo.InvariantCulture)}");





        }
    }
}