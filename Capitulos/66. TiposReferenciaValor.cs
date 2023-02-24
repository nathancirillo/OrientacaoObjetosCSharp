namespace Course
{
    class TiposReferenciaValor
    {
        static void Main(string[] args)
        {
            Funcionario ref1, ref2;
            ref1 = new Funcionario(001, "Nathan");
            ref2 = ref1;
            ref2.Cargo = "Desenvolvedor de Sistemas";
            System.Console.WriteLine(ref1);


            Coordenadas val1, val2;
            val1.X = 15;
            val1.Y = 20;
            val2 = val1;
            val2.X = 20;
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }


    class Funcionario
    {
        public int Matricula { get; private set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }


        public Funcionario(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }


        public Funcionario(int matricula, string nome, string cargo) : this(matricula, nome)
        {
            Cargo = cargo;
        }

        public override string ToString()
        {
            return $"{Matricula} - {Nome} - {Cargo}";
        }
    }

    struct Coordenadas
    {
        public double X;
        public double Y;


        public override string ToString()
        {
            return "(" +
                    X +
                    ", " +
                    Y +
                    ").";
        }
    }


}