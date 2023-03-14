using System.Globalization;

namespace Course
{
    public class DateTimeExample
    {
        public static void Main(string[]args)
        {
            // O datetime é representado por um número gigante chamado de ticks. 
            // Um tick equivale a 100 nanossegundos. Esse valor armazenado desde 1 de janeiro do ano um da era atual. 
            // Representa um instante de tempo. 
            
            //Pegando a data atual
            DateTime d1 = DateTime.Now; 
            Console.WriteLine(d1);

            //Vendo o número de ticks referente a data atual 
            Console.WriteLine(d1.Ticks); 


            //Algumas sobrecargas para criar datas: 

            //Ano, mês e dia
            DateTime d2 = new DateTime(2023, 03, 13); 
            Console.WriteLine(d2);

            //Ano, mês, dia, hora, minuto e segundo
            DateTime d3 = new DateTime(2023,03,13,19,30,04);
            Console.WriteLine(d3);

            //Ano, mês, dia, hora, minuto, segundo e nanossegundo (não considerado na formatação padrão)
            DateTime d4 = new DateTime(2023,03,13,19,30,04,500);
            Console.WriteLine(d4);

            //Também é possível especificar o DateTimeKind que mostra se a data é local ou global
            //Hora local tem o  fuso de greenwich (GMT) que é o padrão do C#;


            //Pegando o dia de hoje, porém com o horário zerado
            DateTime d5 = DateTime.Today; 
            Console.WriteLine(d5); 


            //Podemos pegar o horário global (GMT) através do UtcNow 
            //No brasil por padrão é GMT -3, variando de acordo com o horário de verão
            DateTime d6 = DateTime.UtcNow; 
            Console.WriteLine(d6); 

            //Convertendo uma string para  uma data. Por padrão, o Parse aceita vários formatos. 
            DateTime d7 = DateTime.Parse("2023-03-13"); 
            Console.WriteLine(d7);

            //Agora iremos fazer com o horário
            DateTime d8 = DateTime.Parse("2023-03-13 19:44:15");
            Console.WriteLine(d8);

            //Podemos especificar também uma data usando o padrão brasileiro sem problemas. 
            //Isso pode ser somente com a data e também com o horário. 
            DateTime d9 = DateTime.Parse("13/03/2023");
            Console.WriteLine(d9);  

            //Temos o método ParseExact que permite você determinar o formato de sua data. 
            //Ou seja, não irá usar o padrão determinado pelo C#, conforme mostrado antes. 
            //É necessário passar a data no padrão e depois uma máscara de formatação. 
            //O output não será alterado, mas sim apenas a forma como a data é passada. 
            DateTime d10 = DateTime.ParseExact("2023-03-13", "yyyy-MM-dd", CultureInfo.InvariantCulture); 
            Console.WriteLine(d10); 

            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}