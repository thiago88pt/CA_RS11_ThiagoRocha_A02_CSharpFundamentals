using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace D12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Methods methods01 = new Methods();

            #region Método void

            Utility.WriteTitle("Procedure (método void. Não devolve valor.)\n");


            methods01.Procedure();

            #endregion

            #region Método não void
            Utility.WriteTitle("Procedure (método não void. Devolve.)");

            // v1
            Utility.WriteMessage(methods01.Function().ToString(), "\n");

            // v2
            int res;

            res = methods01.Function();

            Utility.WriteMessage(res.ToString(), "\n");
            #endregion
            

            #region Método com parâmetros obrigatórios
            Utility.WriteTitle("Método com parâmetros obrigatórios");

            methods01.MethodOptionalParameters("\nPassagem de parâmetris.", "Obrigatórios.");

            #endregion
            
            
            
            #region Método com parâmetros opcionais
            
            Utility.WriteTitle("Método com parâmetros opcionais");

            methods01.MethodOptionalParameters("\n1: Passagem de parâmetros.");

            #endregion


            #region Método com parâmetro por valor
            Utility.WriteTitle("Método com parâmetros por valor");

            int value01 = 1;

            Utility.WriteMessage($"\n1: Valor antes do método: {value01}", "", "");  //1

            methods01.PassingValues(value01); //10


            Utility.WriteMessage($"3: Valor após do método: {value01}", "", ""); //1


            #endregion



            #region Método com parâmetro por referência
            Utility.WriteTitle("Método com parâmetros por referência");

            int value02 = 1; 

            Utility.WriteMessage($"\n1: Valor antes do método: {value01}", "", "");  //1

            methods01.PassingReferences(ref value02);    //10

            Utility.WriteMessage($"3: Valor após do método: {value02}", "", ""); //10
            #endregion


            #region Método de instância
            Utility.WriteTitle("Método de instância");


            //Chamar o Método de instância
            Methods methods02  = new Methods();
            methods02.InstanceMethod(); 

            #endregion


            #region Método estático
            Utility.WriteTitle("Método de estático");
            

            //Chamar o Método estático  
            Methods.StaticMethod();

            #endregion

            #region Sobrecarga de métodos (overloading) 
            // Podemos ter método iguais porém com assinatras diferentes.

            Utility.WriteTitle("Overloading de métodos");

            Methods.WriteNewMessage("1º Overload");

            Methods.WriteNewMessage("2º", "overload");


            #endregion


            Utility.TerminateConsole();
        }
    }
}
