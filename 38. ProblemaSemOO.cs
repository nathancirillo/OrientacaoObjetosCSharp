using System.Globalization; 

namespace CourseVsCode
{
    class ProblemaSemOO
    {
        static void Main(string[]args)
        {
            double xA, xB, xC, yA, yB, yC; 

            Console.WriteLine("Digite os lados do triângulo X: "); 
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.WriteLine("Digite os lados do triângulo Y: "); 
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 


            double pX = (xA + xB + xC) / 2.0; 
            double pY = (yA + yB + yC) / 2.0; 


            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC)); 
            double areaY= Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC)); 

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