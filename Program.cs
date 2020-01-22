using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Room Detail Generator!");
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write("Please enter the width of the room you want to measure: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Please enter the length of the room you want to measure: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("What is the height of the room you want to measure: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of your room is {width * length}");
                Console.WriteLine($"The perimeter of your room is {2 * width + 2 * length}");
                Console.WriteLine($"The volume of your room is {length * width * height}");
                Console.Write("Would you like to continue [y/n]?");
                string doItAgain = Console.ReadLine();
                if (doItAgain != "y" && doItAgain != "N")
                {
                    keepGoing = false;
                }
            }
            Console.WriteLine("GoodBye");
        }
    }
}
