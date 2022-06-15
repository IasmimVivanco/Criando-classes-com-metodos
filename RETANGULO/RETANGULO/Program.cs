using System;
using System.Globalization;

namespace RETANGULO
{
    internal class Program
    {
     //Fazer um programa para ler os valores da largura e altura de um retângulo.
     //Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
     //Exemplo de saída:
     //Entre com a largura e altura do retângulo:
     //3.00
     //4.00
     //AREA = 12.00
     //PERÍMETRO = 14.00
     //DIAGONAL = 5.0
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA: " + retangulo.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine($"PERÍMETRO: " + retangulo.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine($"DIAGONAL: " + retangulo.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }

}