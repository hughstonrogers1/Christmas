using System;

namespace Syntax_Sugar_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Explicit Typing

            //string firstName = "John"; // Declaring & Initializing
            //int age = 29;
            //bool isOver18 = true;

            ////Inferred Typing
            //var x = "abc"; //Declaring & Initializing
            //var y = 2324;
            //var z = false;

            //if (x == "abc" && !z)
            //{
            //    Console.WriteLine("Both of these are true");
            //}
            //else
            //{
            //    Console.WriteLine("One of these was false.");
            //}
            // these two are the same thing. 

            ////string answer = "";

            ////adding var removes above. 

            //var answer = x == "abc" && !z ? "Both of these are true" : "One of these was false.";
            //// do not include "Console.WriteLine" within. 
            //Console.WriteLine(answer);






            //int x = 0;
            //int y = 1;


            ////if (x > y)
            ////{
            ////    Console.WriteLine("x is greater");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("y is greater");
            ////}




            //var answer = x > y ? "x is greater" : "y is greater";
            //Console.WriteLine(answer);


            ////String Interpolation
            //var answer1 = $"Some string that uses {x} {y}";

            //var answer1 = "0";
            //int answer2 = 0;

            //var firstName = "John";


            //Console.WriteLine(answer1);
            //Console.WriteLine(answer2);


            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;

            if (true)
            {
                Console.WriteLine("6");
            }


            var answer = (firstNumber + secondNumber + thirdNumber == 6) ? 6 : 0;
            Console.WriteLine(answer);


        }
    }
}
