namespace ListaFour
{
    class Exe2
    {
        static void Main(string[]args)
        {
            System.Console.Write("Quantidade de valores lidos: ");
            int num = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0; 

            for(int i = 1; i <= num; i++){
                Console.Write("Informe o {0} número: ", i);
                int val = int.Parse(Console.ReadLine());
                if(val >=10 && val <= 20)
                    dentro++; 
                else 
                    fora++; 
            }
            Console.WriteLine("{0} in", dentro); 
            Console.WriteLine("{0} out", fora);
        }
    }
}