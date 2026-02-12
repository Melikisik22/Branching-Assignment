using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            string weightCheck = (weight > 50)
                ? "Package too heavy to be shipped via Package Express. Have a good day."
                : "";

            if (weightCheck != "")
            {
                Console.WriteLine(weightCheck);
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            string dimensionCheck = ((width + height + length) > 50)
                ? "Package too big to be shipped via Package Express."
                : "";

            if (dimensionCheck != "")
            {
                Console.WriteLine(dimensionCheck);
                return;
            }

            decimal quote = ((width * height * length) * weight) / 100m;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");
        }
    }
}
