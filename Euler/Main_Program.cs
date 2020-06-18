// ----------------------------------------
//  (http://projecteuler.net/)
// ----------------------------------------
            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    partial class Main_Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------
            // Problem 1 - Multiples of 3 or 5
            // ----------------------------------------
            // 1. 233168 233168
            Console.Write("Problem 1: ");
            int myValue1 = Problem1();
            Console.WriteLine(myValue1);


            // ----------------------------------------
            // Problem 2 - Even numbers in a Fibonacci sequence
            // ----------------------------------------
            // 2. 4613732
            Console.Write("Problem 2: ");
            long myValue2 = Problem2();
            Console.WriteLine(myValue2);

            // ----------------------------------------
            // Problem 1 - multiples of 3 or 5
            // ----------------------------------------
            
            // ----------------------------------------
            Console.WriteLine("Press the any key to continue.");
            while (!Console.KeyAvailable)
            { }
        }
    }
}
