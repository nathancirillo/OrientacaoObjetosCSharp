using System.Globalization; 

namespace ListaOne
{
    class ExeFour
    {
        static void Main(string[] args)
        {
            Console.Write("INFORME O Nº DO FUNCIONARIO: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("INFORME O Nº DE HORAS TRABALHADAS: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("INFORME O VALOR DA HORA: "); 
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valor; 
            Console.WriteLine($"FUNCINÁRIO Nº: {num}."); 
            Console.WriteLine($"SALÁRIO: R$ {salario:F2}.", CultureInfo.InvariantCulture);  
        }
    }
}