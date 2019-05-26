using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Q9
    {
        //Problem #9 Title:Palindrom Number's solution
        public bool IsPalindrome(int x)
        {
            if ((x%10==0||x>int.MaxValue||x<int.MinValue)&&x!=0)
            {
                return false;
            }
            int reverse = 0;
            int value = x;
            while (x != 0)
            {
                int reminder;
                reminder = x % 10;
                x = x / 10;
                try
                {
                    reverse = checked(reverse * 10 + reminder);
                }
                catch (System.OverflowException)
                {

                    return false;
                }
            }
            return reverse == value;
        }
    }
}
