using System.Runtime.CompilerServices;
using LeetCode.Solutions;

class AddTwoNumbersSolution : ILeetCodeSolution
{
    private class ListNode
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
    public void SolveProblem()
    {
        var a = new ListNode(2, new ListNode(4, new ListNode(3)));
        var b = new ListNode(5, new ListNode(6, new ListNode(4)));
        var solution = AddTwoNumbers(a, b);

        Console.WriteLine("AddTwoNumbers Solution:");
        solution.Print();

        a = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        b = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        solution = AddTwoNumbers(a, b);

        Console.WriteLine("AddTwoNumbers Solution:");
        solution.Print();
    }

    ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode outputNode = new ListNode();

        if (l1 == null)
            l1 = new ListNode();
        if (l2 == null)
            l2 = new ListNode();

        // base case
        if (l1.next == null && l2.next == null)
        {
            outputNode.val += (l1.val + l2.val);

            if (outputNode.val > 9)
            {
                var overflow = outputNode.val / 10;
                outputNode.val = outputNode.val % 10;
                var nextNode = new ListNode(overflow);
                outputNode.next = AddTwoNumbers(nextNode, null);
            }
        }

        else
        {
            outputNode.val += (l1.val + l2.val);
            if (outputNode.val > 9)
            {
                var overflow = outputNode.val / 10;
                outputNode.val = outputNode.val % 10;
                if (l1.next != null)
                {
                    l1.next.val += overflow;
                }
                else
                {
                    l2.next.val += overflow;
                }
            }
            outputNode.next = AddTwoNumbers(l1?.next, l2?.next);
        }

        return outputNode;
    }
}