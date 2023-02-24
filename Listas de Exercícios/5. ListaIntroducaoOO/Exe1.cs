using MyClasses;

namespace ListaFive
{
    class Exe1 
    {
        static void Main(string[]args)
        {
            Pessoa p1, p2; 
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.Write("Informe o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe a idade da primeira pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe a idade da segunda pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
                System.Console.WriteLine($"{p1.Nome} é mais velho(a).");
            else if(p1.Idade < p2.Idade)
                System.Console.WriteLine($"{p2.Nome} é mais velho(a).");
            else
                System.Console.WriteLine($"{p1.Nome} e {p2.Nome} possuem a mesma idade.");
        }
    }
}