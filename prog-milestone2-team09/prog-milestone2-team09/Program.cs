﻿using System;
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
        static void Main(string[] args)
        {
            acdc();
            mainmenu();
        }
        static void Color(string value, string colorChoice)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorChoice);
            Console.WriteLine(value);
            Console.ResetColor();
        }
        // She's a whole lotta woman, A whole lotta rosie!
        static void acdc()
        {
            var acdc = new SoundPlayer();
            acdc.Stream = prog_milestone2_team09.Properties.Resources.wlr;
            acdc.Play();
        }
        static void mainmenu()
        {
            int longtime = 2000;
            int shorttime = 1000;
            var menuchoice = '0';
            while (menuchoice == '0')
            {

                Console.Clear();
                Console.Write(new string('\n', 8));
                Color("Please select an Student:", "Yellow");
                Console.Write(new string('\n', 2));
                Color("1. Jeremy ", "Green");
                Color("2. Amber  ", "Magenta");
                Color("3. Belinda", "Red");
                Color("4. Jacob  ", "Blue");
                menuchoice = Console.ReadKey(false).KeyChar;
                switch (menuchoice)
                {
                    case '1':
                        jeremysubmenu();
                        menuchoice = '0';
                        break;
                    case '2':
                        ambersubmenu();
                        menuchoice = '0';
                        break;
                    case '3':
                        belindasubmenu();
                        menuchoice = '0';
                        break;
                    case '4':
                        jacobsubmenu();
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
        static void jeremysubmenu()
        {
            Console.Clear();
            Console.Write(new string('\n', 4));
            Color("Please Select an Application to run", "White");
            Console.Write(new string('\n', 1));
            Color("                      (`.-,')", "Gray");
            Color("                    .-'     ;", "Gray");
            Color("                _.-'   , `,- ", "Gray");
            Color("          _ _.-'     .'  /._ ", "Gray");
            Color("        .' `  _.-.  /  ,'._;)", "Gray");
            Color("       (       .  )-| (      ", "Gray");
            Color("        )`,_ ,'_,'  `_;)     ", "Gray");
            Color("('_  _,'.'  (___,))          ", "Gray");
            Color(" `-:;.-'                     ", "Gray");
            Console.Write(new string('\n', 1));
            Color("1. Calculate How many days old you are ", "Green");
            Color("2. Convert Years to Days               ", "Blue");
            Console.Write(new string('\n', 1));
            Color("3. Return to main menu.                ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                jeremy1();
                jeremysubmenu();
            }
            if (option == '2')
            {
                jeremy2();
                jeremysubmenu();
            }
            if (option == '3')
            {
                mainmenu();
            }
            else
            {
                Console.Clear();
                Console.Write(new string('\n', 10));
                Color("You have enetered an invalid entry, please try again", "White");
                Thread.Sleep(2000);
                jeremysubmenu();
            }
        }
        static void ambersubmenu()
        {
            Console.Clear();
            Console.Write(new string('\n', 4));
            Color("Please Select an Application to run", "White");
            Console.Write(new string('\n', 1));
            Color("         _ _         ", "Red");
            Color("       _{ ' }_       ", "Red");
            Color("      { `.!.` }      ", "Red");
            Color("      ',_/Y._,'      ", "Red");
            Color("        {_,_}        ", "Red");
            Color("          |          ", "Green");
            Color("         (|  /)      ", "Green");
            Color("          | //       ", "Green");
            Color("          |//        ", "Green");
            Color("       \\ |/  //     ", "Green");
            Color("   ^^^^^^^^^^^^^^^   ", "Green");
            Console.Write(new string('\n', 1));
            Color("1. Amber Application one  ", "Yellow");
            Color("2. Amber Application two  ", "Magenta");
            Color("3. Amber Application three", "Blue");
            Console.Write(new string('\n', 1));
            Color("4. Return to main menu.   ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                amber1();
                ambersubmenu();
            }
            if (option == '2')
            {
                amber2();
                ambersubmenu();
            }
            if (option == '3')
            {
                amber3();
                ambersubmenu();
            }
            if (option == '4')
            {
                mainmenu();
            }
            else
            {
                Console.Clear();
                Console.Write(new string('\n', 10));
                Color("You have enetered an invalid entry, please try again", "White");
                Thread.Sleep(2000);
                ambersubmenu();
            }
        }
        static void belindasubmenu()
        {
            Console.Clear();
            Console.Write(new string('\n', 4));
            Color("Please Select an Application to run", "White");
            Console.Write(new string('\n', 1));
            Color("       .---.'''.          ", "Cyan");
            Color("      /___/:(O:)`         ", "Cyan");
            Color("        `-`:::::/         ", "Cyan");
            Color("          //:::\\         ", "Cyan");
            Color("         {{:::::}}        ", "Cyan");
            Color("    ------;;---;;-------  ", "Gray");
            Color("            |||           ", "Cyan");
            Color("            |||           ", "Cyan");
            Color("            '|'           ", "Cyan");
            Console.Write(new string('\n', 1));
            Color("1. Belinda Application one  ", "Green");
            Color("2. Belinda Application two  ", "Magenta");
            Color("3. Belinda Application three", "Blue");
            Console.Write(new string('\n', 1));
            Color("4. Return to main menu.     ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                belinda1();
                belindasubmenu();
            }
            if (option == '2')
            {
                belinda2();
                belindasubmenu();
            }
            if (option == '3')
            {
                belinda3();
                belindasubmenu();
            }
            if (option == '4')
            {
                mainmenu();
            }
            else
            {
                Console.Clear();
                Console.Write(new string('\n', 10));
                Color("You have enetered an invalid entry, please try again", "White");
                Thread.Sleep(2000);
                belindasubmenu();
            }
        }
        static void jacobsubmenu()
        {
            Console.Clear();
            Console.Write(new string('\n', 4));
            Color("Please Select an Application to run", "White");
            Console.Write(new string('\n', 1));
            Color("      ( o )o)           ", "White");
            Color("     ( o )o )o)         ", "White");
            Color("    (o( ~~~~~~~~o       ", "White");
            Color("   ( )|)       |-.      ", "DarkGray");
            Color("     o|        |-. `    ", "DarkGray");
            Color("     o|        |  ` `   ", "DarkGray");
            Color("      |        |   | |  ", "DarkGray");
            Color("     o|        |  / /   ", "DarkGray");
            Color("      |        |.' '    ", "DarkGray");
            Color("      |        |- '     ", "DarkGray");
            Color("      .========.        ", "DarkGray");
            Console.Write(new string('\n', 1));
            Color("1. Jacob Application one  ", "Green");
            Color("2. Jacob Application two  ", "Magenta");
            Color("3. Jacob Application three", "Blue");
            Console.Write(new string('\n', 1));
            Color("4. Return to main menu.   ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                jacob1();
                jacobsubmenu();
            }
            if (option == '2')
            {
                jacob2();
                jacobsubmenu();
            }
            if (option == '3')
            {
                jacob3();
                jacobsubmenu();
            }
            if (option == '4')
            {
                mainmenu();
            }
            else
            {
                Console.Clear();
                Console.Write(new string('\n', 10));
                Color("You have enetered an invalid entry, please try again", "White");
                Thread.Sleep(2000);
                jacobsubmenu();
            }
        }
        static void jeremy1()
        {
            Console.Clear();
            Console.Write(new string('\n', 4));
            Color("Please enter your birthdate YYYY/MM/DD", "White");
            Console.SetCursorPosition((Console.WindowWidth - 10) / 2, Console.CursorTop);
            var birthDate = DateTime.Parse(Console.ReadLine());
            var daysOld = (DateTime.Now - birthDate);
            var stringDays = daysOld.ToString();
            string[] days = stringDays.Split('.');
            Console.Write(new string('\n', 2));
            Color($"You are {days[0]} days old", "Green");
            Console.Write(new string('\n', 4));
            Color("Press any key to continue.", "White");
            Console.ReadKey();
        }
        static void jeremy2()
        {
            // Commented out. This shows I know how to achieve the result using DateTime. But that I believe I can find cleaner code using simple math.
            //Console.Clear();
            //Console.Write(new string('\n', 8));
            //Color("Please enter a number of years.", "White");
            //Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.CursorTop);
            //int years = int.Parse(Console.ReadLine());
            //var date = DateTime.Now;
            //var newdate = date.AddYears(-years);
            //var span = (date - newdate);
            //var stringDays = span.ToString();
            //string[] days = stringDays.Split('.');
            //Console.Write(new string('\n', 2));
            //Color($"That is {days[0]} days", "Green");
            //Console.Write(new string('\n', 4));
            //Color("Press any key to continue.", "White");
            //Console.ReadKey();

            Console.Clear();
            Console.Write(new string('\n', 8));
            Color("Please enter a number of years.", "White");
            Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.CursorTop);
            int years = int.Parse(Console.ReadLine());
            int span = years * 365;
            int leaps = years / 4;
            Color($"That is " + (span + leaps) + " days", "Green");
            Console.Write(new string('\n', 4));
            Color("Press any key to continue.", "White");
            Console.ReadKey();
        }
        //
        // Filer Methods until others have their code
        //
        static string CalculateGrade(int Score)
        // Console.Clear();
        // Console.Write(new string('\n', 10));///('\n', 10) prints out 10x
        //Color("Amber method one.", "White");
        //Thread.Sleep(2000);

        {
                if (Score >= 90 && Score <= 100)
                {
                    return "A+";
                }
                else if (Score >= 85 && Score <= 89)
                {
                    return "A";
                }
                else if (Score >= 80 && Score <= 84)
                {
                    return "A-";
                }
                else if (Score >= 75 && Score <= 79)
                {
                    return "B+";
                }
                else if (Score >= 70 && Score <= 74)
                {
                    return "B";
                }
                else if (Score >= 65 && Score <= 69)
                {
                    return "B-";
                }
                else if (Score >= 60 && Score <= 64)
                {
                    return "C+";
                }
                else if (Score >= 55 && Score <= 59)
                {
                    return "C";
                }
                else if (Score >= 50 && Score <= 54)
                {
                    return "C-";
                }
                else if (Score >= 40 && Score <= 49)
                {
                    return "D";
                }
                else if (Score >= 0 && Score <= 39)
                {
                    return "E";
                }
                else
                {
                    return "Invalid Input";
                }
            }
        static void amber2()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Amber method two.", "White");
            Thread.Sleep(2000);
        }
        static void amber3()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Amber method three.", "White");
            Thread.Sleep(2000);
        }
        static void belinda1()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Belinda method one.", "White");
            Thread.Sleep(2000);
        }
        static void belinda2()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Belinda method two.", "White");
            Thread.Sleep(2000);
        }
        static void belinda3()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Belinda method three.", "White");
            Thread.Sleep(2000);
        }
        static void jacob1()
        {

            Console.Clear();

            int score = 0;

            int i = 1;
            while (i < 6)
            {

                Color("You get 5 chances to pick a random number Correcly", "Gray");
                Color($"Guess: {i}", "Gray");
                Console.WriteLine();
                int number = 0; // Just to make sure a new random is being generated
                Color("Please enter a number between 1 and 5", "Gray");
                Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.CursorTop);
                int guess = int.Parse(Console.ReadLine());
                Random r = new Random();
                number = r.Next(1, 5);
                Color($"The answer was: {number}", "Gray");
                if (guess == number)
                {
                    score++;
                }
                i++;
                Thread.Sleep(2300);
                Console.Clear();
            }
            Console.WriteLine();
            Color($"You guessed {score} correct", "Gray");
            Console.WriteLine();
            jacob2();

        }
        static void jacob2()
        {

            Color("Would you like to play again?  y/n", "Gray");
            var answer = Console.ReadKey(false).KeyChar;

            if (answer == 'y')

            {
                jacob1();
            }
            
            //Console.Clear();
            //Console.Write(new string('\n', 10));
            //Color("Jacob method two.", "White");
            //Thread.Sleep(2000);
        }
        static void jacob3()
        {
            Console.Clear();
            Console.Write(new string('\n', 10));
            Color("Jacob method three.", "White");
            Thread.Sleep(2000);
        }
    }
}