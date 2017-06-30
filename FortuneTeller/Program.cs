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
            Console.WriteLine("Welcome to the Fortune Teller! Enter the below information to know your future.");

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


            if (age % 2 == 0)
            {
                int retirement = 10;
            }
            else
            {
                int retirement = 5;
            }

            if (siblings == 0)
            {
                string vacation = "Tahiti";
            }
            else if (siblings == 1)
            {
                string vacation = "Tuscany";
            }
            else if (siblings == 2)
            {
                string vacation = "Thailand";
            }
            else if (siblings >= 3)
            {
                string vacation = "Zanzibar";
            }
            else
            {
                string vacation = "refrigertor box";
            }

            if (color == "red" || color == "violet")
            {
                string transportation = "sailboat";
            }
            else if (color == "orange" || color == "blue")
            {
                string transportation = "Ferrari";
            }
            else if (color == "yellow" || color == "green")
            {
                string transportation = "stagecoach";
            }
            else
            {
                string transportation = "Lear jet";
            }

            if (birthMonth >=1 && birthMonth <= 4)
            {
                double funds = 100d;
            }
            else if (birthMonth >=5 && birthMonth <=8)
            {
                double funds = 50000d;
            }
            else if (birthMonth >=9 && birthMonth <=12)
            {
                double funds = 9000d;
            }
            else
            {
                double funds = 0.00d;
            }
        }
    }
}
