using System;
using System.Collections.Generic;
using System.Text;

namespace Practise11112022
{
    public class PowerNumber
    {
        public void PowerUsingWhile()
        {
            int basenumber, exponent;

            Console.Write("Enter basenumber number: ");
            basenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent number: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            int i = 1;
            
            while (i <= exponent)
            {
                power = power * basenumber;
                i++;
            }
            Console.Write("Power : " + power);

            Console.ReadLine();

        }

        public void PowerUsingFor()
        {
            int basenumber, exponent;

            Console.Write("Enter basenumber number: ");
            basenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent number: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= exponent; i++)
            {
                power = power * basenumber;
            }                
            Console.Write("Power : " + power);
            Console.ReadLine();
        }
    }
}
