using System.Globalization; 

namespace ListaFixacaoSecaoCinco
{
    class Conta
    {
        public int NumeroConta {get; private set;}
        public string Titular {get; set;}
        public double Saldo {get; private set; }

        public Conta(int numConta, string titular, double depositoInicial)
        {
            NumeroConta = numConta; 
            Titular = titular; 
            Deposito(depositoInicial);
        }      


        public void Deposito(double valor)
        {
            Saldo += valor;  
        }


        public void Saque(double valor)
        {
            double valorComTaxa = valor + 5; 
            Saldo -= valorComTaxa; 
        }   

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }           
    }
}