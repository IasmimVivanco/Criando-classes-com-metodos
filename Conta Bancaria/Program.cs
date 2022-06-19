using System.Globalization;
namespace Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente;

            Console.Write("Digite o numero da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
           
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            cliente = new Cliente(titular, numeroDaConta);

            Console.Write("Haverá depósito inicial (s/n) ? ");
            cliente.DepositoInicial();
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente);
            Console.WriteLine();
           
            Console.Write("Digite o valor de depósito: ");
            double saldo = cliente.Deposito();

            cliente = new Cliente(titular, numeroDaConta, saldo);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
            Console.WriteLine();
            
            Console.Write("Digite o valor para saque: ");
   
            cliente.saque();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);

        }
    }
}