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
                Color("Please select an option:", "Yellow");
                Console.WriteLine();
                Color("1. Jeremy ", "Green");
                Color("2. Amber  ", "Magenta");
                Color("3. Belinda", "Red");
                Color("4. Jacob  ", "Blue");

                menuchoice = Console.ReadKey(false).KeyChar;

                switch (menuchoice)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Jeremy Method here
                        Color("Jeremys Method will run here", "Green");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Amber Method here
                        Color("Ambers Method will run here", "Magenta");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Belinda Method here
                        Color("Belindas Method will run here", "Red");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine();
                        // Call Jacob Method here
                        Color("Jacobs Method will run here", "Blue");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Color("Sorry, invalid selection.", "White");
                        Thread.Sleep(shorttime);
                        Color("You will now return to the main menu", "White");
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                }
            }
        }

        //
        // Some wanky color shit and centering for the menu. 
        // 

        static void Color(string value, string colorChoice)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorChoice);
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