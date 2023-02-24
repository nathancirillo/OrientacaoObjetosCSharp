namespace Course
{
    class WhileExample
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine($"Raiz de {num} é {raiz}.");

                Console.Write("Informe um número: ");
                num = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Programa finalzado. Número negativo!");
        }
    }
}