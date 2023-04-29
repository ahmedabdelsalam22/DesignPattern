using Software_Design_Patterns.BuilderPattern;
using Software_Design_Patterns.Singleton;

namespace SoftwateDesign
{
    class Program
    {

        public static void Main(string[] args)
        {

            ///// SINGLETON 

            /*
            
            //First thrid
            Task task = Task.Factory.StartNew(() =>
            {
                Counter counter_1 = Counter.GetInstance();

                counter_1.IncrementCounter();

                Console.WriteLine("counter_1 equal " + counter_1.Count);  // print: 1
                
            });



            //second thrid
           Task task1 = Task.Factory.StartNew(() =>
           {
                Counter counter_2 = Counter.GetInstance();

               counter_2.IncrementCounter();

                Console.WriteLine("counter_2 equal " + counter_2.Count); // print: 2
           });

             */


            //// PROTOTYPE 

            /*
             
              EmployeePrototype tempEmp1 = new TempEmployee();

            tempEmp1.Name = "tempEmp1";
            tempEmp1.Id = 1;
            tempEmp1.EmpAddress = new Address()
            {
                City = "City 1",
                Building = "Building 1",
                StreetName = "StreetName 1"
            };

            //shallow Copy
            EmployeePrototype tempEmp2 = tempEmp1.ShallowCopy();
            //Deep Copy
            //EmployeePrototype tempEmp2 = tempEmp1.DeepCopy();

            Console.WriteLine("temp employee 1 values original");
            Console.WriteLine(tempEmp1.ToString());

            Console.WriteLine("temp employee 2 values shallow copy");
            Console.WriteLine(tempEmp2.ToString());

            tempEmp2.EmpAddress.City = "New City1";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("temp employee 1 values after change");
            Console.WriteLine(tempEmp1.ToString());

            Console.WriteLine("temp employee 2 values");
            Console.WriteLine(tempEmp2.ToString());
              
             */

            //// BUILDER 

            var builder = new SallaryCalculationBuilder();
            while (true) 
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add 20% Bonus");
                Console.WriteLine("2. Deduct 10% Taxes");
                Console.WriteLine("3. Add 2000 Education Package");
                Console.WriteLine("4. Add 1000 Transportation");
                Console.WriteLine("5. Send Payslip to employee");
                Console.WriteLine("6. Post Voucher to GL");
                Console.WriteLine("0. Build");

                var option = int.Parse(Console.ReadLine());
                if (option == 1) 
                {
                    builder.WithBonus(20);
                }
                if (option == 2)
                {
                    builder.WithTaxes(10);
                }
                if (option == 3)
                {
                    builder.WithEducationPackage(2000);
                }
                if (option == 4)
                {
                    builder.WithTransportation(4000);
                }
                if (option == 5)
                {
                    builder.SendPaysLipToEmployee(true);
                }
                if (option == 6)
                {
                    builder.PostResultToGL(true);
                }
                else if (option == 0) 
                {
                    var calculator = builder.Build();
                    var employee = new Employee("Ahmed","Ahmed@gmail.com",70000);
                    var sallary = calculator.Calculate(employee);
                    builder = new SallaryCalculationBuilder();
                }

            }

            Console.ReadKey();
        }
    }

}