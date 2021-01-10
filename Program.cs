using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 2;
            string fullName = "Joseph Myers";
            var today = DateTime.Now;
            string dailycups = "Cups of coffee drank today!";
            string input = null;// I think this is a variable used to tell whether or not the user has entered input
            bool good = false;

            Console.WriteLine("{0} {1} {2} {3}", numberOfCupsOfCoffee, dailycups, fullName, today);

            while (!good)// so while the true/false variable is true. The double-negatives are making my brain hurt.
            {
                // I am piecing this together from things I found online. 
                Console.WriteLine("What's your name?:");
                input = Console.ReadLine();
                good = !string.IsNullOrEmpty(input); //I think the '!' is denoting the opposite of true/false. I don't quite understand what is modifies before 'string'.
                if (!good)
                    Console.WriteLine("Please tell me your name!");
            }
            while (good) // i think this is checking to see if the user has entered something.
            {
                good = string.IsNullOrEmpty(input);
                if (good)
                    Console.WriteLine("Hello!,(input)");//I'm trying to check if the user has entered an input- and if they have- print a greeting with their input included.
            }
        }
    }
}
