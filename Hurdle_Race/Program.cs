using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurdle_Race
{
    class Program
    {
        static int hurdleRace(int k, int[] height)
        {
            int highestPots = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (k < height[i])
                {
                    if ((k+highestPots) < height[i])
                    {
                        highestPots = height[i] - k;
                    }
                }
            }
            return highestPots;
        }
    }
}
