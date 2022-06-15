using System;
using System.Globalization;
namespace Alunos
{
    internal class Program
    {
     //Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano.
     //Ao final, mostrar qual a nota final do aluno.
     //Dizer também se o aluno está APROVADO ou REPROVADO.
     //Em caso negativo, quantos pontos faltam para ser aprovado(minimo é 60 pontos).
     //Você deve criar uma classe Aluno para resolver este problema.

        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno: ");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.PontosRestante().ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}