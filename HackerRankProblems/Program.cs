using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(beautifulDays(20, 23, 6));
        }

        static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int day = i; day <= j; day++)
            {
                int num = day;
                int reverseNum = 0;
                while (num > 0)
                {
                    int remainder = num % 10;
                    reverseNum = (reverseNum * 10) + remainder;
                    num = num / 10;
                }
                if ((day - reverseNum) % k == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
