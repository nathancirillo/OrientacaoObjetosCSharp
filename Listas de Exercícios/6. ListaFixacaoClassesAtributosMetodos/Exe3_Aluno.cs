using System.Globalization; 

namespace ListaSix
{
    class Aluno
    {
        public string Nome; 
        public double Nota1; 
        public double Nota2; 
        public double Nota3; 

        public double ObterNotaFinal()
        {
            return Nota1 + Nota2 + Nota3; 
        }

        public void DefinirStatus()
        {           
            if(ObterNotaFinal() < 60)
            {
                Console.WriteLine($"REPROVADO");
                Console.WriteLine($"FALTARAM {(60 - ObterNotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            } 
            else 
            {
                Console.WriteLine("APROVADO");
            }
        }



    }
}