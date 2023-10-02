using Exercise_1;
using System;

public class Program
{
    static void Main(string[] args)
    {
        ManagerOfficer managerOfficer = new ManagerOfficer();
        while (true)
        {
            Console.WriteLine("Application Manager Officer - Menu:");
            Console.WriteLine("Enter 1: To insert officer");
            Console.WriteLine("Enter 2: To search officer by name");
            Console.WriteLine("Enter 3: To show information officers");
            Console.WriteLine("Enter 4: To exit");
            string line = Console.ReadLine();
            switch (line)
            {
                case "1":
                    {
                        Console.WriteLine("Enter a: to insert Engineer");
                        Console.WriteLine("Enter b: to insert Worker");
                        Console.WriteLine("Enter c: to insert Staff");
                        string type = Console.ReadLine();
                        switch (type)
                        {
                            case "a":
                                {
                                    Console.Write("Enter name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter age: ");
                                    int age = int.Parse(Console.ReadLine());
                                    Console.Write("Enter gender: ");
                                    string gender = Console.ReadLine();
                                    Console.Write("Enter address: ");
                                    string address = Console.ReadLine();
                                    Console.Write("Enter major: ");
                                    string major = Console.ReadLine();
                                    Officer engineer = new Engineer(name, age, gender, address, major);
                                    managerOfficer.addOfficer(engineer);
                                    Console.WriteLine(engineer.ToString());
                                    break;
                                }
                            case "b":
                                {
                                    Console.Write("Enter name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter age: ");
                                    int age = int.Parse(Console.ReadLine());
                                    Console.Write("Enter gender: ");
                                    string gender = Console.ReadLine();
                                    Console.Write("Enter address: ");
                                    string address = Console.ReadLine();
                                    Inputlevel:
                                    Console.Write("Enter level (1~10): ");
                                    int level = int.Parse(Console.ReadLine());
                                    if (level < 1 || level > 10)
                                    {
                                        Console.WriteLine("Invalid");
                                        goto Inputlevel;
                                    }
                                    Officer worker = new Worker(name, age, gender, address, level);
                                    managerOfficer.addOfficer(worker);
                                    Console.WriteLine(worker.ToString());
                                    break;
                                }
                            case "c":
                                {
                                    Console.Write("Enter name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter age: ");
                                    int age = int.Parse(Console.ReadLine());
                                    Console.Write("Enter gender: ");
                                    string gender = Console.ReadLine();
                                    Console.Write("Enter address: ");
                                    string address = Console.ReadLine();
                                    Console.Write("Enter task: ");
                                    string task = Console.ReadLine();
                                    Officer staff = new Staff(name, age, gender, address, task);
                                    managerOfficer.addOfficer(staff);
                                    Console.WriteLine(staff.ToString());
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid");
                                break;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Write("Enter name to search: ");
                        string name = Console.ReadLine();
                        managerOfficer.SearchOfficerByName(name).ForEach(officer =>
                        {
                            Console.WriteLine(officer.ToString());
                        });
                        break;
                    }
                case "3":
                    {
                        managerOfficer.ShowListInforOfficer();
                        break;
                    }
                case "4":
                    {
                        return;
                    }
                default:
                    Console.WriteLine("Invalid");
                    continue;
            }
        }
    }
}