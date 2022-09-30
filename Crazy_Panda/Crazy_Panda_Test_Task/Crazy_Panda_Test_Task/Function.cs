using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Panda_Test_Task
{
    public static class Function
    {
        public static void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            // your code here
            ulong localSum;
            for (int i = 0; i < list.Count; i++)
            {
                localSum = 0;
                for (int j = i; j < list.Count; j++)
                {
                    localSum += list[j];
                    if (localSum > sum) break;
                    if (localSum == sum)
                    {
                        start = i;
                        end = j + 1;
                        return;
                    }
                }
            }

            start = 0;
            end = 0;
            return;
        }
    }
}
