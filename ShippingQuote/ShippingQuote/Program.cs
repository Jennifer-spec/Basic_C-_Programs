using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please input the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please input the package's width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the package's height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the package's length:");
                int length = Convert.ToInt32(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");// the program is over
                }
                else
                {
                    int product = (width * height * length * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:$" + product);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                    //the program is over here
                }
            }
        }
    }
}
