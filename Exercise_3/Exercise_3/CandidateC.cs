using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_3
{
    public class CandidateC : Candidate
    {
    public static string C_1 = "Literature";
    public static string C_2 = "History";
    public static string C_3 = "Geography";

    public CandidateC(string id, string name, string address, int priority) : base(id, name, address, priority) { }


    public override string ToString()
        {
            return $"CandidateC - {Id}, {Name}, {Address}, {Priority}, Subject: {C_1}, {C_2}, {C_3}";
        }
    }
}
