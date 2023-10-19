using System;

namespace StaticConstructor
{
    public class StopWatch
    {
               
        // parameterless static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
            //DisplayInfor();
            // Print();
        }

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        public static void DisplayInfor()
        {
            Console.WriteLine("DisplayInfor called");
        }

        public void Print()
        {
            Console.WriteLine("Instance method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();
            StopWatch watch2 = new StopWatch();
            StopWatch.DisplayInfor();
            StopWatch.DisplayInfor();
        }
    }
}