using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A00_Utility;

namespace A01_CalculoDoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Calculadora do Índice de Massa Corporal (IMC)");

            #region 1. Variaveis

            double peso, altura, iMC;

            #endregion

            #region 2. Leitura de Valores

            // Altura
            Utility.WriteMessage("Qual é a sua altura? ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Peso
            Utility.WriteMessage("Qual é o seu Peso? ");
            peso = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region 3. Calculo do IMC

            iMC = Math.Round(peso / (altura * altura), 2);
            Utility.WriteMessage($"O seu Índice de Massa Corcoral é de {iMC.ToString()}");

            #endregion

            #region 4. Explicação do Resultado do IMC

            if(iMC < 18.5)
            {
                Utility.WriteMessage("\nO seu IMC é considerado PESO CORPORAL BAIXO, assim deve procurar a ajuda de um profissional de nutrição para ganhar peso de forma saudável.");
            }
            else if(iMC > 18.5 && iMC < 24.9)
            {
                Utility.WriteMessage("\nO seu IMC é considerado PESO CORPORAL NORMAL, assim deve continuar a praticar uma alimentação saudavel para se manter saudável.");
            }
            else if(iMC > 24.9 && iMC < 29.9)
            {
                Utility.WriteMessage("\nO seu IMC é considerado PESO CORPORAL EXCESSIVO, assim deve procurar a ajuda de um profissional de nutrição para perder peso de forma sauldável.");
            }
            else if(iMC > 29.9 && iMC < 34.9)
            {
                Utility.WriteMessage("\nO seu IMC é considerado OBESIDADE MODERADA, assim deve procurar a ajuda de um profissional de nutrição para perder peso de forma sauldável.");
            }
            else if (iMC > 34.9 && iMC < 39.9)
            {
                Utility.WriteMessage("\nO seu IMC é considerado OBESIDADE GRAVE, assim deve procurar a ajuda de um profissional de nutrição para perder peso de forma sauldável.");
            }
            else if (iMC > 39.9 && iMC < 49.9)
            {
                Utility.WriteMessage("\nO seu IMC é considerado OBESIDADE MÓRBIDA, assim deve procurar a ajuda de um profissional de nutrição para perder peso de forma sauldável.");
            }
            else
            {
                Utility.WriteMessage("\nO seu IMC é considerado SUPEROBESIDADE, assim deve procurar a ajuda de um profissional de nutrição para perder peso de forma sauldável.");
            }

            #endregion

            // Pausar a Consola
            Utility.TerminateConsole();

        }
    }
}

