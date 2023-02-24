namespace ListaOne
{
    class ExeOne
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: "); 
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2; 
            Console.WriteLine($"SOMA = {soma}."); 
        }
    }

}