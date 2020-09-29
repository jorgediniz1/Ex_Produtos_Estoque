using System;
using System.Globalization;

namespace Ex_Produtos_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("NOME");
            p.Nome = Console.ReadLine();
            Console.WriteLine("PREÇO");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("QUANTIDADE NO ESTOQUE");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto" + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);







            
            




        }
    }
}
