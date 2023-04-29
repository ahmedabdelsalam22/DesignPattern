using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern
{
    public class Employee
    {
        public Employee(String name , string email , decimal basicSallary)
        {
            Name = name;
            Email = email;
            BasicSallary = basicSallary;
        }
        public String Name { get;}
        public String Email { get;}
        public Decimal BasicSallary { get;}

    }
}
