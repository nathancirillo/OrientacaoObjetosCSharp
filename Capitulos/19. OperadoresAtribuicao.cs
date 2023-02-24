namespace Course
{
    class OperadoresAtribuicao
    {
        static void Main(string[] args)
        {
            int valor = 30;
            Console.WriteLine(valor);

            valor += 2;
            Console.WriteLine(valor);

            valor -= 3;
            Console.WriteLine(valor);

            int newValor = valor++;
            Console.WriteLine("newValor: " + newValor);
            Console.WriteLine("valor: " + valor);

            newValor = ++valor;
            Console.WriteLine("newValor: " + newValor);
            Console.WriteLine("valor: " + valor);
        }
    }
}