using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_InserirFormandoCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string formando1, formando2, formando3, formando4, formando5, formandosCurso1, formandosCurso2, curso1, curso2;


            Utility.WriteTitle("INSERÇÃO DE ALUNOS.");

            Utility.WriteMessage("\n\nInforme o primeiro curso: ");
            curso1 = Console.ReadLine();
            Utility.WriteMessage("Informe o segundo curso: ");
            curso2 = Console.ReadLine();

            Utility.WriteMessage($"Informe o primeiro formando do curso {curso1} : ");
            formando1 = Console.ReadLine();
            Utility.WriteMessage($"Informe o segundo formando do curso {curso1} : ");
            formando2 = Console.ReadLine();
            Utility.WriteMessage($"Informe o terceiro formando do curso {curso1} : ");
            formando3 = Console.ReadLine();

            formandosCurso1 = formando1 + "\n" + formando2 + "\n" + formando3;

            Utility.WriteMessage($"Informe o primeiro formando do curso {curso2} : ");
            formando4 = Console.ReadLine();
            Utility.WriteMessage($"Informe o segundo formando do curso {curso2} : ");
            formando5 = Console.ReadLine();

            formandosCurso2 = formando4 + "\n" + formando5;

            Utility.WriteMessage($"\nOs formandos abaixo estão inscritos no curso {curso1}: \n{formandosCurso1}. \n\nE os formandos abaixo estão inscritos no curso {curso2}: \n{formandosCurso2}");

            Utility.TerminateConsole();


        }
    }
}
