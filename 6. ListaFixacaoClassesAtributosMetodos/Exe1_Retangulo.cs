using System.Globalization; 

namespace ListaSix
{
    class Retangulo 
    {
        public double Largura; 
        public double Altura;


        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)} \nPERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)} \nDIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura); 
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
        }

    }
}