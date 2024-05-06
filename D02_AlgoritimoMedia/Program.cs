using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_AlgoritimoMedia
{
    internal class Program
    {
        static void Main(string[] args)
              /*
               Declarar variáveis
                
                Camel case -> camelCase

                1. Declarar + atribuir
                    tipo var = "name"
                ou

                2. 1º Declarar e 2º atribuir
                    tipo var;
                    var = "name";
               
               */       


        {

            // Métodos: o que posso fazer com a classe
            //tipo_de_dados nome_da_variável


            // Propriedades: dados da classe

            // Calcular a média

            string valor01;
            int valor02;
            double media;

            Console.Write("Informe o produto 1: ");
            valor01 = Console.ReadLine(); //Console.ReadLine(); Ler e seguir parar o próximo comando.
                                          //A Console lê em texto, então por ser string precisa
                                          //converter quando for fazer o cálculo

            Console.Write("Número 2: ");
            valor02 = Convert.ToInt16(Console.ReadLine()); // Por ser int precisa converter ao ler o valor

            media = (Convert.ToDouble(valor01) + Convert.ToDouble(valor02)) / 2;
            Console.WriteLine("A média é: " + media.ToString());

            //Pausar o console
             Console.ReadKey();
                
            // Perguntar porque alguams vezes ele sugere aspas simples








        }
    }
}
