using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sum
{
    internal class Program
    {
        //https://leetcode.com/problems/3sum/
        static void Main(string[] args)
        {
            var input = new int[] { -1, 0, 1, 2, -1, -4 };
            var output = ThreeSum(input);
            Console.WriteLine(output);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            //-4, -1,-1, 0, 1, 2,

            var op = new List<IList<int>>();


            for (int i = 0; i < nums.Length-2; i++)
            {
                if (i == 0 || (i > 0 &&   nums[i] != nums[i-1] ))
                {
                    int low = i + 1;
                    int high = nums.Length - 1;
                    int sum =  0 - nums[i];

                    while(low < high)
                    {
                        if (nums[low] + nums[high] == sum)
                        {
                            op.Add(new List<int> { nums[low], nums[high], nums[i] });

                            while (low < high && nums[low] == nums[low + 1])
                            {
                                low++;
                            }

                            while (low < high && nums[high] == nums[high -1 ])
                            {
                                high--;
                            }

                            low++;
                            high--;
                        }

                        else if (nums[low] + nums[high] > sum)
                        {
                            high--;
                        }
                        else
                        {
                            low++;
                        }
                    }
                }

            }

            return op;


        }
    }
}
