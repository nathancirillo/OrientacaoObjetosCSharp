namespace ListaFour
{
    class Exe6
    {
        static void Main(string[]args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            for(int x = 1; x <= num; x++)
            {
                if(num % x == 0)
                    Console.WriteLine($"{x} é divisor.");
            }
        }
    }
}