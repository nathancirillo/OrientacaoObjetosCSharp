namespace Course
{
    class ExercicioFixacaoMatrizes
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nº de linhas: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Informe o nº de colunas: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matriz = new int[rows, cols];

            for (int l = 0; l < rows; l++)
            {
                Console.Write($"Informe {cols} itens da linha {l + 1}: ");
                string[] itens = Console.ReadLine().Split(' ');
                if (itens.Length > cols || itens.Length < cols)
                {
                    Console.WriteLine($"Informe exatamente {cols} itens!");
                    l -= 1;
                    continue;
                }
                for (int c = 0; c < itens.Length; c++)
                {
                    matriz[l, c] = int.Parse(itens[c]);
                }
            }
            Console.Write("Informe o nº a ser encontrado: ");
            int num = int.Parse(Console.ReadLine());

            for (int l = 0; l < rows; l++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matriz[l, c] == num)
                    {
                        Console.WriteLine($"Position [{l},{c}]:");
                        if (l > 0)
                            Console.WriteLine($"Up: {matriz[l - 1, c]}");
                        if (l < (rows - 1))
                            Console.WriteLine($"Down: {matriz[l + 1, c]}");
                        if (c > 0)
                            Console.WriteLine($"Left: {matriz[l, c - 1]}");
                        if (c < (cols - 1))
                            Console.WriteLine($"Right: {matriz[l, c + 1]}");
                    }
                }
            }



        }
    }
}