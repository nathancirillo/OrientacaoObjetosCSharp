using System.Globalization;

namespace Course
{
    class EntradaDados
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int inteiro = int.Parse(Console.ReadLine());
            Console.Write("Digite um número real: ");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite um caractere:");
            char caractere = char.Parse(Console.ReadLine());
            Console.Write("Digite seu nome, sexo e idade separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string sexo = vet[1];
            int idade = int.Parse(vet[2]);
            Console.WriteLine("--- VALORES INFORMADOS ---");
            Console.WriteLine(inteiro);
            Console.WriteLine(real.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(caractere);
            Console.WriteLine($"{nome} - {idade} - {sexo}");

        }
    }
}