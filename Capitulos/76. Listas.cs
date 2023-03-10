namespace Course
{
    class DeclaracaoListas
    {
        public static void Main(string[]args)
        {
            //inicialização tradicional estando vazia: 
            List<string> lista = new List<string>();

            //inicialização já informando os valores direto: 
            List<string> nomes = new List<string>{"Nathan", "Vanessa", "Ana", "Pedro"};

            //apresentando os valores via foreach 
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }



            /* Observações:
                -> São estruturas homogeneas de dados; 
                -> Cada posição possui um valor e uma referência para o próximo elemento; 
                -> É possível adicionar quantos elementos quiser em uma lista, diferente do vetor; 
                -> É muito prático inserir e remover endereços; 
                -> Desvantagem: possui acesso sequencial aos elementos (encadeadas). É necessário percorrer nodo a nodo;
                -> Os vetores acaba sendo mais rápido na questão de acesso. 
            */ 
            
        }

    }
}