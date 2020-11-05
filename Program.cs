using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Section5ControlFlow_Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number, between 1-10");
            
            string userNumberString = Console.ReadLine();  // should it be "string" or "var"

            int userNumber = Convert.ToInt32(userNumberString);

            if (userNumber >= 1 && userNumber <= 10)
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
