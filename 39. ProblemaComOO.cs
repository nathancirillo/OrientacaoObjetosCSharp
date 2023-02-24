using MyClasses; 
using System.Globalization;
namespace CourseVsCode
{
    class ProblemaComOO
    {
        static void Main(string[]args)
        {
            Triangulo x, y; 
            x = new Triangulo();
            y = new Triangulo();
                
            Console.WriteLine("Digite os lados do triângulo X: "); 
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.WriteLine("Digite os lados do triângulo Y: "); 
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 


            double areaX = x.Area(); 
            double areaY= y.Area(); 

            Console.WriteLine($"Área de X: " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine($"Área de Y: " + areaY.ToString("F4"), CultureInfo.InvariantCulture);    

            if(areaX > areaY)
                Console.WriteLine("Área de X é Maior!");
            else if (areaX < areaY)
                Console.WriteLine("Área de Y é Maior!");
            else
                Console.WriteLine("As áreas são iguais!");

        }
    }
}