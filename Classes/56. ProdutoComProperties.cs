namespace MyClasses
{
    class ProdutoComProperties
    {
        private string _nome; 
        private double _preco; 
        private int _quantidade; 

        public ProdutoComProperties(string nome, double preco, int quantidade)
        {
            _nome = nome; 
            _preco = preco; 
            _quantidade = quantidade; 
        }

        public string Nome 
        {
            get {return _nome;}
            set {_nome = value;}
        }

        public double Preco 
        {
            get {return _preco;}
        }

        public int Quantidade 
        {
            get {return _quantidade; }
        }

        public override string ToString()
        {
            return $"Nome = {Nome} | Quantidade = {Quantidade} | Preco = {Preco}.";
        }
    }
}