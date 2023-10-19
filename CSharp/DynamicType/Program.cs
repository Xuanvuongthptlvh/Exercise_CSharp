

/*Notes: Dynamic avoids compile-time checking.
 * So, it resolves at run time. 
 * The compiler compiles dynamic types into object types in most case. 
 * However, the actual type of dynamic type variable would be resolved at the run time. 
 * The dynamic type variables are converted into other types implicitly.*/
public class Student
{
    public void Display(int Id)
    {
        Console.WriteLine($"Information of StudentId {Id}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        dynamic MyDynamicVar = 1; // int
        Console.WriteLine(MyDynamicVar.GetType());
        MyDynamicVar = "String"; // string
        Console.WriteLine(MyDynamicVar.GetType());

        dynamic st = new Student();
        st.Display(1);
        st.Display("Messi"); // run-time error
        st.Print(); // no compile-time error => run-time error
    }
}