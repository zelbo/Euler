using System;

namespace Euler
{
    partial class Program
    {
        public static bool isOdd(int testVariable)
        {
            return !isEven(testVariable);
        }
        public static bool isOdd(long testVariable)
        {
            return !isEven(testVariable);
        }
    }
}