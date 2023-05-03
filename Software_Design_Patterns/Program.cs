using Software_Design_Patterns.BuilderPattern;

using Software_Design_Patterns.BuilderPattern.example3;
using Software_Design_Patterns.Factory;
using Software_Design_Patterns.Factory.Abstract_Factory;
using Software_Design_Patterns.Proxy;
using Software_Design_Patterns.Singleton;

namespace SoftwateDesign
{
    class Program
    {

        public static void Main(string[] args)
        {
            #region SINGLETON
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
            #endregion

            #region PROTOTYPE
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
            #endregion

            #region BUILDER
            /*
           Director director = new Director();

           IBuilder carBuilder = new Car("BMW");

           director.Consuruct(carBuilder);

           Product carProduct = carBuilder.GetVehicle();


           Console.WriteLine(carProduct.Show());
           */
            #endregion

            #region Factory
            /*
            Console.WriteLine("Enter CardNumber of your bank");

            String cardNumber, bankCode;
            

            cardNumber = Console.ReadLine();

            bankCode = cardNumber.Substring(0, 6);


            IBankFactory bankFactory = new BankFactory();

            IBank bank = bankFactory.GetBank(bankCode);

            //adding abstract factory to factory
            
            IPaymentCard paymentCard = bankFactory.GetPaymentCard(cardNumber.Substring(0,2));


            Console.WriteLine(bank.WithDrow());
            Console.WriteLine(paymentCard.GetName());
            */
            #endregion

            #region Proxy

            SMSServiceProxy proxy = new SMSServiceProxy();

            string result1 = proxy.SendSMS("123", "01113046200", "message 1");
            string result2 = proxy.SendSMS("123", "01113046200", "message 1");
            string result3 = proxy.SendSMS("123", "01113046200", "message 1");
            string result4 = proxy.SendSMS("123", "01113046200", "message 1");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            #endregion



            Console.ReadKey();
        }
    }

}