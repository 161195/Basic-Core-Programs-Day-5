using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_programs
{
    class quoReminder
    {
        public void quoReminderCheck()
        {
            Console.WriteLine("\nEnter Two Numbers :");
            Console.WriteLine("\nEnter Dividend Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Divisor Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result1 = num1 / num2;
            int result2 = num1 % num2;

            Console.WriteLine("\nQuotient is " + result1);
            Console.WriteLine("\nRemainder is " + result2);
        }
    }
}
