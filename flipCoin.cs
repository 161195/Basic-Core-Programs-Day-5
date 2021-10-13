using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_programs
{
    class flipCoin
    {
        public void flipCoinCheck()
        {
            int result = 0;
            int heads = 0;
            int tails = 0;
            double percentage1;
            double percentage2;

            Console.WriteLine("Enter number of timesflip a coin");
            int num = Convert.ToInt32(Console.ReadLine());
            {

                for (int i = 0; i < num; i++)
                {
                    Random random = new Random();
                    result = random.Next(0, 2);
                    if (result == 0)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }

                }
                Console.WriteLine("Head was flipped {0} times", heads);
                Console.WriteLine("Tail was flipped {0} times", tails);
                percentage1 = ((float)heads / num) * 100;
                percentage2 = ((float)tails / num) * 100;
                Console.WriteLine("Percentage of Heads : " + percentage1);
                Console.WriteLine("Percentage of tails : " + percentage2);
            }
        }
    }
}
