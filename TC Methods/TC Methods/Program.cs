using System;

namespace TC_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                GetAndPrintNumber(10, 10);
                GetAndPrintNumber(10, 10);
                
            }

            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
        }
        private static void GetAndPrintNumber(int y, int z)
        {
            Console.Write("Please input a Number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
        }
    }
}
