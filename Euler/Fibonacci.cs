using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public class Fibonacci
    {
        long previous, current, temp;

        // start the bus
        public void Initialize(long seed1, long seed2)
        {
            previous = seed1;
            current = seed2;
        }

        // iterate once
        public void Step()
        {
            temp = previous;
            previous = current;
            current = temp + previous;
        }

        // iterate n times
        public void Step(int iterations)
        {
            for (int myInteration = 0; myInteration < iterations; myInteration++)
            {
                temp = previous;
                previous = current;
                current = temp + previous;
            }
        }

        // return the most recent number generated
        public long GetLast()
        {
            return current;
        }
    }
}