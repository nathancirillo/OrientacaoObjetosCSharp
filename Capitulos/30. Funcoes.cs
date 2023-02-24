namespace Course
{
    class Funcoes
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o N1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o N2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o N3: ");
            int n3 = int.Parse(Console.ReadLine());
            int maior = Maior(n1, n2, n3);
            System.Console.WriteLine($"O maior número informado é: {maior}");
        }

        static int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c)
                return b;
            else
                return c;
        }
    }
}