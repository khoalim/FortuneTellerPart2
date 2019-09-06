using System;

namespace FortuneTellerPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retirement Years Acitivity

            Console.WriteLine("How old are you?");
            int retirementAge;
            retirementAge = Convert.ToInt32(Console.ReadLine());

            if (retirementAge % 2 == 0)
            {
                Console.WriteLine("You have 10 years until retirement");
            }

            else
            {
                Console.WriteLine("You have 11 years until retirement");
            }

            // Vacation Home Location

            Console.WriteLine("How many siblings do you have?");
            int numSibling;
            numSibling = Convert.ToInt32(Console.ReadLine());

            if (numSibling < 0)
            {
                Console.WriteLine("Your vaction home will be in Chernobyl, Ukraine");
            }

            else if (numSibling <= 2)
            {
                Console.WriteLine("Your vacation home will be in Ponta Negra, Brazil");

            }

            else if (numSibling >= 3)
            {
                Console.WriteLine("Your vacation home will be in Baton Rouge, Louisiana");
            }

            // Mode of Transportation

            Console.WriteLine("What is your favorite color?");
            string faveColor = Console.ReadLine();

            if (faveColor.ToLower().Equals("red"))
            {
                Console.WriteLine("Your mode of transportation is a Maserati");
            }

            else if (faveColor.ToLower().Equals("orange"))
            {
                Console.WriteLine("Your mode of Transportation is a stallion");
            }

            else if (faveColor.ToLower().Equals("yellow"))
            {
                Console.WriteLine("Your mode of Transportation is a chariot");
            }

            else if (faveColor.ToLower().Equals("green"))
            {
                Console.WriteLine("Your mode of Transportation is a taxi");
            }

            else if (faveColor.ToLower().Equals("blue"))
            {
                Console.WriteLine("Your mode of Transportation is a rickshaw");
            }

            else if (faveColor.ToLower().Equals("indigo"))
            {
                Console.WriteLine("Your mode of Transportation is a motor scooter");
            }

            else if (faveColor.ToLower().Equals("violet"))
            {
                Console.WriteLine("Your mode of Transportation is a flying saucer");
            }

            // Bank Balance

            Console.WriteLine("What month were you born in?");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            if (birthMonth == 1 || birthMonth <= 4)
            {
                Console.WriteLine("Your bank balance is $256,000.76");
            }

            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                Console.WriteLine("Your bank balance is $3,687,105.42");
            }

            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                Console.WriteLine("Your bank balance is $4,123,105.42");
            }

            else if (birthMonth < 1 || birthMonth > 12)
            {
                Console.WriteLine("Your bank balance is $0.00");
            }

            // Part 3

            Console.WriteLine("Type display to find out your fortune below:");
            string displayLine = Console.ReadLine();

            if (displayLine.ToLower().Equals("display"))
            {
                Console.WriteLine("You will retire in " + retirementAge + " years");
            }




        }
    }
}
