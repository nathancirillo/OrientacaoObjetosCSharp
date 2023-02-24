namespace ListaTwo
{
    class ExeFour
    {
        static void Main(string[]args)
        {
            Console.Write("Informe as horas (separadas por espaço): ");
            string[] horas = Console.ReadLine().Split(' ');
            int horaUm = int.Parse(horas[0]);
            int horaDois = int.Parse(horas[1]);

            if((horaUm < 0 || horaUm > 24) || (horaDois < 0 || horaDois > 24)){
                Console.WriteLine("Hora informada inválida!"); 
                return; 
            }

            if(horaDois > horaUm){
                Console.WriteLine($"O jogo durou {horaDois - horaUm} horas.");
            } else if(horaUm > horaDois){
                int duracao = (24 - horaUm) + horaDois; 
                Console.WriteLine($"O jogo durou {duracao} horas.");
            } else {
                Console.WriteLine("O jogo durou 24 horas. ");
            }

        }
    }
}