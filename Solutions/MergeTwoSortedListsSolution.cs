using LeetCode.Solutions;

class MergeTwoSortedListsSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var a = new ListNode(1, new ListNode(2));
        var b = new ListNode(1, new ListNode(3));

        var result = MergeTwoLists(a, b);
        result.Print();
    }

    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 != null && list2 == null)
            return list1;
        if (list1 == null && list2 != null)
            return list2;

        var newNode = new ListNode();
        if (list1.val <= list2.val)
        {
            newNode.val = list1.val;
            newNode.next = MergeTwoLists(list1.next, list2);
        }
        else
        {
            newNode.val = list2.val;
            newNode.next = MergeTwoLists(list1, list2.next);
        }

        return newNode;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void Print()
        {
            var currentNode = this;
            do
            {
                Console.Write(currentNode.val);
                currentNode = currentNode.next;
            } while (currentNode != null);
            Console.WriteLine();
        }
    }

}