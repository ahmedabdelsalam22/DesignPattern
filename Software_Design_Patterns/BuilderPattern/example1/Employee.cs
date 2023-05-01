using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example1
{
    public class Employee
    {
        public Employee(string name, string email, decimal basicSallary)
        {
            Name = name;
            Email = email;
            BasicSallary = basicSallary;
        }
        public string Name { get; }
        public string Email { get; }
        public decimal BasicSallary { get; }

    }
}
