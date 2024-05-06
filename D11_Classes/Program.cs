using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace D11_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            // 1. Instanciar a classe Person(criar em memória) e em seguida atribuir os valores
            Person person01 = new Person();
           
            person01.Id = 1;
            person01.Name = "Pessoa 1";
            person01.NIF = "123456789";
            person01.Phone = "123456789";
            person01.Address = "R aqui, 10";
            person01.City = "Cidade";
            person01.Country = "País";

            // 3. Instanciar o 2º construtor
            Person person02 = new Person(2, "Pessoa 2");

            // 3. Instanciar a classe Person(criar em memória) e imediatamente atribuir os valores

            Person person03 = new Person(3, "Pessoa 3", "123123123", "321321321", "R letra a, 20", "Cidade", "País");
            person01.Id = 1;
            person01.Name = "Pessoa 3";
            person01.NIF = "123456789";
            person01.Phone = "123456789";
            person01.Address = "R aqui, 10";
            person01.City = "Cidade";
            person01.Country = "País";

           

            // 3. 
            person01.PersonWriteData();    

            Utility.TerminateConsole();
            
        }
    }
}
