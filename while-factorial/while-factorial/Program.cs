using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your factorial number = ");
            int n = Convert.ToInt16(Console.ReadLine());
            int result = 1;

            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }
                Console.Write(" * ");
                result *= n;
                n--;
            }
            Console.WriteLine(" = {0}", result);
        }
    }
}
