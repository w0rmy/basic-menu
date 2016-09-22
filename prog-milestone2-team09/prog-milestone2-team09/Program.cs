using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prog_milestone2_team06
{
    class Program
    {
        //
        // Some wanky color shit and centering for the menu. 
        // 
        static void Color(string value, string colorChoice)
        {
            // Center Text. Take window size minus String lengh and devide by 2 and leave at top.
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            // Not 100% sure on how Enum.Parse works, but it works.
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorChoice);
            Console.WriteLine(value);
            Console.ResetColor();
        }
        //
        // She's a whole lotta woman, A whole lotta rosie!
        //
        static void acdc()
        {
            var acdc = new SoundPlayer();
            acdc.Stream = prog_milestone2_team09.Properties.Resources.wlr;
            acdc.Play();
        }

        static void Main(string[] args)
        {
            acdc();

            int longtime = 2000;
            int shorttime = 1000;
            var menuchoice = '0';  

            //
            // The actual menu. While and switch method.
            //

            while (menuchoice == '0')
            {

                Console.Clear();
                Console.Write(new string('\n', 8));
                Color("Please select an option:", "Yellow");
                Console.Write(new string('\n', 2));
                Color("1. Jeremy ", "Green");
                Color("2. Amber  ", "Magenta");
                Color("3. Belinda", "Red");
                Color("4. Jacob  ", "Blue");

                menuchoice = Console.ReadKey(false).KeyChar;

                switch (menuchoice)
                {
                    case '1': 
                        Console.Clear();
                        Console.Write(new string('\n', 10));
                        Color("Jeremys Method will run here", "Green"); // Call Jeremy Method here
                        Thread.Sleep(longtime);
                        Console.Clear();
                        jeremy();
                        menuchoice = '0';
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write(new string('\n', 10));
                        Color("Ambers Method will run here", "Magenta"); // Call Amber Method here
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write(new string('\n', 10));
                        Color("Belindas Method will run here", "Red"); // Call Belinda Method here
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write(new string('\n', 10));
                        Color("Jacobs Method will run here", "Blue"); // Call Jacob Method here
                        Thread.Sleep(longtime);
                        menuchoice = '0';
                        break;
                    default:
                        Console.Clear();
                        Console.Write(new string('\n', 10));
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
        // Stuff that Jeff actually wants bellow here
        //

        static void jeremy()
        {
            // Allow the user to type in their date of birth 
            Console.Write(new string('\n', 8));
            Color("Please enter your birthdate YYYY/MM/DD", "White");
            Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.CursorTop);
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            // Tell the user how many days old they are 
            var daysOld = DateTime.Now - birthDate;            
            Color($"your birthdate is {birthDate}. Todays date is " + DateTime.Now + $" and you are {daysOld} days old", "Green");
            Console.ReadLine();
        }
        static void jeremy2()
        { 
            // Create a method that takes a number (which will be the number of years) 
            // Allow the user to type in that number which will be used in a calculation 
            // Tell the user how many days the amount of years are that the user typed in 
            // Note that if you for example do the straight calculation  20 * 365 the answer will be wrong 
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