using System.Globalization; 

namespace ListaOne
{
    class ExeSix
    {
        static void Main(string []args)
        {
            Console.Write("INFORME UM VALOR PARA A, B e C (separados por espaço): ");
            string[] valores = Console.ReadLine().Split(' '); 
            decimal a = decimal.Parse(valores[0], CultureInfo.InvariantCulture);
            decimal b = decimal.Parse(valores[1], CultureInfo.InvariantCulture);
            decimal c = decimal.Parse(valores[2], CultureInfo.InvariantCulture); 
            decimal areaTriangulo = (a * c) / 2; 
            decimal areaCirculo = c * 3.14159m; 
            decimal areaTrapezio = ((a+b)*c)/2; 
            decimal areaQuadrado = b * b; 
            decimal areaRetangulo = a * b; 
            Console.WriteLine($"TRIANGULO = {areaTriangulo}");
            Console.WriteLine($"CIRCULO = {areaCirculo}");
            Console.WriteLine($"TRAPEZIO = {areaTrapezio}");
            Console.WriteLine($"QUADRADO = {areaQuadrado}");
            Console.WriteLine($"RETANGULO = {areaRetangulo}"); 
        }
    }
}