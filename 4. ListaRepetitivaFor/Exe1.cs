namespace ListaFour
{
    class Exe1
    {
        static void Main(string[]args)
        {
            System.Console.Write("Informe o valor final: ");
            int finalValue = int.Parse(Console.ReadLine());

            for(int x = 1; x <= finalValue; x++){
                if(x % 2 != 0)
                    System.Console.WriteLine(x);
            }
        }
    }
}