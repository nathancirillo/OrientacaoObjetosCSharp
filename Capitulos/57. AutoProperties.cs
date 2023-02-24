using MyClasses;

namespace Course
{
    class AutoProperties
    {
        static void Main(string[] args)
        {
            ProdutoComAutoProperties pap = new ProdutoComAutoProperties("TV", 900.50, 2);
            pap.Nome = "T";
            //pap.Preco = 800; 
            //pap.Quantidade = 2; 
            Console.WriteLine(pap);
        }
    }
}