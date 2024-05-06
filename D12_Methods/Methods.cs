using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Methods
    {

        #region Método void


        public void Procedure() //void retorna uma valor
        {
            string message = "Procedimento: método void - não devolve valor.";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;
        }
        #endregion


        #region Método não void

        public int Function() //sem void não retorna
        {
            string message = "Procedimento: método não void - devolve valor.";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;
            return res;
        }

        #endregion

        public void WrongProcedure()
        {
            string message = "Procedimento: método não void - devolve valor.";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;
            Utility.WriteMessage(res.ToString());
        }


        #region Método com parâmetros obrigatórios
        public void MethodRequiredParameters(string message1, string message2)
        {
            Utility.WriteMessage(message1, "", "\n");
            Utility.WriteMessage(message2, "", "\n\n");
        }
        #endregion

        #region Método com parâmetros opcionais
        public void MethodOptionalParameters(string message1 = "", string message2 = "Opcionais")
        {
            Utility.WriteMessage(message1, "", "\n");
            Utility.WriteMessage(message2, "", "\n\n");
        }
        #endregion


        #region Método com parâmetro por valor
        public void PassingValues(int value01)
        {
            value01 = 10;

            Utility.WriteMessage($"\n2: Valor dentro do método: {value01}", "", "\n\n");


        }
        #endregion


        #region Método com parâmetro por referência

        public void PassingReferences(ref int value02)
        {
            value02 = 10;  //mudar o valor muda em todas as referências.

            Utility.WriteMessage($"\n2: Valor dentro do método: {value02}", "", "\n\n");

        }

        #endregion


        #region Método de instância
        public void InstanceMethod()
        {
            Utility.WriteMessage("\nUm método de instância é chamado através de um objeto (instância) da classe");

        }
        #endregion


        #region Método estático
        public static void StaticMethod()
        {
            Utility.WriteMessage("\nUm método estático é chamado diretamente da classe");

        }

        #endregion

        #region Sobrecarga de métodos (overloading)
        public static void WriteNewMessage(string message)
        {
            message = message.ToUpper();
            Utility.WriteMessage(message, "", "\n");
        }


        public static void WriteNewMessage(string message01, string message02)
        {
            message01 = message01.ToLower();
            message02 = message02.ToLower();
            Utility.WriteMessage($"{message01} {message02}", "", "\n");
        }
        #endregion
    }

}






