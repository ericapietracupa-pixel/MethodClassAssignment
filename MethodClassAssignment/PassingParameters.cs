using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class PassingParameters
    {
        // This method takes two integer parameters, multiplies the first parameter by 5, and prints the result along with the value of the second parameter.
        public void PassingIntParameters(int num1, int num2)
        {
            // Multiply num1 by 5 and store the result in a variable
            int result = num1 * 5;
            
            // Print the result of the multiplication and the value of num2
            Console.WriteLine("Result of multiplying num1(" + num1 + ") by 5: " + result);
            
            // Print the value of num2
            Console.WriteLine("num2 value is: " + num2);
        }
    }
}
