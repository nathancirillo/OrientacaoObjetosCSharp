namespace ListaTwo
{
    class ExeTwo
    {
        static void Main(string [] args)
        {
            Console.Write("Informe um número inteiro: "); 
            int num = int.Parse(Console.ReadLine()); 
            if(num % 2 == 0)
                Console.WriteLine("PAR!");
            else
                Console.WriteLine("ÍMPAR!");
        }
    }
}