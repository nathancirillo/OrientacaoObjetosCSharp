using MyClasses;
namespace CourseVsCode
{
    class Encapsulamento 
    {
        static void Main(string[]args)
        {
            ProdutoEncapsulamento pe = new ProdutoEncapsulamento("FOGÃO",10,123.23); 
            pe.SetNome("A");         
            Console.WriteLine(pe.GetNome());
        }
    }
}