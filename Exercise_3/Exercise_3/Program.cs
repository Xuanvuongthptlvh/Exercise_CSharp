using Exercise_3;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var managerCandidate = new ManagerCandidate();
        while (true)
        {
            Console.WriteLine("Application Manager Candidate - Menu:");
            Console.WriteLine("Enter 1: To insert candidate");
            Console.WriteLine("Enter 2: To show information of candidate");
            Console.WriteLine("Enter 3: To search candidate by id");
            Console.WriteLine("Enter 4: To exit:");
            string line = Console.ReadLine();
            switch (line)
            {
                case "1":
                    {
                        Console.WriteLine("Enter a: to insert Candidate A");
                        Console.WriteLine("Enter b: to insert Candidate B");
                        Console.WriteLine("Enter c: to insert Candidate C");
                        string type = Console.ReadLine();
                        switch (type)
                        {
                            case "a":
                                managerCandidate.add(CreateCandidate("a"));
                                break;

                            case "b":
                                managerCandidate.add(CreateCandidate("b"));
                                break;

                            case "c":
                                managerCandidate.add(CreateCandidate("c"));
                                break;

                            default:
                                Console.WriteLine("Invalid");
                                break;
                        }
                        break;
                    }

                case "2":
                    managerCandidate.showInfor();
                    break;

                case "3":
                    Console.Write("Enter ID: ");
                    string id = Console.ReadLine();
                    var candidate = managerCandidate.searchById(id);
                    if (candidate == null)
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        Console.WriteLine(candidate.ToString());
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid");
                    continue;
            }
        }
    }

    public static Candidate CreateCandidate(string cate)
    {
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter Priority: ");
        int priority = int.Parse(Console.ReadLine());

        if (cate.Equals("a"))
        {
            return new CandidateA(id, name, address, priority);
        }
        else if (cate.Equals("b"))
        {
            return new CandidateB(id, name, address, priority);
        }
        else
        {
            return new CandidateC(id, name, address, priority);
        }
    }
}
