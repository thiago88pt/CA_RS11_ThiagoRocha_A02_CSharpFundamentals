using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace D06_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region 1. Declarar variáveis e criar objetos
            byte idade; // 0 - 255
            float altura;
            double peso;

            bool inscrito; // true (1) | false (0)

            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;

            string nomeCompleto;  // Objeto (Quando o main terminar todas as var finalizam mas essa fica em sistema)
            #endregion

            #region 2. Atribuir valores
            // números
            idade = 10; // só vai até 255.
            altura = 20.5f; // o float para diferenciar do duoble pede o f no fim.
            peso = 10.5; // ponto e não vírgula.

            // booleanos
            inscrito = true;

            // datas
            data = new DateTime(2024, 4, 1);
            hora = new DateTime(2024, 4, 1, 19, 5, 0); // oq aparece em colchetes é opcional.
            agora = DateTime.Now; // timestamp: data + hora.
            dataAtual = DateTime.Today; // data.
            dataVazia = DateTime.MinValue; // 1/1/0001 12:00 am.

            //string
            nomeCompleto = "TSR";
            #endregion

            #region 3. Declarar e atribuir 
            string horario = "19:00 - 22:30";

            #endregion

            #region 4. Vetores (array single dimensional)
            // 4 nomes
            string[] nomes = new string[4]; //começa por 0
            int[] numeros = new int[4]; 
            nomes[0] = "Ana";
            nomes[1] = "Milena";
            nomes[2] = "Amélia";
            nomes[3] = Console.ReadLine(); //ler do console
            Utility.WriteTitle("Vector");
            Console.WriteLine($"\n{nomes[0]}\n{nomes[1]}\n{nomes[2]}\n{nomes[3]}");

            // Atribuir valores
            for (int i = 0; i < numeros.Length; i++) //se possível usar tamanho dinânimo numeros.Length
            {
                numeros[i] = i;
            }

            // Escrever no console
            for (int i = 0; i < 4; i++)
            {
                Utility.WriteMessage($"Valor {i}: {numeros[i]}");
            }

            #endregion

            #region 5. Matrizes (array multi dimensional)
            string[,] turma = new string[4, 2];

            turma[0, 0] = "Ana";
            turma[0, 1] = "Porto";
            turma[1, 0] = "Thiago";
            turma[1, 1] = "Lisboa";
            turma[2, 0] = "Renata";
            turma[2, 1] = "Setúbal";

            turma[3, 0] = Console.ReadLine(); // ReadLine lê string e Read lê int
            turma[3, 1] = Console.Read().ToString();

            for (int r = 0; r < 4; r++)
            {
                for (int i = 0; i < 2; i++) 
                {
                    turma[r, i] = Console.ReadLine();
                }
                    
            }

            for (int r = 0; r < 4; r++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Utility.WriteMessage($"{turma: [r / i]}\n");
                }
            }
                    #endregion

            #region 6. Trabalhar no console
                    Utility.WriteTitle("Variáveis numéricas");
            // para mostrar a lista de opções p completar CTRL * SPACE
            Console.WriteLine("\nByte - idade. " + idade); // Evitar concatenar com o +.
            //string interpolation
            Console.WriteLine($"Float - altura: {altura}");
            Console.WriteLine($"Double - peso: {peso}");


            // Console.WriteLine() - pode ser usado para pular uma linha

            //Console.WriteLine($"\nBoolean - inscrito: {inscrito.ToString()}"); // as retcências(...) indicam que não é necessário.
            Utility.WriteMessage($"nBoolean - inscrito: {inscrito.ToString()}");


            Console.WriteLine("Variável string");
            Console.WriteLine("-------------------------"); // para mostrar a lista de opções p completar CTRL + SPACE
            //Deve se concatenar string com a classe StringBuilder e o método Add
            nomeCompleto = nomeCompleto + "1;"; //não é recomendável
            Console.WriteLine($"\nstring - nomeCompleto: {nomeCompleto}");
            Console.WriteLine($"string - horário: {horario}");
            Console.WriteLine("-------------------------\n\n");

            Utility.WriteTitle("Variáveis data e hora");
            Console.WriteLine($"\n0. Date - data: {data}");
            Utility.WriteMessage($"Date - data: {data}", "\n");
            Utility.WriteMessage($"2. Date - data: {data}", "", "\n\n\n");
            Utility.WriteMessage($"3. Date - data: {data}", begin: "\n\n\n");
            Utility.WriteMessage($"4. Date - data: {data}", "\n\n", "\n\n\n");
            Utility.WriteMessage($"5. Date - data: {data}");

            Utility.WriteMessage($"Long Date - data: {data.ToLongDateString()}", "", "\n");
            Utility.WriteMessage($"Short Date - data: {data.ToShortDateString()}", "", "\n");
                  
            Utility.WriteMessage($"Time - horas: {hora}", "", "\n");
            Utility.WriteMessage($"Long time - horas: {data.ToLongTimeString()}", "", "\n");
            Utility.WriteMessage($"Short time - horas: {data.ToShortTimeString()}", "", "\n");
                  
            Utility.WriteMessage($"Date - data: {data}", "", "\n");
            Utility.WriteMessage($"Date - data atual: {dataAtual}", "", "\n");
            Utility.WriteMessage($"Date - data vazia: {dataVazia}", "", "\n");
                  
            Utility.WriteMessage($"Year ano - : {agora.Year}", "", "\n");
            Utility.WriteMessage($"Month - : {agora.Month}", "", "\n");
            Utility.WriteMessage($"Day - : {agora.Day}", "", "\n");
            Utility.WriteMessage($"Hora - : {agora.Hour}", "", "\n");
            Utility.WriteMessage($"Minute - : {agora.Minute}", "", "\n");
            Utility.WriteMessage($"Second - : {agora.Second}", "", "\n");


            #endregion

            Utility.TerminateConsole();

        }
    }
}
