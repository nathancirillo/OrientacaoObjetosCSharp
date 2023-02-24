namespace ListaFour
{
    class Exe5
    {
        static void Main(string[]args)
        {
            Console.Write("Valor para calcular o fatorial: ");
            int val = int.Parse(Console.ReadLine());
            int fat = Fatorial(val);
            Console.WriteLine($"Fatorial de {val} é {fat}.");
        }


        static int Fatorial(int num)
        {
            int fat; 
            
            for(fat = 1; num > 1; num--){
                 fat = fat * num;    
            }

            return fat;
        }
    }
}