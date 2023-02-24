using  System.Globalization; 

namespace MyClasses
{
    class ProdutoComAutoProperties
    {
        private string _nome; 
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public ProdutoComAutoProperties(string nome, double preco, int quantidade){
            _nome = nome; 
            Preco = preco; 
            Quantidade = quantidade; 
        }

        //Nesse caso não uso autoproperty, pois existe lógica particular
        public string Nome
        {
            get{ return _nome; }
            set
            {
                if(value.Length > 1)
                    _nome = value; 
            }
        }

        private double ObterTotal()
        {
            return Preco * Quantidade; 
        }

        public override string ToString()
        {
            return $"Nome = {_nome} | Preco = {Preco} | Quantidade = {Quantidade} | Total = {ObterTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}