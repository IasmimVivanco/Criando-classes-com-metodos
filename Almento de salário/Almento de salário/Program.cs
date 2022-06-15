using System;
using System.Globalization;
namespace Almento_de_salário
{
    internal class Program
    {
        // Fazer um programa para ler os dados de um funcionário.
        // (nome, salário bruto e imposto).
        // Em seguida, mostrar os dados do funcionário(nome e salário líquido).
        // Em seguida, aumentar o salário com base em uma porcentagem dada.
        // Somente osalário bruto é afetado pela porcentagem.
        // Mostrar novamente os dados do funcionário.
        //Exemplo de saída.
        //Nome: Joao Silva
        //Salário bruto: 6000.00
        //Imposto: 1000.00
        //Funcionário: Joao Silva, $ 5000.00
        //Digite a porcentagem para aumentar o salário: 10.0
        //Dados atualizados: Joao Silva, $ 5600.00

        static void Main(string[] args)
        {
            Funcionarios funcionario = new Funcionarios();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            funcionario.SalarioLiquido();
            Console.WriteLine($"Funcionário: {funcionario}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {funcionario}");


        }
    }
}