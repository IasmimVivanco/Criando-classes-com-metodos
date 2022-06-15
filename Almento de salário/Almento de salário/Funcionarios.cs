using System;
using System.Globalization;

namespace Almento_de_salário
{
    internal class Funcionarios
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario = Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + Imposto;
            porcentagem = Salario * porcentagem / 100.0;
            Salario = SalarioLiquido() + porcentagem;       
        }
        public override string ToString()
        {
            return ($"{Nome}, $ {Salario.ToString(("F2"),CultureInfo.InvariantCulture)}");
        }
    }
}
