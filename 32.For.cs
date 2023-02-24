namespace CourseVsCode
{
    class ForExample
    {
        static void Main(string[]args)
        {
            Console.Write("Quantos números deseja informar? ");
            int quantity = int.Parse(Console.ReadLine());
            int total = 0; 
            for(int i=0; i < quantity; i++)
            {
                Console.Write($"Informe o {i+1} número: "); 
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total = " + total);
        }
    }
}