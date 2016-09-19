using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_milestone2_team06
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 2000;
            var menuchoice = "m";

            while (menuchoice == "m")
            {

                Console.Clear();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("a. Jeremy");
                Console.WriteLine("b. Amber");
                Console.WriteLine("c. Belinda");
                Console.WriteLine("d. Jacob");

                menuchoice = Console.ReadLine();
                menuchoice = menuchoice.ToLower();

                switch (menuchoice)
                {
                    case "a":
                        Console.Clear();
                        // Call Jeremy Method here
                        Console.WriteLine("Jeremys Method will run here");
                        System.Threading.Thread.Sleep(milliseconds);
                        menuchoice = "m";
                        break;
                    case "b":
                        Console.Clear();
                        // Call Amber Method here
                        Console.WriteLine("Ambers Method will run here");
                        System.Threading.Thread.Sleep(milliseconds);
                        menuchoice = "m";
                        break;
                    case "c":
                        Console.Clear();
                        // Call Belinda Method here
                        Console.WriteLine("Belindas Method will run here");
                        System.Threading.Thread.Sleep(milliseconds);
                        menuchoice = "m";
                        break;
                    case "d":
                        Console.Clear();
                        // Call Belinda Method here
                        Console.WriteLine("Jacobs Method will run here");
                        System.Threading.Thread.Sleep(milliseconds);
                        menuchoice = "m";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Sorry, invalid selection.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("You will now return to the main menu");
                        System.Threading.Thread.Sleep(milliseconds);
                        menuchoice = "m";
                        break;
                }
            }
        }

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