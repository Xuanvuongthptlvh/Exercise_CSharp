namespace Exercise_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Employee Management - Menu");
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Modify employee info");
                Console.WriteLine("3. Delete an employee");
                Console.WriteLine("4. Find all employees by type");
                Console.WriteLine("5. Show all employees");
                Console.WriteLine("6. Exit program");
                Console.WriteLine("Your choice:");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        management.AddEmployee();
                        break;
                    case 2:
                        management.ModifyEmployee();
                        break;
                    case 3:
                        management.DeleteEmployee();
                        break;
                    case 4:
                        management.FindByType();
                        break;
                    case 5:
                        management.ShowAll();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid!");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}