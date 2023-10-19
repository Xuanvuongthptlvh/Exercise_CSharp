using System;

namespace StaticKeyword
{

    public static class Calculator // static class
    {
        private static int _resultStorage = 0;

        // public int i; cannot contain instance members and constructors.

        // public Calculator() { }
        

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }
    
    // Non-static class
    public class StopWatch // : Calculator cannot be inherited
    {
        public static int NoOfInstances = 0; // static field in non-static class

        public StopWatch()
        {
            NoOfInstances++;
        }

        /*public virtual static void Stop()
        {
            Console.WriteLine("Stop");
        }*/

    }
    
    class Program
    {

        static int counter = 0;
        string name = "Demo Program";

        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        static void Display(string text, int value) // overload
        {
            Console.WriteLine(text + $": {value} ");
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            /*var result = Calculator.Sum(1, 2);
            Console.WriteLine(result);*/

            /*StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4*/

            /*counter++;
            Console.WriteLine(counter);*/

            //Console.WriteLine(name); cannot access non-static members
            Display("Hello");

            Display("Ten", 10);

            //Print("Hello"); 
            
        }
    }
}