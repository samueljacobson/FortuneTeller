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

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month? Please enter as a digit.");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favortie ROYGBIV color? If you do not know what ROYGBIV is, enter \"Help\"");
            string color = Console.ReadLine();
            if (color == "Help")
            {
                Console.WriteLine("ROYGBIV is an acronym for the following colors: \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");
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
            if (age % 2 == 0)
            {
                retirement = 10;
            }
            else
            {
                retirement = 5;
            }

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

            if (color == "red" || color == "violet")
            {
                transportation = "sailboat";
            }
            else if (color == "orange" || color == "blue")
            {
                transportation = "Ferrari";
            }
            else if (color == "yellow" || color == "green")
            {
                transportation = "stagecoach";
            }
            else
            {
                transportation = "Lear jet";
            }

            if (birthMonth >=1 && birthMonth <= 4)
            {
                funds = 100d;
            }
            else if (birthMonth >=5 && birthMonth <=8)
            {
                funds = 50000d;
            }
            else if (birthMonth >=9 && birthMonth <=12)
            {
                funds = 9000d;
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
