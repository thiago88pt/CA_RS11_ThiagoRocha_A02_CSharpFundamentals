using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E04_AlgotritmoTurma5Formandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] cursos = new string[5];
            double[] idades = new double[5];
            int contadorAlunos = 0;

            while (contadorAlunos < 5)
            {
                Console.WriteLine("Inscrever Nome do Aluno (ou digite 'sair' para terminar): ");
                string nomeInput = Console.ReadLine();

                if (nomeInput.ToLower() == "sair")
                {
                    break;
                }

                Console.WriteLine("Idade: ");
                double idadeInput = Convert.ToDouble(Console.ReadLine());

                if (idadeInput >= 18)
                {
                    Console.WriteLine("Inscrever Curso: ");
                    string cursoInput = Console.ReadLine();

                    nomes[contadorAlunos] = nomeInput;
                    cursos[contadorAlunos] = cursoInput;
                    idades[contadorAlunos] = idadeInput;

                    contadorAlunos++;
                }
                else
                {
                    Console.WriteLine("De Menor não pode votar e nem se matricular.");
                }
            }

            Console.WriteLine("\nAlunos Cadastrados:");

            for (int i = 0; i < contadorAlunos; i++) 
            {
                Console.WriteLine("Aluno: " + nomes[i] + " - Curso: " + cursos[i]);
            }

            Console.ReadLine();

        }

    }

    







        }   
    

