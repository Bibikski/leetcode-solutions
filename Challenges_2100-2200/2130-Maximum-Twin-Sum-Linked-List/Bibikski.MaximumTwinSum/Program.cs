using Bibikski.MaximumTwinSum;

ListNode testNode = new ListNode()
{
    val=4,
    next = new ListNode()
    {
        val = 2,
        next = new ListNode()
        {
            val = 2,
            next = new ListNode()
            {
                val=3
            }
        }
    }
};

new SumUtil().PairSum(testNode);