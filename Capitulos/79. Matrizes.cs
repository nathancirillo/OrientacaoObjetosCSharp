namespace Course
{
    public class ExemploMatrizes
    {
        public static void Main(string[]args)
        {
            //como declarar uma matriz de duas dimensões
            string[,] nomes = new string[2,3]; 

            //pegar o número total de posições validas da matriz
            int totalPosicoes = nomes.Length; 
            System.Console.WriteLine("Posições Válidas = " + totalPosicoes);

            //pegar o tamanho da primeira dimensão (número de linhas)
            int numLinhas = nomes.Rank; 
            System.Console.WriteLine("Número de linhas = " + numLinhas);

            //pegar o tamanho separado de cada dimensão linha ou coluna
            int totLinhas = nomes.GetLength(0); 
            int totColunas = nomes.GetLength(1); 
            System.Console.WriteLine("Total linhas = " + totLinhas);
            System.Console.WriteLine("Total colunas = " + totColunas);

        }
    }
}