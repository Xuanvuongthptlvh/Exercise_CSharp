/*In C#, an anonymous type is a type (class) without any name 
 * that can contain public read-only properties only. 
 * It cannot contain other members, such as fields, methods, events, etc.*/

/*The properties of anonymous types are read-only and 
 * cannot be initialized with a null, anonymous function, or a pointer type. 
 * The properties can be accessed using dot (.) notation, same as object properties. 
 * However, you cannot change the values of properties as they are read-only.*/
class Program
{
    static void Main(string[] args)
    {
        var student = new {Id = 1, Name = "Vuong"};
        //student.Id = 2; read-only, cannot be changed
        Console.WriteLine(student.Name);

        var Actor = new
        {
            Id = 1,
            FirstName = "James",
            LastName = "Bond",
            Address = new { Id = 1, City = "London", Country = "UK" }
        };

        var students = new[] {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
    };
    }
}