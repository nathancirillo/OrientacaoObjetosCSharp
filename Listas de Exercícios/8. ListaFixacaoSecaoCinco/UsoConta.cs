using System.Globalization; 

namespace ListaFixacaoSecaoCinco
{
    class UsoConta
    {
        static void Main(string[]args)
        {
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: "); 
            string titular = Console.ReadLine(); 

            Console.Write("Haverá depósito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            double valorInicial = 0.0; 
            if(op == 's' || op == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: "); 
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta c = new Conta(numConta,titular,valorInicial); 
            

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c); 

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)); 
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);


            Console.WriteLine(); 
            Console.Write("Entre um valor para saque: ");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)); 
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);   
        }
    }
}