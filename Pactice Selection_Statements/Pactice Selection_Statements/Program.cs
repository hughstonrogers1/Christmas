using System;

namespace Pactice_Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int votingAge;
            bool isCitizen;
            string record;

            Console.WriteLine("How old are you?");
            votingAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a legal US citizen?");
            Console.WriteLine("Type true or false.");
            isCitizen = bool.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a clean record?");
            Console.WriteLine("Type Y / N : ");
            record = Console.ReadLine().ToLower();

            if (votingAge >= 18 && isCitizen && record == "y")
            {
                Console.WriteLine("Can vote in National and State Elections!");
            }
            else if (votingAge >= 18 && isCitizen || record == "y")
            {
                Console.WriteLine("You can vote in State Election but not the National.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to vote!");
            }
            
        }
    }
}
