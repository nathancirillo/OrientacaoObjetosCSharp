namespace MyClasses
{
    class ProdutoEncapsulamento 
    {
        private string _nome; 
        private int _quantidade; 
        private double _preco; 

        public ProdutoEncapsulamento()
        {

        }

        public ProdutoEncapsulamento(string nome, int quantidade, double preco)
        {
            _nome = nome; 
            _quantidade = quantidade; 
            _preco = preco; 
        }


        public override string ToString()
        {
            return $"Nome = {_nome} - Quantidade = {_quantidade} e Preco - {_preco}.";
        }

        public void AdicionarProdutos(int qtd)
        {
            _quantidade += qtd; 
        }

        public void RemoverProdutos(int qtd)
        {
            _quantidade -= qtd; 
        }

        public double ValorEmEstoque()
        {
            return _quantidade * _preco; 
        }

        public string GetNome()
        {
            return _nome; 
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
                _nome = nome; 
        }

        public int GetQuantidade()
        {
            return _quantidade; 
        }   

        public double GetPreco()
        {
            return _preco;
        }
   }
}