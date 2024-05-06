using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D14_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error handling");

            #region Sem tratamento de erros
            /*
            int num1;

            Utility.WriteMessage("\n\nInforme e número: ");

            num1 = Convert.ToInt16(Console.ReadLine());

            */
            #endregion


            #region Com tratamento de erros
            try // tentar fazer o código
            {
                bool teste = false;
                string texto = "asf";
                int num2;

                Utility.WriteMessage("\n\nInforme e número: ");

                num2 = Convert.ToInt16(Console.ReadLine());


            }
            catch(DivideByZeroException) 
            {
                Utility.WriteMessage("Não é possível dividir por zero");
            
            } 


            catch (FormatException ex) // format é pq é o tipo de erro identificado.                            //1. Usar o trow pra identificar os erros.
                                                                                                                //2. Fazer os catchs pelos erros mais específicos.
            {                                                                                                   //3. Depois o catch genérico (Exception).
                Utility.WriteMessage("\n\nInformando o erro");
            
            
            }


            catch (Exception ex) // se der erro pula para o catch
            {

                Utility.WriteMessage($"\n\nErro:\n\n {ex.Message}");

                //Utility.WriteMessage("Aconteceu um erro\n\n\n");
                //versão de produção. Devemos implementar um sistema de logs(registros).
                //throw; // executar a exception (erro). Sem ele o erro não é mostrado. Não pode estar na fase final.

            }


            finally // é opcional porém, com ou sem erro ele termina com o finally 
            {
                Utility.WriteMessage("Terminei!"); 
            }


            #endregion



            Utility.TerminateConsole();
        }
    }
}
