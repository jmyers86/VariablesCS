using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 2;
            string fullName = "Joseph Myers";
            var today = DateTime.Today;
            Console.WriteLine("{0} {1} {2}", numberOfCupsOfCoffee, fullName, today);
        }
    }
}
