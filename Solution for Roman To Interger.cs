using System.Collections.Generic;
namespace LeetCode
{
    internal class Q13
    {
        //Problem #13 Title:Roman to Integer's solution
        public Dictionary<char, int> romanValue = new Dictionary<char, int>
            {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
            };

        public int RomanToInt(string s)
        {
            s.ToUpper();
            int totalValue = 0;
            int preValue = 0;
            int currentValue = 0;
            foreach (var c in s)
            {
                if (!romanValue.ContainsKey(c))
                {
                    return 0;
                }
                currentValue = romanValue[c];
                totalValue += currentValue;
                if ((preValue==1&&(currentValue==10||currentValue==5))
                    || (preValue == 10 && (currentValue == 100 || currentValue == 50)) 
                    ||(preValue == 100 && (currentValue == 1000 || currentValue == 500)))
                {
                    totalValue -= 2 * preValue;
                }
                preValue = currentValue;


            }
            return totalValue;
            
            

        }
    }
}
