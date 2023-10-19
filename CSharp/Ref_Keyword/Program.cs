/*C# supports value type and reference type data types. 
 * By default, the value type variable is passed by value, 
 * and the reference type variable is passed by reference 
 * from one method to another method in C#.*/
class Program
{
    static void Main(string[] args)
    {
        int myNum = 10;
        ProcessNumber(ref myNum); 
        //use ref to pass the parameter by reference 

        Console.WriteLine(myNum);
        Console.ReadLine();
    }

    public static void ProcessNumber(ref int num)
    {
        num = 100;
    }
 /*Both ref and out are treated the same 
  * as compile-time but different at runtime. 
  * We cannot define an overloaded method that 
  * differs only on 'ref' and 'out' parameter.*/
    public class Method
    {
        public int Sum(ref int x, int y)
        {
            return x + y;
        }

        /*public int Sum(out int x, int y)
        {
            return x + y + 1;
        }*/
    }
}