using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the PassingParameters class
            PassingParameters passingParameters = new PassingParameters();

            // Call the PassingIntParameters method with two integer arguments
            passingParameters.PassingIntParameters(10, 20);

            // Call the PassingIntParameters method with named arguments
            passingParameters.PassingIntParameters(num2: 5, num1: 15);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
