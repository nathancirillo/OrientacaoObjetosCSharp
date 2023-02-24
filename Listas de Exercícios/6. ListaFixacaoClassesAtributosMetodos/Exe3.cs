using System.Globalization; 

namespace ListaSix
{
    class Exe3
    {
        static void Main(string[]args)
        {
            Aluno a = new Aluno(); 
            
            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.ObterNotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            a.DefinirStatus();
        }
    }
}