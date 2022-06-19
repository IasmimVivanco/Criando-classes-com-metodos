using System.Globalization;
namespace Conta_Bancaria
{
    internal class Cliente
    {
        public string Titular { get; set; }
        public int NumeroDaConta { get; private set; }
        public double Saldo { get; private set; }

        public Cliente(string titular, int numeroDaConta)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
        }

        public Cliente(string titular, int numeroDaConta, double saldo)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public double DepositoInicial() {
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                return Saldo = valor;
            }
            else
            {
                return Saldo = 0.0;
            }
}
        public double Deposito()
        {
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return Saldo += deposito;
        }
        public double saque()
        {
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo = Saldo - 5.00;
            return Saldo -= Saque;
        }

        public override string ToString()
        {
            return ($"Conta: {NumeroDaConta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
        }
        
    }
}
