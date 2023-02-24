using MyClasses;
using System.Globalization;

namespace ListaFive
{
    class Exe2
    {
        static void Main(string[]args)
        {
            Funcionario f1, f2; 
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Informe o salário do funcionário: ");
            f1.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o nome do segundo funcionário: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Informe o salário do segundo funcionário: ");
            f2.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio = {((f1.Salario + f2.Salario)/2).ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}