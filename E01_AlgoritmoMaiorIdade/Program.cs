using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E01_AlgoritmoMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int idade;
            Utility.WriteMessage("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Utility.WriteMessage("Digite a idade :");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Utility.WriteMessage("A pessoa é maior de idade");
            }
            else
            {
                Utility.WriteMessage("A pessoa é menor de idade");
            }
            
           

            Utility.TerminateConsole();
        }
    }
}
