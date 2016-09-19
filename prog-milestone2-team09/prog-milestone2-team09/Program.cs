using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prog_milestone2_team06
{
    class Program
    {
        static void Main(string[] args)
        {
            int longtime = 2000;
            int shorttime = 1000;
            char menuchoice = '0';

            //
            // The actual menu. While and switch method.
            //

            while (menuchoice == '0')
            {

                Console.Clear();
                Console.WriteLine();
                TitleColor("Please select an option:");
                Console.WriteLine();
                JeremyColor("1. Jeremy ");
                AmberColor("2. Amber  ");
                BelindaColor("3. Belinda");
                JacobColor("4. Jacob  ");

                menuchoice = Console.ReadKey(false).KeyChar;

                switch (menuchoice)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Jeremy Method here
                        JeremyColor("Jeremys Method will run here");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Amber Method here
                        AmberColor("Ambers Method will run here");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Belinda Method here
                        BelindaColor("Belindas Method will run here");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Jacob Method here
                        JacobColor("Jacobs Method will run here");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        WarningColor("Sorry, invalid selection.");
                        Thread.Sleep(shorttime);
                        WarningColor("You will now return to the main menu");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                }
            }
        }

        //
        // Some wanky color shit and centering for the menu. 
        // Going to change it to 1 single Method with some if and while loop stuff.
        // One Method per user color wont scale.
        //

        static void JeremyColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Set color here for Jeremy
            Console.WriteLine(value); 
            Console.ResetColor();
        }
        static void AmberColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Magenta;  //Set color here for Amber
            Console.WriteLine(value);
            Console.ResetColor();
        }
        static void BelindaColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Red;  //Set color here for Belinda
            Console.WriteLine(value);
            Console.ResetColor();
        }
        static void JacobColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkCyan;  //Set color here for Jacob
            Console.WriteLine(value);
            Console.ResetColor();
        }
        static void TitleColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkYellow;  //Set color here for Menu Title
            Console.WriteLine(value);
            Console.ResetColor();
        }
        static void WarningColor(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Red;  //Set color here for Warning messages
            Console.WriteLine(value);
            Console.ResetColor();
        }


        //
        // Stuff that Jeff actually wants bellow here
        //

        static void jeremy()
        {
            //Date calc method shit by me in here I guess
        }

        static void amber()
        {
            //Ambers awesome code here, thank god its not hand written
        }

        static void belinda()
        {
            //Belindas last minute but exceptional code here
        }
        static void jacob()
        {
            //Jacob brings beer and has an impressive beard
        }
    }
}