using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E05_Calculadora_02_ComClasses
{
    internal class Methods
    {


        #region Variáveis
        internal double Res { get; set; }
        internal double Num1 { get; set; }
        internal double Num2 { get; set; }
        internal string Operador { get; set; }
                
        #endregion


        #region Título
        public void Titulo()
        {
            Utility.WriteTitle("Bem vindo a calculadora");
        }

        #endregion

        #region Operações 
                //ToDo: Ainda preciso implementar um sistema para o resultado ser guardado para que o cálculo possa continuar. Assim será o loop: res + Num2 = res + Num2.
                // ToDo: E também quero, caso o usuário tente dividir por zero ela possa voltar e digitar novamente o Num2.



        public void Soma()

        {
            Res = Num1 + Num2;
            return;

        }

        public void Sub()

        {
            Res = Num1 - Num2;

        }

        public void Mult()

        {
            Res = Num1 * Num2;

        }

        public void Div()
        {
            if (Num2 == 0)
            {
                Utility.WriteMessage("\nImpossível dividir por zero");
                
            }  
            
            else
            {
                Res = Num1 / Num2;
            }

            


        }


        #endregion 

        #region Introdução de valores

        public void Message()
        {
            Utility.WriteMessage("\nInforme o primeiro valor:  ");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("\nQual operação deseja? + - * /  ?:  ");
            Operador = Console.ReadLine();

            Utility.WriteMessage("\nInforme o segundo valor:  ");
            Num2 = Convert.ToDouble(Console.ReadLine());    

           
        }

      

                
                
        #endregion


        #region Escolher qual a operação


        public void Operadores()
        {
            switch (Operador)
            {
                case "+":
                    Soma();
                    break;
            }

            switch (Operador)
            {
                case "-":
                    Sub();
                    break;
            }

            switch (Operador)
            {
                case "*":
                    Mult();
                    break;
            }

            switch (Operador)
            {
                case "/":
                    Div();
                    break;
            }

        }
        #endregion





    }
}