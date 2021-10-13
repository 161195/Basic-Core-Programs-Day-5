using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_programs
{
    class leapYear
    {
        public void check()
        {
            Console.WriteLine("Enter The Year");
            int year = Convert.ToInt32(Console.ReadLine());

            //local variable
            int L = year % 400;
            int M = year % 4;
            int N = year % 100;

            //if else condition
            if(L==0 || (M==0 && N !=0))
            {
                Console.WriteLine("{0} year is leap", year);
            }
            else
            {
                Console.WriteLine("{0} year is not leap", year);
            }
            Console.ReadLine();

        }
    }
}
