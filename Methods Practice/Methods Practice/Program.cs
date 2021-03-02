using System;

namespace Methods_Practice
{
    class Program
    {






        static void Main(string[] args)
        {

            int answer = Add(10, 10);
            Console.WriteLine(answer);


           // Console.WriteLine(Add(1, 1));
            
            //Console.WriteLine("Hello World!");
            //int[] arr = new int[10];
            //Program p = new Program();
            //p.GetGreeting();
        }

        public static void GetGreeting()
        {
            Console.WriteLine("Hey Class!");
        }
        public static int Add( int x, int y)
        {
            return (x + y);
        }

    }
}
