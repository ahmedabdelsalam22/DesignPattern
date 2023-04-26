using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Prototype
{
    public class RegularEmployee : EmployeePrototype
    {
        public override EmployeePrototype ShallowCopy()
        {
            return (RegularEmployee) this.MemberwiseClone();
        }
        public override EmployeePrototype DeepCopy()
        {
            RegularEmployee regularEmployee = new RegularEmployee();

            regularEmployee = (RegularEmployee)this.MemberwiseClone();
            regularEmployee.Name = this.Name;
            regularEmployee.EmpAddress = new Address() 
            {
              Building = EmpAddress.Building,
              City = EmpAddress.City,
              StreetName = EmpAddress.StreetName,
            };
            return regularEmployee;
        }

       
    }
}
