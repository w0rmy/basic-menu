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
            Console.Write(new string('\n', 1));
            Color("2. Return to main menu.   ", "White");
            var option = Console.ReadKey(false).KeyChar;

            if (option == '1')
            {
                amber1();
                ambersubmenu();

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
            Color("1. Rate some foods  ", "Green");
            Color("2. View your foods  ", "Magenta");
            Console.Write(new string('\n', 1));
            Color("3. Return to main menu.     ", "White");
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
<<<<<<< HEAD



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
        static void amberscore(int score)
        {
            //  Console.WriteLine(sum);
            //  avg = sum / 4;
            //  Console.WriteLine("the avg is {0}", avg);
            //  percentage = sum * 100 / 500;
            //  Console.WriteLine("the percentage is {0}", percentage);
            //  Console.WriteLine("Please enter your student ID number");
            int[] array = new int[4];

            int count = 1;

            do
            {
                Console.Write("Enter grade {0}: ", count);
              //  array.Add(int.Parse(Console.ReadLine()));
                count++;
            } while (count <= 4);

            // decimal grade = ComputeGrade(array);
            //char gradeLetter = LetterGrade(grade);
            //Console.WriteLine("Your Grade Letter is {0}.", amber2());
            Console.Read();
        }

        static string amber2(int score)

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

        static void belinda1()
        {
            food();
        }

        static void food()
        {
            var fr = new Dictionary<string, int>();
            int i = 0;
            while (i < 5)
            {
                Console.Clear();
                Color("Enter a favourite food of yours", "White");
                string f = Console.ReadLine();
                Color("Now rate that favourite food between 1-5", "White");
                int r = int.Parse(Console.ReadLine());
                fr.Add(f, r);

                i++;

                Console.Clear();
            }
            foreach (var a in fr)
            {
                Console.WriteLine($"{a.Key} - {a.Value}");
            }
            Console.Clear();
=======
        //
        // Filer Methods until others have their code
        // Console.Clear();
        // Console.Write(new string('\n', 10));///('\n', 10) prints out 10x
        //Color("Amber method one.", "White");
        //Thread.Sleep(2000);

      
            static void Amber()
            // If more time would have considered using temporary variables to collect the data 
            //followed by the program logi that can be accessed multiple places
            //then logic calculations
        // The Method; What we want to do and how often is near the top,the tasks computer does on its own as part of task and what user sees on screen have been made clearer.
            {
                Dictionary<Dictionary<string, string>, Dictionary<string, int>> gradeDict = new Dictionary<Dictionary<string, string>, Dictionary<string, int>>();
                List<string> paperCodes = new List<string>();
                List<int> gradeList = new List<int>();
                List<string> letterGrades = new List<string>();
                gradeDict = setGrades();
                paperCodes = getPaperCodes(gradeDict);
                gradeList = getGradeInfo(gradeDict);
                letterGrades = getLetterGrades(gradeList);
                printGrades(gradeDict, paperCodes, gradeList, letterGrades);
                calculateAverage(gradeList);
                listA(gradeList, paperCodes);
                Console.ReadKey();
            }

            public static List<string> getPaperCodes(Dictionary<Dictionary<string, string>, Dictionary<string, int>> x)
            {
                Dictionary<string, int> paperInfo = new Dictionary<string, int>();
                List<string> paperCodes = new List<string>();
                Dictionary<string, string> levelID = x.Keys.ElementAt(0);
                x.TryGetValue(levelID, out paperInfo);

                foreach (KeyValuePair<string, int> entry in paperInfo)
                {
                    paperCodes.Add(entry.Key);
                }

                return paperCodes;
            }

            public static List<int> getGradeInfo(Dictionary<Dictionary<string, string>, Dictionary<string, int>> x)
            {
                Dictionary<string, int> paperInfo = new Dictionary<string, int>();
                List<int> gradeInfo = new List<int>();
                Dictionary<string, string> levelID = x.Keys.ElementAt(0);
                x.TryGetValue(levelID, out paperInfo);

                foreach (KeyValuePair<string, int> entry in paperInfo)
                {
                    gradeInfo.Add(entry.Value);
                }

                return gradeInfo;
            }

            public static List<string> getLetterGrades(List<int> x)
            {
                List<string> letterGrades = new List<string>();

            // Waikato Grade Scale has been used 2016,(waikato.ac.nz/sasd/files/pdf/gradescale.pdf)
                foreach (int i in x)
                {
                    string letterGrade;
                    if (i >= 90)
                    {
                        letterGrade = "A+";
                    }
                    else if (i <= 89 && i >= 85)
                    {
                        letterGrade = "A";
                    }
                    else if (i <= 84 && i >= 80)
                    {
                        letterGrade = "A-";
                    }
                    else if (i <= 79 && i >= 75)
                    {
                        letterGrade = "B+";
                    }
                    else if (i <= 74 && i >= 70)
                    {
                        letterGrade = "B";
                    }
                    else if (i <= 69 && i >= 65)
                    {
                        letterGrade = "B-";
                    }
                    else if (i <= 64 && i >= 60)
                    {
                        letterGrade = "C+";
                    }
                    else if (i <= 59 && i >= 55)
                    {
                        letterGrade = "C";
                    }
                    else if (i <= 54 && i >= 50)
                    {
                        letterGrade = "C-";
                    }
                    else if (i <= 49 && i >= 40)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "E";
                    }

                    letterGrades.Add(letterGrade);
                }

                return letterGrades;
            }

            public static void printGrades(Dictionary<Dictionary<string, string>, Dictionary<string, int>> gradeDict, List<string> paperCodes, List<int> gradeInfo, List<string> letterInfo)
            {
                Dictionary<string, string> levelID = new Dictionary<string, string>();
                string studentID;
                string level;
                levelID = gradeDict.Keys.ElementAt(0);
                studentID = levelID.Keys.ElementAt(0);
                level = levelID.Values.ElementAt(0);

                Console.WriteLine($"Student ID: {studentID}");
                Console.WriteLine($"Grade Level: {level}");
                Console.WriteLine($"Paper Subjects: {String.Join(",", paperCodes)}");
                Console.WriteLine($"Paper Percentages: {String.Join(",", gradeInfo)}");
                Console.WriteLine($"Paper Letter Grades: {String.Join(",", letterInfo)}");
            }

            public static void calculateAverage(List<int> x)
            {
                double average = 0;
                int sum = 0;

                foreach (int i in x)
                {
                    sum += i;
                }

                average = sum / x.Count();
                Console.WriteLine($"Your average grade mark is: {average}");

                if (average <= 100 && average >= 50)
                {
                    Console.WriteLine($"Congradulations you have passed you level of study!  You may continue into the next level of your study pathway. ");
                }
                else
                {
                    Console.WriteLine($"I am sorry but the total of all your papers is not 50% so you do not pass.  Look into resiting the papers you did not pass. ");
                }
            }

            public static void listA(List<int> gradeInfo, List<string> paperCodes)
            {
                List<string> highSubjects = new List<string>();

                for (int i = 0; i < gradeInfo.Count(); i++)
                {
                    if (gradeInfo.ElementAt(i) >= 90)
                    {
                        highSubjects.Add(paperCodes.ElementAt(i));
                    }
                }

                if (highSubjects.Count() > 0)
                {
                    Console.WriteLine($"Outstanding you achieved an 'A+' letter grade in the following subjects: {String.Join(", ", highSubjects)}");
                }
                else
                {
                    Console.WriteLine($"You did not score an 'A+' in any subject.");
                    Console.WriteLine($"Get sum better study methods via the learning facilitators or actually study!");
                }
            }

            public static Dictionary<Dictionary<string, string>, Dictionary<string, int>> setGrades()   
            // Method to ask user level of study, 4/3 papers user imput, student ID and marks from user
        {
                int paperAmount = 0;
                bool validCheck = true;
                string level = "";
                Dictionary<string, string> levelID = new Dictionary<string, string>();
                Dictionary<string, int> paperInfo = new Dictionary<string, int>();
                Dictionary<Dictionary<string, string>, Dictionary<string, int>> gradeInfo = new Dictionary<Dictionary<string, string>, Dictionary<string, int>>();

                while (validCheck)
                {
                    Console.WriteLine($"Did you pass your level of study?");
                    Console.WriteLine($"Please enter 5 for level 5, or enter 6 for level 6: ");
                    level = Console.ReadLine();

                    if (level == "6")
                    {
                        paperAmount = 3;
                        validCheck = false;
                    }
                    else if (level == "5")
                    {
                        paperAmount = 4;
                        validCheck = false;
                    }
                    else
                    {
                        Console.WriteLine($"Error: Please enter a valid level. Please enter 5 for level 5, or enter 6 for level 6:");
                    }
                }

                for (int i = 0; i < paperAmount; i++)
                {
                    Console.WriteLine($"Please enter paper code, thank you. : "); //To use this as a reference instead of getting some info reentered ideal
                    string paperCode = Console.ReadLine();
                    paperInfo.Add(paperCode, 0);
                }

                Console.WriteLine($"Please Enter your Student ID Number: ");
                string studentID = Console.ReadLine();

                for (int i = 0; i < paperAmount; i++)
                {
                    validCheck = true;
                    while (validCheck)
                    {
                        Console.WriteLine($"Please re-enter a paper code (as above): "); //Not tidy UI this could be updated in the future
                        string paperCode = Console.ReadLine();
                        int paperGrade = 0;

                        if (paperInfo.TryGetValue(paperCode, out paperGrade))
                        {
                            paperGrade = 0;
                            bool gradeCheck = true;

                            while (gradeCheck)
                            {
                                Console.WriteLine($"Please enter the mark you recieved for that paper: ");
                                try
                                {
                                    paperGrade = int.Parse(Console.ReadLine());

                                    if (paperGrade <= 100 && paperGrade >= 0)
                                    {
                                        paperInfo.Remove(paperCode);
                                        paperInfo.Add(paperCode, paperGrade);
                                        gradeCheck = false;
                                    }
                                    else
                                    {


                                        Console.WriteLine($"Error: Please enter an integer between 0 and 100.");

                                    }

                                }

                                catch (FormatException)
                                {
                                    Console.WriteLine($"Error: Invalid Grade.");
                                }
                            }

                            validCheck = false;
                        }
                        else
                        {
                            Console.WriteLine($"Error: Paper code not found. ");
                        }
                    }
                }
                levelID.Add(studentID, level);
                gradeInfo.Add(levelID, paperInfo);
                return gradeInfo;
            }
        }
    }

static void belinda2()
        {
            //need to work out how to get dictionary method1
>>>>>>> remotes/amber_johnsen/prog-milestone2-team09/master

        } //method one ends 
    
    static void belinda2()
    {
         }
        static void food(Dictionary<string, int> someDictionary)
        {
            {

                Color("Would you like to display your favourite food in order of rate \"Y\" for yes or \"N\" for no", "White");
                var pick = (Console.ReadLine());

                if (pick == "Y")
                {
                    //under finished

                    Console.WriteLine("");
                }
                else if (pick == "N")
                {
                    Console.WriteLine("");

                }

            }
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