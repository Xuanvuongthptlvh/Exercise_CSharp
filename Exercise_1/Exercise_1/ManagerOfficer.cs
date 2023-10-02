using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class ManagerOfficer
    {
        private List<Officer> officers;

        public ManagerOfficer()
        {
            this.officers = new List<Officer>();
        }

        public void addOfficer(Officer officer)
        {
            this.officers.Add(officer);
        }

        public List<Officer> SearchOfficerByName(string name)
        {
            return this.officers.Where(o => o.Name.Contains(name)).ToList();
        }

        public void ShowListInforOfficer()
        {
            foreach (var officer in officers)
            {
                Console.WriteLine(officer.ToString());
            }
        }
    }
}
