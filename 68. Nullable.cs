namespace CourseVsCode
{
    public class NullableExample
    {
        public static void Main(string[]args)
        {
            //forma de declarar um valor como sendo nulo 
            Nullable<double> x = null;
            double? y = null;
            double? z = 15.2; 

            //métodos que operam sobre itens nullable 
            Console.WriteLine($"GetValueOrDefault = {y.GetValueOrDefault()}");
            Console.WriteLine($"GetValueOrDefault = {z.GetValueOrDefault()}");

            Console.WriteLine($"HasValue = {y.HasValue}"); 
            Console.WriteLine($"HasValue = {z.HasValue}");

            if(y.HasValue)
                Console.WriteLine($"Value = {y.Value}");
            else
                Console.WriteLine($"y is null!");                
            Console.WriteLine($"Value = {z.Value}"); 


            //operador de coalescência: teste e atribui outro valor caso o da direita seja nulo
            double? a = null; 
            double b = a ?? 15; 
            Console.WriteLine($"Valor de b = {b}");

        }
    }
}