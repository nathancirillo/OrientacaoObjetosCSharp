namespace Course
{
    class ManipulandoListas
    {
        public static void Main(string[]args)
        {
            //criando uma lista: 
            List<string> nomes = new List<string>(); 

            //adicionando elemento a lista com Add(): 
            nomes.Add("Nathan");
            nomes.Add("Vanessa");
            nomes.Add("Adriano");

            //também podemos inserir via Insert() especificando a posição desejada:
            nomes.Insert(0, "Ana"); 
            nomes.Insert(1, "Pedro"); 

            Console.WriteLine("-------------------");
            //apresentando os dados: 
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");

            //conhecendo o tamanho de uma lista: 
            Console.WriteLine($"Tamanho da lista = {nomes.Count()}");

           
            /* encontrar o primeiro ou o último elemento de uma lista que satisfaça um predicado.
               um predicado é uma função (lambda) que pega um valor e retorna verdadeiro ou falso conforme sua lógica. 
               é interessante saber que poderiamos usar uma função para isso também, mas via lambda é mais fácil.
            */
            //lambda:
            Console.WriteLine("Primeiro nome com A: " + nomes.Find(s =>  s[0] == 'A'));

            //função:
            Console.WriteLine("Primeiro nome com A: " + nomes.Find(SearchName));

            //buscando o último nome que começa com a letra A: 
            Console.WriteLine("Último nome com  A: " + nomes.FindLast(s => s[0] == 'A'));

            //encontrar o primeiro índice da lista que satisfaça um predicado: 
            Console.WriteLine("Primeiro índice com A: " + nomes.FindIndex(s => s[0] == 'A'));     


            //encontrar o último índice da lista que satisfaça um predicado: 
            Console.WriteLine("Último índice com A: " + nomes.FindLastIndex(s => s[0] == 'A'));


            /*filtrar a lista com base em um predicado, ou seja, criar uma nova lista apenas
            Comparer os elementos que satisfaçam o predicado:
            */ 
            Console.WriteLine("-------------------");
            List<string> novaLista = nomes.FindAll(s => s.Length == 7);
            foreach(var nome in novaLista)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");

            //removendo elementos de uma lista através dos métodos: Remove, RemoveAll, RemoveAt e RemoveRange
            Console.WriteLine("-------------------");
            nomes.Remove("Adriano");
            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");

          
            Console.WriteLine("-------------------");
            nomes.RemoveAll(s => s[0] == 'P'); 
            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");


            Console.WriteLine("-------------------");
            nomes.RemoveAt(0); 
            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");
            nomes.RemoveRange(1,1); 
            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-------------------");


        }

        static bool SearchName(string nome)
        {
            return nome[0] == 'A';
        }
    }
}