using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 2;
            string fullName = "-Joseph Myers";
            var today = DateTime.Now;
            string dailycups = "Cups of coffee drank today!";
            string userName = null;// I think this is a variable used to tell whether or not the user has entered input
            bool good = false;
            bool numberOne = false;
            bool numberTwo = false;
            string firstNumberAsString = null;
            string secondNumberAsString = null;



            Console.WriteLine("{0} {1} {2} {3}", numberOfCupsOfCoffee, dailycups, fullName, today);
            Console.WriteLine("Let's get to know you a bit better...");


            // I am piecing this together from things I found online. 
            Console.WriteLine("What's your name?:");
            userName = Console.ReadLine();
            good = !string.IsNullOrEmpty(userName); //I think the '!' is denoting the opposite of true/false. I don't quite understand what is modified before 'string'.
            if (!good)
                Console.WriteLine("Please tell me your name!"); //I'll fix this later. Got to move on.
            if (good)
                Console.WriteLine($"Hello, {userName}!");



            Console.WriteLine("Gimme a number!");
            firstNumberAsString = Console.ReadLine();
            numberOne = !string.IsNullOrEmpty(firstNumberAsString);
            if (numberOne)
                Console.WriteLine($"Good, {firstNumberAsString}!");
            if (!numberOne)
                Console.WriteLine("Uh oh! Try again."); //This doesn't work as intended. I left it in so I could come back and fix it.

            Console.WriteLine("Ok, let's have another number!");//The program stops here. I don't know why. -Because I hadn't added another ReadLine
            secondNumberAsString = Console.ReadLine();
            numberTwo = !string.IsNullOrEmpty(secondNumberAsString);
            if (numberTwo)
                Console.WriteLine($"Alright!, {secondNumberAsString} it is!");
            Console.WriteLine("Now hit 'Enter'!");
            if (!numberTwo)
                Console.WriteLine("Uh oh! Try again."); //Again, doesn't work. I want it to repeat until user inputs a number.

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;
            var presskey = "Press any key to continue..."; // I tried to make these one variable, but I couldn't figure it out.
            var readkey = Console.ReadKey(true); // Also couldn't figure out how to use this as a standalone variable and save any time at all.
            Console.WriteLine("Now for some 'computer magic'!");
            Console.WriteLine("~~*..*+++*..*~~");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine($"Your first number '{firstNumberAsString}' plus your second number '{secondNumberAsString}' is {sum}!");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine($"Your first number '{firstNumberAsString}' minus your second number '{secondNumberAsString}' is {difference}!");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine($"Your first number '{firstNumberAsString}' multiplied by your second number '{secondNumberAsString}' is {product}!");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine($"Your first number '{firstNumberAsString}' divided by your second number '{secondNumberAsString}' is {quotient}!");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine($"Your first and second numbers divided leave a remainder of {remainder}!");
            Console.WriteLine(presskey);
            Console.ReadKey(true);
            Console.WriteLine("Wow! Wasn't that incredible!?");
            Console.WriteLine($"{userName}, thanks so much for participating! Hope you had as much fun as I did!");
            Console.WriteLine("Press any key to end this program.");
            Console.ReadKey(true);



        }
    }
}
