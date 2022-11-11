using System;
using System.Collections.Generic;
using System.Text;

namespace Practise11112022
{
    public class Factorial
    {
        public void number()
        {
            int fact = 1;
            Console.Write("Enter Number for Factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                 fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            
        }
    }
}
