using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter6
{
    internal class Sample609
    {
        static public void Run()
        {
            try
            {
                int result = GetNum(4);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        } 

        static int GetNum(int i)
        {
            int[] nums = { 300, 600, 900 };
            if (i >= nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
    }
}
