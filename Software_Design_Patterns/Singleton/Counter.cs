﻿using System;
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

        // private static Counter Instance = new Counter();

        private static Counter Instance = null;

        // thread 
        private static Object lockObj = new Object();

        public static Counter GetInstance() 
        {
            lock (lockObj) // lock this impl after excuting .. 
            {
                if (Instance == null)
                {
                    Instance = new Counter();
                }
                return Instance;
            }
        }

        public void IncrementCounter()
        {
          Count++;
        }
    }
}
