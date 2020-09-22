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
            ($"Make sure there are {somethingForTheSoul} restaurants close to the area you'll be staying in {destination}, " +
            $"otherwise, be prepared for different options.");
            
            Console.WriteLine
            ($"Be sure to bring your bathing suit and some tanning lotion to truly enjoy the {swimForFun}.");
            
            Console.WriteLine($"Remember a bundled package for your {accommodations} may be kind to your wallet.");
            
            Console.WriteLine($"{budgetTracker} is a really good amount to work with.");
            
            Console.WriteLine
            ($"Be sure to check how much the taxes will be to determine if you need to save more money before your trip.");

            Console.WriteLine("SubTotal before taxes.");
            double subTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Taxes to add");
            double taxes = double.Parse(Console.ReadLine());

            double total = (subTotal + taxes);
            Console.WriteLine($"The total after taxes: {total}.");

            TravelDollars neededRetreat = new TravelDollars();
            Console.WriteLine("Trip total");

            var budgetToWorkWith = double.Parse(Console.ReadLine());
            neededRetreat.TransactionTotal(budgetToWorkWith);
            Console.WriteLine($"Congrats! Enjoy your trip! Here's your final total: {neededRetreat.TripTotal()}");

            Console.WriteLine("If you decided to invite your close friends, how many people in total (including you would go on the trip?");
            double travelers = double.Parse(Console.ReadLine());

            double multiplication = Multiply(total, travelers);
            Console.WriteLine($"If you and your close friends went on the trip, this would be the total amount for the group: {multiplication}");

            static double Multiply(double total, double travelers)
            {
                return total * travelers;
            }

        }
    }  
}
