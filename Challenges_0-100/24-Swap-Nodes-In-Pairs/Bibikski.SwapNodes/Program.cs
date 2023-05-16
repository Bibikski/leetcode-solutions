using Bibikski.SwapNodes;

//Test Node List
ListNode node = new ListNode()
{
    val = 1,
    next = new ListNode()
    {
        val = 2,
        next = new ListNode()
        {
            val=3,
            next=new ListNode()
            {
                val = 4,
                next=new ListNode()
                {
                    val=5
                }
            }
        }
    }
};
new SwapNodes().SwapPairs(node);