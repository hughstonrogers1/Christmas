using System;

namespace TrueCoders_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the length of your cube?");
            var length = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of you cube?");
            var with = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the height of your cube?");
            var height = int.Parse(Console.ReadLine());

            var area = (length * height * with);

            Console.WriteLine($"The area of your rectangle is {area}");

            var size = (area > 1000) ? "Your cube is a large cube." : "Your cube is a small cube.";

            Console.WriteLine(size);

        }
    }
}
