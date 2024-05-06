using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculatora_v01_SemClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, result;
            string operating;

            Utility.WriteTitle("Bem vindo a sua calculadora.");
            Utility.WriteMessage("\nDigite um valor");
            n1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("\nDigite a operação");
            operating = Console.ReadLine();

            Utility.WriteMessage("\nDigite o próximo valor");
            n2 = Convert.ToDouble(Console.ReadLine());

            switch (operating)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        Utility.WriteMessage("A divisão por zero não é permitida. Refaça a conta.");
                    }
                    else
                    {
                        result = n1 / n2;
                        
                    }
                    break;
                default:
                    Utility.WriteMessage("Operação inválida.");
                    return;
            }
            Utility.WriteMessage($"Resultado: {result}");
        }
    }
}
