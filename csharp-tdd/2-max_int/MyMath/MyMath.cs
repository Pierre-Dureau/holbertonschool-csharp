using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Represent the Operations class
    /// </summary>
    public class Operations
    {

        public static int Max(List<int> nums)
        {
            int max = 0;

            if (nums.Count == 0)
                return max;

            max = nums[0];

            foreach (var item in nums)
            {
                if (item > max)
                    max = item;
            }

            return max;
        }
    }
}
