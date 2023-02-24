namespace ListaOne
{
    class ExeThree
    {
        static void Main(string []args)
        {
            Console.Write("INTEIRO A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("INTEIRO B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("INTEIRO C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("INTEIRO D: ");
            int d = int.Parse(Console.ReadLine());
            int diferenca = a*b - c*d; 
            Console.WriteLine("DIFERENCA = " + diferenca); 
        }
    }
}