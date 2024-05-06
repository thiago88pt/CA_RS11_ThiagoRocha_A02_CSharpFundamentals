using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Calcular o preço final de um produto, mediante o preço final e a taxa de desconto
 
 */
namespace D03_AlgoritimoPrecoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto;
            double preco, precoFinal, desconto;

            Console.Write("Informe qual o produto: ");
            produto = Console.ReadLine();

            Console.Write("Informe o preço do " + produto + " :");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o desconto do produto: ");
            desconto = Convert.ToDouble(Console.ReadLine());

            precoFinal = preco - (preco * desconto / 100);

            Console.Write("O preço final do produto com " + desconto + " % de desconto é: " + precoFinal + ".");

            Console.ReadKey();









        }
    }
}
