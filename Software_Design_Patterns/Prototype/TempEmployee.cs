using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Prototype
{
    public class TempEmployee : EmployeePrototype
    {
        public override EmployeePrototype ShallowCopy()
        {
            return (TempEmployee) this.MemberwiseClone();
        }

        public override EmployeePrototype DeepCopy()
        {
            TempEmployee tempEmployee = new TempEmployee();

            tempEmployee = (TempEmployee)this.MemberwiseClone();

            tempEmployee.Name = this.Name;
            tempEmployee.EmpAddress = new Address() 
            {
              Building = EmpAddress.Building,
              City = EmpAddress.City,
              StreetName = EmpAddress.StreetName,
            };
            return tempEmployee;
        }
    }
}
