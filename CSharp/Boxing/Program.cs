
/*Notes: Boxing is the process of converting a value type to the object 
 * type or any interface type implemented by this value type.
 * Boxing is implicit.*/


/*Notes: Unboxing is the reverse of boxing. 
 * It is the process of coverting a reference type to a value type. 
 * Unboxing is explicit.*/
using System.Collections;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        object obj = i; // boxing
        obj = 2;

        Console.WriteLine(i); // output: 1. So variable i is not changed.

        ArrayList arr = new ArrayList();
        arr.Add(i); // boxing

        object o = 10;
        int j = (int)o; // unboxing is explicit

        //double m = (double)o; //run-time error

        double m =(double)(int)o; // valid because first unboxing then casting

    }
}