using System.Security.Cryptography.X509Certificates;
using CodingChallenges.Solutions;

class WeeklyContest410Solution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        // var sol = FinalPositionOfSnake(2, new List<string>() { "RIGHT", "DOWN" });
        // var sol = FinalPositionOfSnake(3, new List<string>() { "DOWN", "RIGHT", "UP" });
        var sol = CountGoodNodes([[0, 1], [1, 2], [2, 3], [3, 4], [0, 5], [1, 6], [2, 7], [3, 8]]);
        Console.WriteLine(sol.ToString());
    }

    private int FinalPositionOfSnake(int n, IList<string> commands)
    {

        int i = 0, j = 0;

        foreach (var command in commands)
        {
            switch (command)
            {
                case "UP":
                    i -= 1;
                    break;
                case "DOWN":
                    i += 1;
                    break;
                case "LEFT":
                    j -= 1;
                    break;
                case "RIGHT":
                    j += 1;
                    break;
                default:
                    break;
            }
        }
        return (i * n) + j;

    }

    private int CountGoodNodes(int[][] edges)
    {
        var nodesToChildrenCount = new Dictionary<int, int>();
        var goodNodes = 0;
        var uniqueNodes = new HashSet<int>();

        foreach (var edge in edges)
        {
            int parentNode = edge[0];
            int childNode = edge[1];

            nodesToChildrenCount[parentNode] = nodesToChildrenCount.GetValueOrDefault(parentNode) + 1;
            uniqueNodes.Add(parentNode);
            uniqueNodes.Add(childNode);
        }

        foreach (var node in uniqueNodes)
        {
            var children = edges.Where(x => x[0] == node);
            if (children.Count() == 0)
            {
                goodNodes++;
            }
            else
            {
                var allChildrenMatch = true;
                foreach (var childEdge in children)
                {
                    int childNode = childEdge[1];

                    if (nodesToChildrenCount.TryGetValue(childNode, out var childNodeChildrenCount))
                    {
                        if (nodesToChildrenCount[node] != childNodeChildrenCount)
                        {
                            allChildrenMatch = false;
                            break;
                        }
                    }
                    else
                    {
                        allChildrenMatch = false;
                        break;
                    }

                }
                if (allChildrenMatch)
                {
                    goodNodes++;
                }
            }

        }

        Console.WriteLine("Not finished");
        return goodNodes;
    }
}