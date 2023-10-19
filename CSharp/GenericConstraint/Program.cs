using System;

/*C# allows you to use constraints to restrict client code to specify certain types while
 instantiating generic types.*/
class DataStore<T> where T : class
{
    public T Data { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        DataStore<string> data = new DataStore<string>();
        //DataStore<int> data1 = new DataStore<int>; // compile-time error
    }
}