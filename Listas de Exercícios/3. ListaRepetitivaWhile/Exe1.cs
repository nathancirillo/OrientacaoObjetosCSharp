namespace ListaThree
{
    class Exe1
    {
        static void Main(string[]args)
        {
            Console.Write("Informe uma senha numérica: "); 
            int password = int.Parse(Console.ReadLine()); 

            while(password != 2002)
            {
                Console.WriteLine("Senha Inválida!"); 

                 Console.Write("Informe uma senha numérica: "); 
                 password = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Acesso Permitido!");
        }
    }
}