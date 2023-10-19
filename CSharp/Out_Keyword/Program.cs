
/*The out parameters can be used when you want to return 
 * more than one values from the method.*/
class Program
{
    public static void OutIntNum(out int x)
    {
        x = 100;
    }

    static void Main(string[] args)
    {
        int a = 10;
        OutIntNum(out a);
        Console.WriteLine(a);
    }
}