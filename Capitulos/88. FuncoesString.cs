namespace Course
{
    class FuncoesString
    {
        static void Main(string[] args)
        {
            string original = "abc DEF ghi JKL mno PQR aDgJmP   ";
            string maiuscula = original.ToUpper();
            string minuscula = original.ToLower();
            string semEspaco = original.Trim();
            int primeiraPosicao = original.IndexOf('a');
            int ultimaPosicao = original.LastIndexOf('a');
            int posicaoString = original.IndexOf("gh");
            string pedacoString = original.Substring(4);
            string outroPedaco = original.Substring(4, 3);
            string replaceChar = original.Replace('a', 'X');
            string replaceStr = original.Replace("PQR", "AVC");
            bool stringNulaVazia = string.IsNullOrEmpty(original);
            bool stringNulaBranco = string.IsNullOrWhiteSpace(original);
            stringNulaBranco = string.IsNullOrWhiteSpace("     ");

            Console.WriteLine($"Original = -{original}-");
            Console.WriteLine($"Maiúscula = -{maiuscula}-");
            Console.WriteLine($"Minúscula = -{minuscula}-");
            Console.WriteLine($"Sem espaço = -{semEspaco}-");
            Console.WriteLine($"Primeira posição de 'a' = {primeiraPosicao}");
            Console.WriteLine($"Última posição de 'a' = {ultimaPosicao}");
            Console.WriteLine($"Posição da string 'gh' = {posicaoString}");
            Console.WriteLine($"Pedaço de uma string = -{pedacoString}-");
            Console.WriteLine($"Outro pedaço de uma string = -{outroPedaco}-");
            Console.WriteLine($"Substituir caractere = -{replaceChar}-");
            Console.WriteLine($"Substituir string = -{replaceStr}-");
            Console.WriteLine($"IsNullOrEmpty = {stringNulaVazia}");
            Console.WriteLine($"IsNullOrWhiteSpace = {stringNulaBranco}");

        }
    }
}