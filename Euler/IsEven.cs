using System;

namespace Euler
{
    partial class Main_Program
    {
        public static bool isEven(int testVariable)
        {
            bool myResult = false;

            if ((testVariable % 2) == 0) myResult = true;
            else myResult = false;

            return myResult;
        }
        public static bool isEven(long testVariable)
        {
            bool myResult = false;

            if ((testVariable % 2) == 0) myResult = true;
            else myResult = false;

            return myResult;
        }

        public static void evenTest(int testVariable)
        {
            
            Console.WriteLine("{0} is {1}", testVariable.ToString(), isEven(testVariable));
            Console.WriteLine("{0} is {1}", testVariable, isEven(testVariable));
        }
        public static void evenTest(long testVariable)
        {

            Console.WriteLine("{0} is {1}", testVariable.ToString(), isEven(testVariable));
            Console.WriteLine("{0} is {1}", testVariable, isEven(testVariable));
        }

    }
}