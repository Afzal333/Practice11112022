using System;
using System.Collections.Generic;
using System.Text;

namespace Practise11112022
{
    public class ASCIICharacters
    {
        public void ASCII()
        {
            char c;
            for (c = 'A'; c <= 'Z'; c++)
            {
                int num = Convert.ToInt32(c);
                Console.WriteLine("The ASCII value {0} is {1} ",c,num );
            }
        }
    }
}
