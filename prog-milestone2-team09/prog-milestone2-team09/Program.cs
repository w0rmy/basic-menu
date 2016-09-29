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
                amber3();
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
            Color("1. Play a random guessing game  ", "Green");
            Console.Write(new string('\n', 1));
            Color("2. Return to main menu.   ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                jacob1();
                jacobsubmenu();
            }
            if (option == '2')
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



        static void amber1()
        {
            //Commented out to get to compile

            // need to set a format for the entering and readline of data
            //int mark1;
            //int mark2;
            //int mark3;
            //int mark4;
            //Console.WriteLine("enter your first paper code and mark");
            //mark1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your second paper code and mark");
            //mark2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your third paper code and mark");
            //mark3 = Convert.ToInt32(Console.ReadLine());
            // only level 5 have the next paper
            //Console.WriteLine("enter yourfourth paper code and mark");
            //mark4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sum);
            //avg = sum / 4;
            //Console.WriteLine("the avg is {0}", avg);
            //percentage = sum * 100 / 500;
            //Console.WriteLine("the percentage is {0}", percentage);
            //Console.WriteLine("Please enter your student ID number");
        }
        static string amberscore(int score)
        {
            if (score >= 90 && score <= 100)
            {
                return "A+";
            }
            else if (score >= 85 && score <= 89)
            {
                return "A";
            }
            else if (score >= 80 && score <= 84)
            {
                return "A-";
            }
            else if (score >= 75 && score <= 79)
            {
                return "B+";
            }
            else if (score >= 70 && score <= 74)
            {
                return "B";
            }
            else if (score >= 65 && score <= 69)
            {
                return "B-";
            }
            else if (score >= 60 && score <= 64)
            {
                return "C+";
            }
            else if (score >= 55 && score <= 59)
            {
                return "C";
            }
            else if (score >= 50 && score <= 54)
            {
                return "C-";
            }
            else if (score >= 40 && score <= 49)
            {
                return "D";
            }
            else if (score >= 0 && score <= 39)
            {
                return "E";
            }
            else
            {
                return "Invalid Input";
            }
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
            var ab = new Dictionary<string, int>();
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Enter a favourite food");
                string a = Console.ReadLine();
                Console.WriteLine("Rate the favourite food you just entered 1-5");
                int b = int.Parse(Console.ReadLine());
                ab.Add(a, b);


                i++;

                Console.Clear();

            }
            foreach (var x in ab)
            {
                Console.WriteLine($"{x.Key} & {x.Value}");
            }
        }
        static void belinda2()
        {
            //need to work out how to get dictionary method1

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
        }
    }
}