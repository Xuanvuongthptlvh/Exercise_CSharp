using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class ManagerCandidate
    {
        List<Candidate> candidates;
        public ManagerCandidate()
        {
            this.candidates = new List<Candidate>();
        }

        public void add(Candidate candidate)
        {
            this.candidates.Add(candidate);
        }

        public void showInfor()
        {
            foreach(var candidate in this.candidates)
            {
                Console.WriteLine(candidate);
            }
        }

        public Candidate searchById(String id)
        {
            return this.candidates.FirstOrDefault(candidate => candidate.Id.Equals(id));
        }
    }
}
