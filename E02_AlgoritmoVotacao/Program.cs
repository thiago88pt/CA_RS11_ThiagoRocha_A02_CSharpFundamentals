using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E02_AlgoritmoVotacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string titulo;

            Utility.WriteTitle("Verificãção de eleitores");

            Utility.WriteMessage("\n\nDigite a idade do(a) eleitor(a): ");
            idade = Convert.ToInt32(Console.ReadLine());

            Utility.WriteMessage("Tem título de eleitor?: ");
            titulo = Console.ReadLine();



            if (idade >= 16 && titulo == "s")
            {
                Utility.WriteMessage("Você pode votar");

            }
            else if (titulo == "n")
            {
                Utility.WriteMessage("Você não pode votar pois não tem título de eleitor.");

            }
            else
            {
                Utility.WriteMessage("Você não tem idade o suficiente");

            }


            Utility.TerminateConsole();

        }
    }
}
