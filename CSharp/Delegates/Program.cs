using System;

namespace Delegates
{

    class Program
    {
        delegate int MyDelegate(string s); // declare delegate
        static void Main(string[] args)
        {
            MyDelegate ToInt = new MyDelegate(ConvertStringToInt); // set target method

            string numstr = "35";

            int valueconverted = ToInt(numstr);
            Console.WriteLine(valueconverted);
        }

        static int ConvertStringToInt(string stringValue) // target method
        {
            int valueInt = 0;
            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Convert successfully!");

            return valueInt;
        }
    }
}