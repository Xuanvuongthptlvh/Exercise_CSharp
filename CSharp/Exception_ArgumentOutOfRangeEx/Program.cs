using System;

/*Raised when the valude of an argument is outside the range of valid values*/
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var guest = new Guest("John", "Wick", 17);
            Console.WriteLine(guest.GuestInfor);
        }
        catch(ArgumentException a)
        {
            Console.WriteLine("Error: "+ a.Message);
        }
    }
}
class Guest
{
    private const int minimumRequiredAge = 21;

    private string firstName;
    private string lastName;
    private int age;

    public Guest(string firstName, string lastName, int age)
    {
        if(age < minimumRequiredAge)
            throw new ArgumentOutOfRangeException(nameof(age), $"All guest must be {minimumRequiredAge}-years-old or older.");
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public string GuestInfor => $"{firstName} {lastName}, {age}";
}