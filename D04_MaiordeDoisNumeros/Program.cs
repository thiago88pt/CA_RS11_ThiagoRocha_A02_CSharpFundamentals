using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace D04_MaiordeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.WriteLine("informe o primeiro numero ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o segundo numero ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //Math.Max verifica o valor entre 2 números

            if (numero1 > numero2)

            {
                Console.WriteLine("O número " + numero1 + " é maior que o " + numero2 + ".");
            }

            else if (numero2 > numero1)
            {
                Console.WriteLine("O número " + numero2 + " é maior que o " + numero1 + ".");
            }

            else
            {
                Console.WriteLine("Os números são iguais.");
            }

                Console.ReadKey();




        }
    }
}
