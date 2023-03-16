namespace Course
{
    class DateTimeKindExample
    {
        static void Main(string[]args)
        {
            /*
                Todos os fuso horários são baseado em Greenwich, ou seja, GTM; 
                O padrão é o GMT zerado que é o de londres; 
                Em SP, por exemplo, usados o GMT -3 e se for horário de verão GMT -2; 
                Para pegar a data de GMT usamos o UTC. O padrão é gravar no BD UTC (universal) e na hora de mostrar
                fazer a devida conversão para o local. 
            */

            //Exemplos de instanciação de datas usando o kind
            DateTime d0 = new DateTime(2023,03,15,11,10,12);
            DateTime d1 = new DateTime(2023,03,15,11,10,12, DateTimeKind.Local);
            DateTime d2 = new DateTime(2023,03,15,11,10,12, DateTimeKind.Utc);
            
            Console.WriteLine("Não especificado: " + d0.Kind);            
            Console.WriteLine(d0.ToLocalTime());
            Console.WriteLine(d0.ToUniversalTime()); 
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Local: " + d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime()); 
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Utc: " + d2.Kind);
            Console.WriteLine(d2.ToLocalTime());
            Console.WriteLine(d2.ToUniversalTime()); 
            Console.WriteLine("-----------------------------");
            
            /*
                Padrão ISO 8601
                Formato mais usado: yyyy-MM-ddTHH:mm:ssZ (O Z indica que a data está em string no padrão UTC)
            */
            DateTime d3  = DateTime.Parse("2023-03-15 11:30:20");
            DateTime d4 = DateTime.Parse("2023-03-15T11:32:20Z"); 
            Console.WriteLine("Data formatada: " + d3);
            Console.WriteLine("ISO 8601: " + d4);
        }
    }
}