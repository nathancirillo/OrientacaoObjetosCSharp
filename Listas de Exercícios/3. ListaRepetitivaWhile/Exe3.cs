namespace ListaThree
{
    class Exe3
    {
        static void Main(string[]args)
        {
            Console.WriteLine("[1] - Alcool"); 
            Console.WriteLine("[2] - Gasolina"); 
            Console.WriteLine("[3] - Diesel");
            Console.WriteLine("[4] - Fim");
            Console.Write("O que deseja abastecer? ");
            int option = int.Parse(Console.ReadLine()); 
            int alcool = 0, gasolina = 0, diesel = 0;


            

            while(option >=1 && option <=3) {
                if(option == 1)
                    alcool++; 
                else if(option == 2)
                    gasolina++;
                else 
                    diesel++;

                Console.WriteLine("[1] - Alcool"); 
                Console.WriteLine("[2] - Gasolina"); 
                Console.WriteLine("[3] - Diesel");
                Console.WriteLine("[4] - Fim");
                Console.Write("O que deseja abastecer? ");
                option = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}