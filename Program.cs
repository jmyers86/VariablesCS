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
            Console.WriteLine("{0} {1} {2} {3}", numberOfCupsOfCoffee, dailycups, fullName, today);
        }
    }
}
