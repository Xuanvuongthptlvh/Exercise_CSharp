namespace Exercise_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();
            while(true)
            {
                Console.WriteLine("Student Management - Menu:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Show students of age 20");
                Console.WriteLine("3. Show number of students of age 23 and from Da Nang");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Input your choice: ");
                int input = int.Parse(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        management.AddClass();
                        break;
                    case 2:
                        management.ShowStudentOfAge20();
                        break;
                    case 3:
                        management.ShowNumberOfStudentsOfAge23AndFromDN();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid");
                        continue;

                }
            }
        }
    }
}