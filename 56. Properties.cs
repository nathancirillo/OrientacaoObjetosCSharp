using MyClasses; 
namespace CourseVsCode
{
    class Properties
    {
        static void Main(string[]args)
        {
            ProdutoComProperties pp = new ProdutoComProperties("TV",923.23,10);
            Console.WriteLine(pp); 
            pp.Nome = "teste";          
        }
    }
}