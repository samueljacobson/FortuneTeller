using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - asking for user input
            Console.WriteLine("Welcome to the Fortune Teller! Enter the below information to learn your future.");
            Console.WriteLine("At any time you may enter \"Quit\" to close the program.");

            Console.WriteLine("\nWhat is your first name?");
            string firstName = Console.ReadLine();
            if (firstName.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            if (lastName.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine()); //Unable to figure out how to accept "quit" (a string) when asking for an int

            Console.WriteLine("What is your birth month? Please enter as a digit.");
                int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\"");
                string color = Console.ReadLine();
                if (color.Equals("Help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ROYGBIV is an acronym for the following colors: \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");
                    Console.WriteLine("\nPlease enter your choice from the above.");
                    color = Console.ReadLine();
                }
                if (color.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }

            Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());


                //Part 2 - calculations on user input
                //Declare variables
                int retirement;
                string vacation;
                string transportation;
                double funds;

                //Values of variables determined based upon conditionals
                //Retirement age
                if (age % 2 == 0)
                {
                    retirement = 10;
                }
                else
                {
                    retirement = 5;
                }

                //Vacation house
                if (siblings == 0)
                {
                    vacation = "Tahiti";
                }
                else if (siblings == 1)
                {
                    vacation = "Tuscany";
                }
                else if (siblings == 2)
                {
                    vacation = "Thailand";
                }
                else if (siblings >= 3)
                {
                    vacation = "Zanzibar";
                }
                else
                {
                    vacation = "a refrigertor box";
                }

                //Transportation mode
                if (color.Equals("red", StringComparison.OrdinalIgnoreCase) || color.Equals("violet", StringComparison.OrdinalIgnoreCase))
                {
                    transportation = "sailboat";
                }
                else if (color.Equals("orange", StringComparison.OrdinalIgnoreCase) || color.Equals("blue", StringComparison.OrdinalIgnoreCase))
                {
                    transportation = "Ferrari";
                }
                else if (color.Equals("yellow", StringComparison.OrdinalIgnoreCase) || color.Equals("green", StringComparison.OrdinalIgnoreCase))
                {
                    transportation = "stagecoach";
                }
                else
                {
                    transportation = "Lear jet";
                }

                //Bank account
                if (birthMonth >= 1 && birthMonth <= 4)
                {
                    funds = 100.00d;
                }
                else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    funds = 50000.00d;
                }
                else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    funds = 9000.00d;
                }
                else
                {
                    funds = 0.00d;
                }


                //Part 3 - display fortune based upon above calculations
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retirement + " years with $" + funds + " in the bank, a vacation home in " + vacation + ", and a " + transportation + ".");
            }
        }
    }