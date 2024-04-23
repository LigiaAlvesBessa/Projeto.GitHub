using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A00_Utility
{
    public class Utility
    {
        public static void SetUnicodeConsole()
        {

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

        }

        public static void WriteTitle(string title)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-',60));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {

            Console.Write($"{beginMessage}{message}{endMessage}");


        }

        public static void TerminateConsole()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\n\nPrime qualquer tecla para terminares.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();

        }




    }
}
