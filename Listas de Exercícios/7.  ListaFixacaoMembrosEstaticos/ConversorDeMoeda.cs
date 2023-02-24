namespace ListaSeven 
{
    static class ConversorDeMoeda
    {
        static double IOF = 1.06; 
        public static double ConverterMoeda(double cotacaoDolar, double QtdDolar)
        {
              return cotacaoDolar * QtdDolar * IOF;   
        }
    }
}