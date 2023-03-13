namespace Course
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o dia da semana (número): ");
            int dia = int.Parse(Console.ReadLine());
            string texto = string.Empty;
            switch (dia)
            {
                case 1:
                    texto = "Domingo";
                    break;
                case 2:
                    texto = "Segunda";
                    break;
                case 3:
                    texto = "Terça";
                    break;
                case 4:
                    texto = "Quarta";
                    break;
                case 5:
                    texto = "Quinta";
                    break;
                case 6:
                    texto = "Sexta";
                    break;
                case 7:
                    texto = "Sábado";
                    break;
                default:
                    texto = "Dia Inválido!";
                    break;
            }
            Console.WriteLine($"Dia {dia} = {texto}.");
        }
    }
}