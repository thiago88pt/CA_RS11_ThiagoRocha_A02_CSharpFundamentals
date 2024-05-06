using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_CodigoPais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V1 Ifs

            #region MyRegion V1: Ifs

            

            String nome, codPais;
            
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o código do país:  ");
            codPais = Console.ReadLine(); 

            if (codPais == "001" )
            {
                Console.Write("Olá " + nome + ", o seu país é o Brasil: "  );
            }

            else if (codPais == "002")
            {
                Console.WriteLine("Olá " + nome + ", o seu país é o Portugal: ");
            }

            else if (codPais == "003")
            {
                Console.WriteLine("Olá " + nome + ", o seu país é o França: ");
            }

            else if (codPais == "004")
            {
                Console.WriteLine("Olá " + nome + ", o seu país é o Itália: ");
            }

            else if (codPais == "005")
            {
                Console.WriteLine("Olá " + nome + ", o seu país é o Noruega: ");
            }

            else             
                Console.WriteLine("Olá " + nome + ", esse código não consta no sistema: ");
            

            Console.ReadKey();

            #endregion
            
            //V2


            
            #region MyRegion V2: Swich
            
            string nome, pais, codPais;


            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o código do país:  ");
            codPais = Console.ReadLine();
            
            switch (codPais)
            {
                case "001":
                    pais = "Brasil";
                    break;
                case "002":
                    pais = "Portugal";
                    break;
                case "003":
                    pais = "Itália";
                    break;
                case "004":
                    pais = "Bélgica";
                    break;
                case "005":
                    pais = "Inglaterra";
                    break;
                default:
                    pais = "desconhecido";
                    break;
            }

            Console.WriteLine("Olá " + nome + ", o seu país é " + pais + ".");

            Console.ReadKey();

            #endregion
            



           
            
          







        }
    }
}           
