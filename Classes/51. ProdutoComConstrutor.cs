using System.Globalization; 
namespace MyClasses
{
    class ProdutoComConstrutor
    {
        public string Nome; 
        public double Preco; 
        public int Quantidade;       

        public ProdutoComConstrutor()
        {
            Quantidade = 15;       
        }

        public ProdutoComConstrutor(string nome, double preco, int quantidade) : this(nome,preco)
        {         
            Quantidade = quantidade; 
        }


        public ProdutoComConstrutor(string nome, double preco): this()
        {
            Nome = nome; 
            Preco = preco;           
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd; 
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd; 
        }    


        public double ValorEmEstoque()
        {
            return Preco * Quantidade; 
        }

        public override string ToString()
        {
            return $"Nome = {Nome}, Quantidade = {Quantidade.ToString("F2",CultureInfo.InvariantCulture)}, Preço = R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} e Total = R$ {ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}.";
        }           

    }
}