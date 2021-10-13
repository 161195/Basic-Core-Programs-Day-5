using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_programs
{
    class factors
    {
        public void primeFactor()
        {
            Console.Write("Enter your integer number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i* i<=num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is a prime factor of " + num);
                }
            }
        }
    }
}
