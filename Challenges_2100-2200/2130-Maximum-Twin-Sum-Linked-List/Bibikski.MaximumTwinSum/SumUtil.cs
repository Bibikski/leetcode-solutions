namespace Bibikski.MaximumTwinSum;

public class SumUtil
{
    public int PairSum(ListNode head)
    {
        int maxSum = 0;
        int totalElements = 0;
        int ptr = 0;
        Dictionary<int, int> nodeValues = new Dictionary<int, int>();
        ListNode ptrNode = head;
        
jmp_nextNode:
        nodeValues.Add(totalElements, ptrNode.val);
        totalElements++;
        if (ptrNode.next != null)
        {
            ptrNode = ptrNode.next;
            goto jmp_nextNode;  
        }

        if (totalElements % 2 == 0)
        {
            int totalResults = totalElements / 2;
            List<int> sums = new List<int>(totalResults);
            for (int i = 0; i < totalResults; i++)
            {
                sums.Add(nodeValues[i] + nodeValues[(totalElements-1)-i]); 
            }
            maxSum = sums?.OrderByDescending(x=>x)?.FirstOrDefault() ?? 0;
        }
        return maxSum;
    } 
}