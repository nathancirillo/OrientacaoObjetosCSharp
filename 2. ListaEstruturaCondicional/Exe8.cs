using System.Globalization;
namespace ListaTwo
{
    class ExeEight
    {
        public static void Main(string[]args)
        {
            Console.Write("INFORME O SALÁRIO: ");
            decimal salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal fee = 0; 

            if(salary < 0)
            {
                Console.WriteLine("Valor de salário inválido!");
                return;
            }

            if(salary <= 2000)
            {
                Console.WriteLine("ISENTO!");
            }
            else if(salary <= 3000)
            {  
               fee = salary * 0.08m;                       
            }
            else if(salary <= 4500)
            {
                 fee = salary * 0.18m;                  
            }
            else
            {
                 fee = salary * 0.28m;  
            }

            Console.WriteLine($"Imposto = R$ {fee.ToString("F2")}");


        }
    }
}