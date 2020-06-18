// --------------------
// Multiples of 3 and 5: Problem 1
// --------------------
/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
 * The sum of these multiples is 23.
 * 
 * Find the sum of all the multiples of 3 or 5 below 1000.
*/
/* loop through each number (1-999 inclusive)
 * times that number by three and if it is below 1000, store it in a variable.
 * also times that number by five and if n<1000, store in another variable.
 * when either check for n<1000 comes back as n>=1000, break and add up the ones that made the cut.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    partial class Main_Program
    {
        public static int Problem1()
        {
            //mySum = 0;
            int grandTotal = 0;
            const int myMax = 1000;
            //bool isDivisibleByThreeOrFive = false;
            
            for (int i = 0; i < myMax; i++)
            {
                //isDivisibleByThreeOrFive = isDivisibleBy(i, 3) 
                if (isDivisibleBy(i,3) || isDivisibleBy(i, 5))
                {
                    grandTotal += i;
                }
            }
            //int localIncrement = 0;
            //doExit = false;
            //while (!doExit)
	        //{
                //grandTotal += compareNumber(firstMultiplier, localIncrement);
                //grandTotal += compareNumber(secondMultiplier, localIncrement);
                
                //localIncrement++;
	        //}
            return grandTotal;
        }

        public static int compareNumber(int baseNumber, int currentNumber)
        {
	        int result = 0;
	        int tempResult = currentNumber * baseNumber;

	        if(tempResult < upperLimit) { result = tempResult; }
	        else { doExit = true; }
	
	        return result;
        }

        public static bool isDivisibleBy(int testVariable, int Divisor)
        {
            bool myResult = false;

            if ((testVariable % Divisor) == 0) myResult = true;
            else myResult = false; // redundant

            return myResult;
        }

    }

}