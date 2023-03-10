namespace Course
{
    public class ExercicioMatriz
    {
        public static void Main(string[]args)
        {
            Console.Write("Tamanho da matriz quadrada: ");
            int tam = int.Parse(Console.ReadLine()); 
            if(tam < 2){
                Console.WriteLine("Tamanho inválido para matriz!");
                return;  
            }
            int totalImpar = 0, somaDiagonal =0; 
            int[,] numeros = new int[tam, tam];
            for(int l=0; l < tam; l++)
            {
                for(int c=0; c < tam; c++)
                {
                    Console.Write($"[{l+1},{c+1}] = ");
                    int valor = int.Parse(Console.ReadLine()); 
                    numeros[l,c] = valor; 
                    if(l == c)
                        somaDiagonal += numeros[l,c];
                    if(numeros[l,c] < 0)
                        totalImpar += 1; 
                }
            }

            Console.WriteLine($"Soma da diagonal principal = {somaDiagonal}."); 
            Console.WriteLine($"Total de números impares = {totalImpar}."); 

        }
    }
}