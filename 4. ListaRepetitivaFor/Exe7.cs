namespace ListaFour
{
    class Exe7
    {
        static void Main(string[]args)
        {
            Console.Write("Informe um valor numérico inteiro: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}"); 
            }
        }
    }
}