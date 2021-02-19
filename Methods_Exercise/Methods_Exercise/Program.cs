using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today we shall ask you a short series of questions to make a story. Have fun!");

            Console.WriteLine("What is a name for your main character?");
            string Name = Console.ReadLine();

            Console.WriteLine("Where do you want your chacter to be from?");
            string From = Console.ReadLine();

            Console.WriteLine("What is your characters class?");
            string Class = Console.ReadLine();

            Console.WriteLine("What is your character's age?");
            string Age = Console.ReadLine();

            Console.WriteLine($"The character you have selected is of the {Class} class." +
                $"{Name} is the name that you have chosen for your character." +
                $"{Name} is {Age} years old and is from the region of {From}. ");

            
        }

        

    }
}
