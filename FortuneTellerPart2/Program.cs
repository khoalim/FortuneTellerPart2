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
               

        }
    }
}
