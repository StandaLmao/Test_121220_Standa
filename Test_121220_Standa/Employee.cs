using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_121220_Standa
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNum { get; set; }
        public string email { get; set; }
        public string birthDate { get; set; }
        public int id { get; set; }

        public Employee(int id, string firstName,string lastName,string phoneNum, string email, string birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.email = email;
            this.birthDate = birthDate;
            this.id = id;
        }

        public override string ToString()
        {
            return id.ToString() + "  " + firstName + "  " + lastName + "  " + phoneNum + "  " + email + "  " + birthDate;
        }
    }
}
