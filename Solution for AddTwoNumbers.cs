namespace LeetCode
{
    //Question: Problem #2 Title:Add two numbers's solution
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode sumNode = new ListNode(0);
            sumNode.next = null;            
            ListNode Temp = sumNode;
            int carry = 0;
            int _val = 0;
            while (l1 != null || l2 != null)
            {
                if (l1 == null && l2 != null)
                {
                    _val = l2.val + carry;
                    carry = _val / 10;
                    CreateNewNode(ref Temp, _val);
                    /*ListNode nextNode = new ListNode(_val % 10);
                    Temp.next = nextNode;
                    Temp = nextNode;*/
                    l2 = l2.next;
                    continue;
                }
                else if (l1 != null && l2 == null)
                {
                    _val = l1.val + carry;
                    carry = _val / 10;
                    CreateNewNode(ref Temp, _val);
                    /*ListNode nextNode = new ListNode(_val % 10);
                    Temp.next = nextNode;
                    Temp = nextNode;*/
                    l1 = l1.next;
                    continue;
                }
                _val = l1.val + l2.val + carry;
                carry = _val / 10;
                CreateNewNode(ref Temp, _val);
                /*ListNode nextNode1 = new ListNode(_val % 10);
                Temp.next = nextNode1;
                Temp = nextNode1;*/
                l1 = l1.next;
                l2 = l2.next;
            }
            if (l1 == null && l2 == null && carry != 0)
            {
                ListNode nextNode = new ListNode(carry);
                Temp.next = nextNode;
                Temp = nextNode;
            }

            return sumNode.next;
        }
        public void CreateNewNode(ref ListNode Temp,int x)
        {
            ListNode nextNode = new ListNode(x % 10);
            Temp.next = nextNode;
            Temp = nextNode;

        }
    }
}

