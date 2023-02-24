using System.Globalization;

namespace Course
{
    class ExeSaidaDados
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preco é $ {1}", produto1, preco1.ToString("F2"));
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2.ToString("F2")}");
            Console.WriteLine(" ");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genêro: " + genero);
            Console.WriteLine(" ");
            Console.WriteLine("Medida com 8 casas decimais: " + medida.ToString("F8"));
            Console.WriteLine($"Arredondado (3 casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
