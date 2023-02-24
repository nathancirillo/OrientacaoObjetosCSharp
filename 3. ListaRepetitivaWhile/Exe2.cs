namespace ListaThree
{
    class Exe2
    {
        static void Main(string[]args)
        {
            Console.Write("Informe a coordenada X: "); 
            int coordX = int.Parse(Console.ReadLine()); 
            Console.Write("Informe a coordenada Y: ");
            int coordY = int.Parse(Console.ReadLine());

            while(coordX != 0 && coordY != 0)
            {
                if(coordX > 0 && coordY > 0){
                    Console.WriteLine("Primeiro!");
                } else if(coordX > 0 && coordY < 0){
                    Console.WriteLine("Quarto"); 
                } else if(coordX < 0 && coordY < 0){
                    Console.WriteLine("Terceiro");
                } else {
                    Console.WriteLine("Segundo");
                }

                Console.Write("Informe a coordenada X: "); 
                coordX = int.Parse(Console.ReadLine()); 
                Console.Write("Informe a coordenada Y: ");
                coordY = int.Parse(Console.ReadLine());
                
            }

        }
    }
}