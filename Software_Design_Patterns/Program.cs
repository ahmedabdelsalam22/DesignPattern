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

            Console.ReadKey();
        }
    }
}