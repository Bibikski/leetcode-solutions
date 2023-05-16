namespace Bibikski.SwapNodes;

public class SwapNodes
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode response = new ListNode();
        if (head == null) return null; 
        if (head?.next == null && head?.val > 0)
            return head;

        int ptr = 0;
        ListNode? ptrNode = head;
        Dictionary<int, ListNode> nodes = new Dictionary<int, ListNode>(); 
        
jmp_nodeLoop:
        nodes.Add(ptr, ptrNode);
        if (ptrNode?.next != null)
        {
            ptrNode = ptrNode.next;
            ptr++;
            goto jmp_nodeLoop;
        }
        else
        {
            int nodesCount = nodes.Count; //So we do not have to interact with the dictionary more than we have to.
            for (int i = 0; i < nodesCount; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    if (i+1 == 2)
                    {
                        response = new ListNode()
                        {
                            val=nodes[i].val,
                            next = new ListNode()
                            {
                                val = nodes[i-1].val
                            }
                        };
                        ptrNode = response.next;
                    }
                    else
                    {
                        ptrNode.next = new ListNode()
                        {
                            val = nodes[i].val,
                            next = new ListNode()
                            {
                                val = nodes[i - 1].val,
                            }
                        };
                        ptrNode = ptrNode.next.next;
                    }
                }
                else if (i+1 == nodesCount && (i+1) % 2 != 0)
                {
                    ptrNode.next = new ListNode()
                    {
                        val = nodes[i].val
                    };
                }
            }
        }
        return response;
    } 
}