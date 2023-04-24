using Software_Design_Patterns.Singleton;

namespace SoftwateDesign 
{
    class Program 
    {
      public static void Main(string[] args) 
        {
           Counter counter1 = new Counter();

            counter1.IncrementCounter();

            Console.WriteLine(counter1.Count);



            counter2.IncrementCounter();

            Console.WriteLine(counter2.Count);
      }

        }
    }
}