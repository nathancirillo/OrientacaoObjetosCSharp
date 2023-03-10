using System.Globalization; 
namespace Course
{
    class ExercicioLista
    {
        public static void Main(string[]args)
        {
            int id; 
            List<Empregado> empregados = new List<Empregado>();
            
            Console.Write("Quantos empregados deseja registrar? ");
            int qtd = int.Parse(Console.ReadLine()); 

            for(int i=0; i<qtd; i++)
            {
                Console.WriteLine($"Empregado {i+1}: ");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine(); 
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                var empregado = new Empregado(id,nome,salario);
                empregados.Add(empregado);               
            }

            Console.WriteLine();
            Console.Write("Informe o ID do empregado que terá aumento: ");
            id = int.Parse(Console.ReadLine());
            int idxBeneficiado = empregados.FindIndex(e => e.Id == id );
            if(idxBeneficiado != -1)
                empregados.ElementAt(idxBeneficiado).AumentaSalario(10);
            else
                Console.WriteLine("Empregado não existe!");

            Console.WriteLine("---------------");
            foreach(var empregado in empregados)
            {
                Console.WriteLine(empregado); 
            } 
        }

        
    }

    class Empregado 
    {       
        private int _id; 
        private string _nome; 
        private double _salario; 

        public int Id
        {            
            get{ return _id; }
        }

        public Empregado(int id, string nome, double salario)
        {
            _id = id; 
            _nome = nome; 
            _salario = salario; 
        }

        public void AumentaSalario(double porcentagem)
        {
            double taxa = (porcentagem / 100) + 1;
            _salario *= taxa;  
        }

        public override string ToString()
        {
            return $"{_id} {_nome} {_salario.ToString("F2")}";
        }
    }
}