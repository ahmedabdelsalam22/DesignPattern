using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Prototype
{
    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Address EmpAddress { get; set; }

        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();

        public override string ToString()
        {
            return 
             $@"
               Id: {this.Id},
               Name: {this.Name},
               Address:{this.EmpAddress.Building},{this.EmpAddress.StreetName},{this.EmpAddress.City}
             ";
        }
    }
}
