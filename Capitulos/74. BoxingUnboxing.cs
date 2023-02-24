namespace Course
{
    class BoxingUnboxing
    {
        public static void Main(string[]args)
        {
            //Boxing: processo de converter um tipo de valor para um de referência
            int x = 50; 
            Object obj = x; 
            
            //Unboxing processo de converter um tipo de referência para um de valor compatível 
            int y = (int)obj; 

            System.Console.WriteLine(y);
        }
    }
}