namespace Course
{
    class SaidaDados
    {
        static void Main(string[] args)
        {
            string nome = "Nathan";
            int idade = 32;
            double saldo = 234.3234;

            //usando placeholder
            Console.WriteLine("{0} tem {1} anos e saldo = {2:F2} reais", nome, idade, saldo);

            //usando interpolação versão 6 do C#
            Console.WriteLine($"{nome} tem {idade} anos e saldo = {saldo:F2} reais");

            //usando concateção 
            Console.WriteLine(nome + " possui " + idade + " anos e saldo = " + saldo.ToString("F2") + " reais");

        }
    }
}
