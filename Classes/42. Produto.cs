using System.Globalization;

namespace MyClasses
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;      

        public void AdicinarProdutos(int num)
        {
            Quantidade += num; 
        } 

        public void RemoverProdutos(int num)
        {
            Quantidade -= num; 
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}