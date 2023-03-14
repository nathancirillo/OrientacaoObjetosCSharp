namespace Course
{
    class OperacoesDateTime
    {
        static void Main(string[]args)
        {
            DateTime d0 = new DateTime(2023,03,14,16,44,58,200);

            /*
                Com base em uma data é possível usar diversar propriedades para capturar valores específicos, como: 
                ano, mês, dia, dia da semana, dia do ano, etc. 
            */
            Console.WriteLine("PROPRIEDADES: ");
            Console.WriteLine("------------------------------");            
            Console.WriteLine($"Data e hora completa: {d0}"); 
            Console.WriteLine($"Date: {d0.Date}");
            Console.WriteLine($"Day: {d0.Day}");
            Console.WriteLine($"Month: {d0.Month}");
            Console.WriteLine($"Year: {d0.Year}");
            Console.WriteLine($"Hour: {d0.Hour}");
            Console.WriteLine($"Minute: {d0.Minute}");
            Console.WriteLine($"Second: {d0.Second}");
            Console.WriteLine($"Millisecond: {d0.Millisecond}");           
            Console.WriteLine($"DayOfWeek: {d0.DayOfWeek}");
            Console.WriteLine($"DayOfYear: {d0.DayOfYear}");
            Console.WriteLine($"Kind: {d0.Kind}");
            Console.WriteLine($"Ticks: {d0.Ticks}");
            Console.WriteLine($"TimeOfDay: {d0.TimeOfDay}");
            Console.WriteLine("------------------------------"); 


            /*
                Também é possível formatar a forma como a data deve aparecer em tela. Para isso existem 
                diversos métodos que já retornam o valor formatado. 
            */

            Console.WriteLine("MÉTODOS FORMATAÇÃO: ");
            Console.WriteLine("------------------------------"); 
            Console.WriteLine($"ToString() = {d0.ToString()}"); 
            Console.WriteLine($"ToLongDateString() = {d0.ToLongDateString()}"); 
            Console.WriteLine($"ToLongTimeString() = {d0.ToLongTimeString()}");
            Console.WriteLine($"ToShortDateString() = {d0.ToShortDateString()}");
            Console.WriteLine($"ToShortTimeString() = {d0.ToShortTimeString()}");
            Console.WriteLine($"Máscara: {d0.ToString("yyyy-MM-dd HH:mm:ss")}"); 
            Console.WriteLine($"Máscara: {d0.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
            Console.WriteLine("------------------------------"); 

            Console.WriteLine("MÉTODOS OPERAÇÕES: ");
            Console.WriteLine("------------------------------");  
            Console.WriteLine($"Original = {d0.ToString()}"); 
            Console.WriteLine($"AddHours = {d0.AddHours(2)}"); 
            Console.WriteLine($"AddMinutes = {d0.AddMinutes(3)}"); 
            Console.WriteLine("------------------------------");  
            
            Console.WriteLine("DIFERENÇA ENTRE DATAS: ");
            Console.WriteLine("------------------------------");  
            DateTime d1 = new DateTime(1990,09,20); 
            DateTime d2 = new DateTime(2023,03,14); 
            TimeSpan ts = d2.Subtract(d1); 
            Console.WriteLine(ts); 
            Console.WriteLine("------------------------------");  

        }
    }
}
