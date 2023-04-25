using Software_Design_Patterns.Singleton;

namespace SoftwateDesign 
{
    class Program 
    {
      public static void Main(string[] args) 
        {

            Counter counter1 = Counter.GetInstance();

            counter1.IncrementCounter();

            Console.WriteLine(counter1.Count);  // print: 1



            Counter counter2 = Counter.GetInstance();

            counter2.IncrementCounter();

            Console.WriteLine(counter2.Count); // print: 2
        }
    }
}