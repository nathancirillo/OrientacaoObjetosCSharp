namespace Course
{
    class PropriedadesTimeSpan
    {
        static void Main(string[]args)
        {
            //Busca a duração máxima possível de se armazenar em um TimeSpan
            TimeSpan ts1 = TimeSpan.MaxValue;
            //Busca a duração mínima possível de se armazenar em um TimeSpan 
            TimeSpan ts2 = TimeSpan.MinValue;  
            //Define o instante zero 
            TimeSpan ts3 = TimeSpan.Zero; 
            
            Console.WriteLine($"MaxValue = {ts1}");
            Console.WriteLine($"MinValue = {ts2}");
            Console.WriteLine($"Zero = {ts3}");

            //Outra possibilidade é buscar partes específicas de um TimeSpan 
            TimeSpan  ts4 = new TimeSpan(2,14,30,20);
            Console.WriteLine($"Original = {ts4}");
            
            //quantidade de dias, horas, minutos, segundos e millisegundos em um timespan
            //nesse caso sempre será retornado o valor inteiro
            Console.WriteLine($"Days = {ts4.Days}");
            Console.WriteLine($"Hours = {ts4.Hours}");
            Console.WriteLine($"Minutes = {ts4.Minutes}");
            Console.WriteLine($"Seconds = {ts4.Seconds}");
            Console.WriteLine($"Millinseconds = {ts4.Milliseconds}");

            //já as propriedades com total me devolve exatamente o valor calculado
            //considerando, por exemplo, em um dia as  horas, minutos e segundos. 
            Console.WriteLine($"Ticks = {ts4.Ticks}");
            Console.WriteLine($"TotalDays = {ts4.TotalDays}");
            Console.WriteLine($"TotalHours = {ts4.TotalHours}");
            Console.WriteLine($"TotalMinutes = {ts4.TotalMinutes}");
            Console.WriteLine($"TotalSeconds = {ts4.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds = {ts4.TotalMilliseconds}");

            //também é possível realizar operações através do timespan
            //multiplicar, somar, dividir e subtrair. Veja alguns exemplos: 
            TimeSpan ts5 = new TimeSpan(1, 30, 10); 
            TimeSpan ts6 = new TimeSpan(0,10,5); 

            //somando os valores: 
            TimeSpan sum = ts5.Add(ts6); 
            Console.WriteLine($"Soma = {sum}");

            //diferença entre valores: 
            TimeSpan diff = ts5.Subtract(ts6);
            Console.WriteLine($"Subtrair: {diff}");

            //multiplicação: 
            TimeSpan mult = ts6.Multiply(2);
            Console.WriteLine($"Multiplicar: {mult}");

            //Divisão
            TimeSpan div = ts5.Divide(2.0); 
            Console.WriteLine($"Divisão: {div}");
        }
    }
}