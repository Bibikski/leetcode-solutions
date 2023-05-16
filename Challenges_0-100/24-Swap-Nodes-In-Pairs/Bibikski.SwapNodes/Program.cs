using Bibikski.SwapNodes;

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
node = null; 

new SwapNodes().SwapPairs(node);