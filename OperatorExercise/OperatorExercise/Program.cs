using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
            // output of 16 (++i will = 4, j++ = 4)
            */


            int a = 17;

            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

            if (a == 17 && b == 4) ;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine();

            Console.WriteLine(AreaOfCircle(a));


        }
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
