using System.Globalization; 

namespace ListaSix
{
    class Exe2
    {
        static void Main(string []args)
        {
            Funcionario c; 
            c = new Funcionario(); 

            Console.Write("Nome: ");
            c.Nome = Console.ReadLine(); 
            Console.Write("Salário Bruto: ");
            c.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            c.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + c);
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            c.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: " + c);


        }
    }
}