using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Family
    {   
        public int NoOfMember {  get; set; }
        public string Address { get; set; }
        public List<Person> Members { get; set; }

        public Family()
        {
            Members = new List<Person>();
        }

        public void AddMember()
        {
            for (int i = 0; i < NoOfMember; i++)
            {
                Console.WriteLine($"Enter member {i + 1}:");
                Console.WriteLine("Enter fullname:");
                string fullname = Console.ReadLine();

                Console.WriteLine("Enter age:");
                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter job:");
                string job = Console.ReadLine();

                Console.WriteLine("Enter PersonID:");
                string personID = Console.ReadLine();

                this.Members.Add(new Person(fullname, age, job, personID));
            }
        }
        public void ShowInfor()
        {
            Console.WriteLine("Information of each member:");
            foreach (Person member in Members)
            {
                Console.WriteLine(member.ToString());
            }
        }

    }
}
