using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Problem #7 Title:Revers Integer's solution
    class Q7_Reverse_Integer
    {
        public int Reverse(int x)
        {
            int reverse=0;
            if (x==0||x>Int32.MaxValue||x<Int32.MinValue)
            {
                return 0;
            }
            while (x != 0)
            {
                int reminder;
                reminder = x % 10;
                x= x / 10;
                try
                {
                    reverse = checked(reverse * 10 + reminder);
                }
                catch (System.OverflowException)
                {

                    return 0;
                } 
            }
            return reverse;
        }
    }
}
