using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasl1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTry and guess which is my favourite bird - Kiwi / Pheonix / Penguin");
            string bird = Console.ReadLine().ToLower();
            //The .ToLower() converts the whole sentence to lower case to prevent any issues around capitilisation.

            switch (bird)
            {
                /*A case statement for each option, they will run each line until they reach a break.*/
                case "kiwi":
                case "pheonix":
                    Console.WriteLine("Sorry wrong answer. ");
                    break;

                case "penguin":
                    Console.WriteLine("Yeah, you guessed right. ");
                    break;
                /*The default catches everything else that isnt one of the case's.*/
                default:
                    Console.WriteLine("Your way off...");
                    break;
            }
        }
    }
}
