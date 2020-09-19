using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Where will you travel to?");
            string destination = Console.ReadLine();

            Console.WriteLine("How will you get there?");
            string transportation = Console.ReadLine();

            Console.WriteLine("When do you plan to go on your trip?");
            string timeOfYear = Console.ReadLine();

            Console.WriteLine("Are you planning on inviting friends with you? " + "A few couples may be fun, they said..!");
            string funRetreat = Console.ReadLine();

            Console.WriteLine("What type of excursions do you like?");
            string funInTheSun = Console.ReadLine();

            Console.WriteLine("What's your favorite type of cuisine?");
            string somethingForTheSoul = Console.ReadLine();

            Console.WriteLine("Beach or Pool");
            string swimForFun = Console.ReadLine();

            Console.WriteLine("Hotel or Air Bnb");
            string accommodations = Console.ReadLine();

            Console.WriteLine("What is the budget you're working with");
            string budgetTracker = Console.ReadLine();

            Console.WriteLine("What will be the total cost per person");
            string costBeforeTax = Console.ReadLine();

            Console.WriteLine($"Once you know {destination} is the place, it's recommended to do some research before you get there.");
            Console.WriteLine($"Whether a {transportation} or otherwise, you may want to consider a bundled package with a travel site to save money.");
            Console.WriteLine($"Traveling during {timeOfYear} is quite the experience!");
            Console.WriteLine
            ($"Look up what's available to do in {destination}, see if {funInTheSun} is an option, then find out if there are some deals during {timeOfYear}.");
            Console.WriteLine
            ($"Make sure there are {somethingForTheSoul} restaurants close to the area you'll be staying while in {destination}, " +
            $"otherwise, be prepared for different options.");
            Console.WriteLine
            ($"Be sure to bring your bathing suit and some tanning lotion to truly enjoy the {swimForFun}.");
            Console.WriteLine($"Remember a bundled package for your {accommodations} may be kind to your wallet.");
            Console.WriteLine($"{budgetTracker} is a good cushion to work with.");
            Console.WriteLine
            ($"Be sure to check how much the taxes will be and add that to the {costBeforeTax}, to determine if you need to save more before your trip.");

            Console.WriteLine("SubTotal before taxes.");
            int subTotal = int.Parse(Console.ReadLine());

            Console.WriteLine("Taxes to add");
            int taxes = int.Parse(Console.ReadLine());

            int total = (subTotal + taxes);
            Console.WriteLine($"The total after taxes: {total}.");

            Console.WriteLine("Number of people going on the trip.");
            int travelers = int.Parse(Console.ReadLine());

            int multiplication = Multiply(total, travelers);
            Console.WriteLine($"The total amount for all parties: {multiplication}");
        }
        public static int Multiply(int total, int travelers)
        {
            return total * travelers;
        }
    }
}
