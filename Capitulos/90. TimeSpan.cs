namespace Course
{
    class TimeSpanExample
    {
        static void Main(string[]args)
        {
            /*
                Enquanto o DateTime representa um instante de tempo, o TimeSpan representa uma duração;
                Uma duração pode ser entedida como um intervalo entre dois instantes;
                Essa duração é representada internamente na forma de Ticks (100 nanossegundos)
            */

            //Constrututor passando hora, minuto e segundo
            TimeSpan t1 = new TimeSpan(0,1,30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            //Construtor padrão que traz o tempo zerado
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            //Construtor passando a quantidade de ticks
            TimeSpan t3 = new TimeSpan(900000000);
            Console.WriteLine(t3);

            //Construtor para dias, horas, minutos e segundos
            TimeSpan t4 = new TimeSpan(4,3,2,25); 
            Console.WriteLine(t4); 

            //Constutor para dias, horas, minutos, segundos e milissegundos
            TimeSpan t5 = new TimeSpan(2,1,30,20,200);
            Console.WriteLine(t5); 

            //Um outro recurso interessante é poder instanciar um TimeSpan a partir de opções From. 
            //Dessa forma é possível criar uma duração a partir de algum ponto. 
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5); 
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5); 
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5); 
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5); 
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromTicks(900000000);
            Console.WriteLine(t11);

        }
    }
}