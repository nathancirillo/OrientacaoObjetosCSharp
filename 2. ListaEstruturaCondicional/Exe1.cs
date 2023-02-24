using System; 
namespace ListaTwo
{
    class ExeOne {
        static void Main(string[]args)
        {
            Console.Write("INFORME UM NÚMERO INTEIRO: ");
            int num = int.Parse(Console.ReadLine()); 
            if(num < 0)
                Console.WriteLine("NEGATIVO"); 
            else
                Console.WriteLine("POSITIVO");
        }
    }
}