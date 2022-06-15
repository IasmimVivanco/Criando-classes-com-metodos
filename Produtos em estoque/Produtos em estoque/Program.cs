using System;
using System.Globalization;

namespace Produtos_em_estoque
{
    internal class Program
    {
     //Fazer um programa para ler os dados de um produto em estoque(nome, preço e quantidade no estoque).
     //Em seguida:
     //Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no estoque)
     //Realizar uma entrada no estoque e mostrar novamente os dados do produto
     //Realizar uma saída no estoque e mostrar novamente os dados do produto.
        static void Main(string[] args)
        {

            Produtos p = new Produtos();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());            
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removida do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}