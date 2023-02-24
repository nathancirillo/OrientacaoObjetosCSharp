namespace ListaFour
{
    class Exe4
    {
        static void Main(string[]args)
        {
            Console.Write("Nº de divisões: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=1; i<= num; i++)
            {
                Console.Write("Informe dois valores (separados por espaço): ");
                string[] values = Console.ReadLine().Split(" "); 
                if(double.Parse(values[1]) == 0.0)
                {
                    Console.WriteLine("Divisão impossível!");
                    break;
                }
                else
                    Console.WriteLine(double.Parse(values[0]) / double.Parse(values[1]));
            }
        }
    }
}