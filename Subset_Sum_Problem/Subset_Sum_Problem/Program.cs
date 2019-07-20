using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sum_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> set = new List<int>();
            set.Add(3);
            set.Add(34);
            set.Add(4);
            set.Add(12);
            set.Add(5);
            set.Add(2);
            int sum = 7;
            List<int> sum_set = Sum_Set(set,sum);
            foreach (var item in sum_set)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> Sum_Set(List<int> set, int sum)
        {
            List<int> sum_set = new List<int>();
            for (int i = 0; i < set.Count-1; i++)
            {
                for (int j = i+1 ; j < set.Count; j++)
                {
                    if(sum == Add(set[i],set[j]))
                    {
                        sum_set.Add(set[i]);
                        sum_set.Add(set[j]);
                    }
                }
            }
            return sum_set.Count > 1? sum_set: null;
        }

        private static int  Add(int x,int y)
        {
            return x + y;

        }
    }
}
