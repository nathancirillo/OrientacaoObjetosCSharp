namespace ListaTwo
{
    class ExeFive
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o ID do produto: "); 
            int id = int.Parse(Console.ReadLine());
            double valorProduto = 0.0; 
            switch(id)
            {
                case 1: 
                    valorProduto = 4.00; 
                    break; 
                case 2: 
                    valorProduto = 4.50; 
                    break; 
                case 3: 
                    valorProduto = 5.00; 
                    break; 
                case 4: 
                    valorProduto = 2.00; 
                    break; 
                case 5: 
                    valorProduto = 1.50; 
                    break; 
            }
            
            if(valorProduto == 0.0){
                Console.WriteLine("Produto não encontrado na base!");
            } else {
                Console.Write("Informe a quantidade: "); 
                int qtd = int.Parse(Console.ReadLine());
                if(qtd <= 0)
                    Console.WriteLine("Quantidade informada inválida!"); 
                else {
                    double valorPago = valorProduto * qtd; 
                    Console.WriteLine($"Total: R$ {valorPago}"); 
                } 
            }

        }
    }
}