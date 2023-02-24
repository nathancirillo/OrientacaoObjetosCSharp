using System.Globalization; 

namespace ListaSix
{
    class Funcionario 
    {
        public string Nome; 
        public double SalarioBruto; 
        public double Imposto;


        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto; 
        }


        public void AumentarSalario(double porcentagem)
        {
             SalarioBruto = SalarioBruto * (1 + (porcentagem/100));
        }


    }
}