using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    abstract class Employee
    {
        public static int Employee_Count = 0;
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateOnly? BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public Certificate? Certificate { get; set; }
        public Employee()
        {
            ID = ++Employee_Count;
            FullName = string.Empty;
            BirthDay = null;
            Phone = string.Empty;
            Email = string.Empty;
            Certificate = null;
        }
        public Employee(int iD, string fullName, DateOnly? birthDay, string phone, string email)
        {
            ID = iD;
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
        }

        protected Employee(string fullName, DateOnly? birthDay, string phone, string email)
        {
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
        }

        public abstract void ShowInfo();
    }
}
