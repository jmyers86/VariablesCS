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
            string userName = null;// I think this is a variable used to tell whether or not the user has entered input
            bool good = false;
            bool numberOne = false;
            bool numberTwo = false;
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine("{0} {1} {2} {3}", numberOfCupsOfCoffee, dailycups, fullName, today);


            // I am piecing this together from things I found online. 
            Console.WriteLine("What's your name?:");
            userName = Console.ReadLine();
            good = !string.IsNullOrEmpty(userName); //I think the '!' is denoting the opposite of true/false. I don't quite understand what is modifies before 'string'.
            if (!good)
                Console.WriteLine("Please tell me your name!");
            if (good)
                Console.WriteLine($"Hello, {userName}!");

            Console.WriteLine("Gimme a number!");
            firstNumberAsString = Console.ReadLine();
            numberOne = !string.IsNullOrEmpty(firstNumberAsString);
            if (numberOne)
                Console.WriteLine($"Good,{firstNumberAsString}!");
            if (!numberOne)
                Console.WriteLine("Uh oh! Try again.");

            Console.WriteLine("Ok, let's have another number!");
            secondNumberAsString = Console.ReadLine();
            numberTwo = !string.IsNullOrEmpty(secondNumberAsString);
            if (numberTwo)
                Console.WriteLine($"Alright!, {secondNumberAsString} it is!");
            if (!numberTwo)
                Console.WriteLine("Uh oh! Try again.");








        }
    }
}
