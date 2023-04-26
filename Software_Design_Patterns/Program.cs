using Software_Design_Patterns.Singleton;

namespace SoftwateDesign 
{
    class Program 
    {
      public static void Main(string[] args) 
        {

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

            Console.ReadKey();
        }
    }
}