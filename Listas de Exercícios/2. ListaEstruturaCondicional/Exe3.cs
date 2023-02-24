namespace ListaTwo
{
    class ExeThree
    {
        static void Main(string[] args)
        {
            Console.Write("Informe dois valores (mesma linha separados por espaço): ");
            string[] valores = Console.ReadLine().Split(' ');
            int num1 = int.Parse(valores[0]); 
            int num2 = int.Parse(valores[1]); 
            string status = string.Empty; 
            if(num1 > num2){
                status = num1 % num2 == 0 ? "São Múltiplos" : "Não são Múltiplos";  
            } else if (num2 > num1) {
                status = num2 % num1 == 0 ? "São Múltiplos" : "Não são Múltiplos";  
            } else {
                status = "São Múltiplos"; 
            }
            Console.WriteLine(status);
        }
    }
}