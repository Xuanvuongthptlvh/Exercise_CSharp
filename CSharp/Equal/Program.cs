using System;
using System.Text;

namespace Equal
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;

            Console.WriteLine(i == j); // true
            Console.WriteLine(i.Equals(j)); // true

            object obj1 = "Hello";
            object obj2 = "Hello";

            Console.WriteLine(obj1 == obj2); // true
            Console.WriteLine(obj1.Equals(obj2)); // true

            /*object obj1 = new StringBuilder("Hello");
            object obj2 = "Hello";

            Console.WriteLine(obj1 == obj2); // false
            Console.WriteLine(obj1.Equals(obj2));// false*/
        }
    }
}