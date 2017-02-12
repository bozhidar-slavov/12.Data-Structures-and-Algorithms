namespace TreeOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[n];

            ReadTree(n, nodes);

            // 1. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine($"The root of the tree is : {root.Value}");

            // 2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");
            foreach (var leaf in leafs)
            {
                Console.Write($"{leaf.Value}, ");
            }

            Console.WriteLine();

            // 3. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle nodes: ");
            foreach (var node in middleNodes)
            {
                Console.Write($"{node.Value}, ");
            }

            Console.WriteLine();

            // 4. Find longest path
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine($"Longest path is: {longestPath}");

            // 5. All paths with given sum S
            var treePaths = new List<List<int>>();
            var currentTreePath = new List<int>();
            currentTreePath.Add(root.Value);
            DFSFindPaths(treePaths, root, currentTreePath);
            Console.WriteLine("Print all paths and Sum");
            foreach (var item in treePaths)
            {
                Console.WriteLine("All paths : {0} SUM => {1}",
                    string.Join(", ", item),
                    item.Sum());
            }

            // 6. All subtrees with given sum `S` of their nodes
            Console.WriteLine("Sum of all subtrees:");
            List<TreeNode<int>> subTrees = new List<TreeNode<int>>();
            subTrees.Add(root);
            FindSubTrees(subTrees, root);

            foreach (var node in subTrees)
            {
                List<int> sum = new List<int>();
                SumElements(node, sum);
                Console.WriteLine(sum.Sum());
            }
        }

        private static void SumElements(TreeNode<int> node, List<int> sum)
        {
            sum.Add(node.Value);
            foreach (var child in node.Children)
            {
                SumElements(child, sum);
            }
        }

        private static void FindSubTrees(List<TreeNode<int>> subTrees, TreeNode<int> root)
        {
            foreach (var child in root.Children)
            {
                if (child.Children.Count > 0)
                {
                    subTrees.Add(child);
                }

                FindSubTrees(subTrees, child);
            }
        }

        private static void DFSFindPaths(List<List<int>> treePaths, TreeNode<int> root, List<int> currentTreePath)
        {
            foreach (var child in root.Children)
            {
                currentTreePath.Add(child.Value);
                if (child.Children.Count == 0)
                {
                    treePaths.Add(currentTreePath.GetRange(0, currentTreePath.Count));
                }

                DFSFindPaths(treePaths, child, currentTreePath);
                currentTreePath.RemoveAt(currentTreePath.Count - 1);
            }
        }

        private static int FindLongestPath(TreeNode<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<TreeNode<int>> FindAllMiddleNodes(TreeNode<int>[] nodes)
        {
            List<TreeNode<int>> middleNodes = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<TreeNode<int>> FindAllLeafs(TreeNode<int>[] nodes)
        {
            List<TreeNode<int>> leafs = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        private static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has no root.");
        }

        private static void ReadTree(int n, TreeNode<int>[] nodes)
        {
            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }
        }
    }
}
