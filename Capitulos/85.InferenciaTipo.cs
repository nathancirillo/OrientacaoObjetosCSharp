namespace Course
{
    class InferenciaTipo
    {
        static void Main(string[] args)
        {
            /*O próprio compilador se encarrega de identificar o tipo de dado. 
              Ocorre problema, pois nada impede do programador errar o tipo de dado. 
              Por exemplo, passar uma string pra um tipo de dado que deveria ser inteiro. 
            */
            var x = 15;
            var y = "Maria";
            var z = 20.0;

        }
    }
}