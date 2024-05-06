using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E05_Calculadora_02_ComClasses
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
          
            Utility.SetUnicodeConsole();

            Methods methods = new Methods();


            methods.Titulo();
            methods.Message();
            methods.Operadores();

            
            


            Utility.TerminateConsole();   
    
        }



        
    }
}
