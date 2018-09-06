using System;
namespace AveragerNamespace
{
    class Averager
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the program that calculates an average of all the provided numbers. Please provide the first number. To exit write \"quit\".");
            var newNumber = Console.ReadLine();
            var i = 0;
            var runningTotal = 0.0;
            while (newNumber.ToLower()!="quit")
            {
                if (double.TryParse(newNumber, out double ToBeAdded))
                {
                    runningTotal += ToBeAdded;
                    i++;
                }
                else
                Console.WriteLine("You provided something else than a number. Please try again or type \"quit\" to exit.");
                newNumber = Console.ReadLine();
            }
            if(i==0)
            Console.WriteLine("There is no average because you didn't provide any number. Bye.");
            else
            Console.WriteLine("The average is " + (runningTotal/i) + ".");
            Console.ReadLine();
        }
    }
}
