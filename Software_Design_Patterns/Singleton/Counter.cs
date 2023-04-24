using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Singleton
{
    public class Counter
    {
        public int Count = 0;

        private Counter(){}

        private static Counter Instance = new Counter();

        public static Counter GetInstance() => Instance;

        public void IncrementCounter()
        {
          Count++;
        }
    }
}
