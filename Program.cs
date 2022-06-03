using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Out_My_Phrase 
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Black;

            /*
            Square.Out_phrase("Ставь, дедуля, ");
            Square.Out_phrase("        самогон,       ");
            Square.Out_phrase("Будем слушать");
            Square.Out_phrase("        Sabaton!       ");
            Console.WriteLine("");
            Square.Out_full_alphabet();
            Console.WriteLine("");
            */

            Console.WriteLine("Out special commands -> _cmds\n");

            for (int go = 1; go > 0; ++go)
            {
                Console.Write("Enter phrase> ");

                string ph = Convert.ToString(Console.ReadLine());

                Console.WriteLine();

                switch (ph)
                {
                    case "_alph":

                        Square.Out_full_alphabet();

                        Console.WriteLine();

                        break;

                    case "_cmds":

                        Console.WriteLine("Special commands: \n\n" +
                                          "                 _alph - print the entire alphabet\n\n" +
                                          "                 _exit - exiting the program\n");

                        break;

                    case "_exit":

                        go = -1;

                        break;

                    default:

                        Square.Out_phrase(ph);

                        Console.WriteLine();

                        break;
                }
            }

            Console.WriteLine("Good Luck!\n");

            Console.ReadKey();
        }
    }
}
