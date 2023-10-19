/*As you know, a value type cannot be assigned a null value. 
 * For example, int i = null will give you a compile time error.*/

/*C# 2.0 introduced nullable types that allow you to assign null to value type variables. 
 * You can declare nullable types using Nullable<t> where T is a type.*/
class Program
{
    /*public struct Nullable<T> wheere T: struct{
        public bool HasValue ( get; }
        public T Value { get; }
        // other implementaion
    }*/
    static void Main(string[] args)
    {
        Nullable<int> n = 10;
        // int i = null; compile-time error
        if (n.HasValue)
            Console.WriteLine(n.Value);
        else
            Console.WriteLine("Null");

        int? m = null; // = Nullable<int> m = null;

        Console.WriteLine(m.GetValueOrDefault());

    }
}