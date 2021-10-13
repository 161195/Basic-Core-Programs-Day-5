using System;
using Day5_programs;

namespace Day5_programs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Program Number");
            Console.WriteLine("1.flipCoin\n2.leapYear\n3.powerOf2\n4.harmonicNumber\n5.factors\n6.quoReminder\n7.swapNo\n8.noEvenOrOdd\n9.alphabet\n10.largestNo");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                flipCoin play = new flipCoin();
                play.flipCoinCheck();
                    break;

                case 2:
                leapYear year = new leapYear();
                    year.check();
                    break;

                case 3:
                    powerOf2 calculate = new powerOf2();
                    calculate.powerOf2Check();
                    break;

                case 4:
                    harmonicNumber check = new harmonicNumber();
                    check.checkHarmonicNumber();
                    break;

                case 5:
                    factors checking = new factors();
                    checking.primeFactor();
                    break;

                case 6:
                    quoReminder add = new quoReminder();
                    add.quoReminderCheck();
                    break;

                case 7:
                    swapNo calculated = new swapNo();
                    calculated.swappingNo();
                    break;

                case 8:
                    noEvenOrOddcs cal = new noEvenOrOddcs();
                    cal.evenOrOdd();
                    break;

                case 9:
                    Alphabet che = new Alphabet();
                    che.vowelConsonant();
                    break;

                case 10:
                    largestNo nocheck = new largestNo();
                    nocheck.checkLargeNo();
                    break;


            }
            
        }
    }
}
