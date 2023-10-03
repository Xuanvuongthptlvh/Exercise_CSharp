using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Fresher : Employee
    {
        public DateOnly? Graduation_Date {  get; set; }
        public string Graduation_Rank { get; set; }
        public string Education {  get; set; }

        public Fresher()
        {
            Graduation_Date = null;
            Graduation_Rank = String.Empty;
            Education = String.Empty;
        }
        public Fresher(string fullName, DateOnly? birthDay, string phone, string email, DateOnly? graduation_Date, string graduation_Rank, string education) : base(fullName, birthDay, phone, email)
        {
            Graduation_Date = graduation_Date;
            Graduation_Rank = graduation_Rank;
            Education = education;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {FullName}, Birthday: {BirthDay}, Phone: {Phone} " +
                $"\n Email: {Email}, Employee_type: Fresher, Graduation_Date: {Graduation_Date}, Graduation_Rank: {Graduation_Rank}, Education = {Education}.");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
