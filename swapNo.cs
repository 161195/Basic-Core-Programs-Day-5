using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_programs
{
    class swapNo
    {
        public void swappingNo()
        {
            Console.WriteLine("Enter Two Nubers :");
            Console.Write("\nEnter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n AFTER SWAPPING NUMBER");
            Console.WriteLine("\nFirst Number :" + num1);
            Console.WriteLine("Second Number :" + num2);


        }  
    }    
}
