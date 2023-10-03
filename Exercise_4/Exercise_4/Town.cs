using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Town
    {
        public int NoOfFamily { get; set; }
        public List<Family> families { get; set; }

        public Town()
        {
            this.families = new List<Family>();
        }

        public void AddFamily()
        {
            for (int i = 0; i < NoOfFamily; i++)
            {
                Family family = new Family();
                Console.WriteLine($"Enter family {i + 1}");
                Console.WriteLine("Enter family address:");
                family.Address = Console.ReadLine();
                Console.WriteLine("Enter number of members:");
                family.NoOfMember = Int32.Parse(Console.ReadLine());
                family.AddMember();
                this.families.Add(family);
            }
        }
        public void ShowInfor()
        {
            foreach(Family family in families)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Family Address: " + family.Address);
                Console.WriteLine("Number of members: " + family.NoOfMember);
                family.ShowInfor();
            }
        }
        
    }
}
