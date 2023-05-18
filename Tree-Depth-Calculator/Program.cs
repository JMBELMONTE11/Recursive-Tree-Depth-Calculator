using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree_Depth_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure
            Branch root = new Branch();
            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            root.branches.Add(branch1);
            root.branches.Add(branch2);
            branch1.branches.Add(branch3);
            branch1.branches.Add(branch4);
            branch2.branches.Add(branch5);
            branch2.branches.Add(branch6);
            branch4.branches.Add(branch7);

            // Calculate the depth of the tree structure
            int depth = CalculateDepth(root);

            System.Diagnostics.Debug.WriteLine("The depth of the tree structure is: " + depth);
        }

        static int CalculateDepth(Branch branch)
        {
            // Base case: if the branch has no branches, return 1
            if (branch.branches.Count == 0)
            {
                return 1;
            }
            // Recursive case: find the maximum depth of the branches and add 1
            else
            {
                int maxDepth = 0;
                foreach (Branch b in branch.branches)
                {
                    int currentDepth = CalculateDepth(b);
                    if (currentDepth > maxDepth)
                    {
                        maxDepth = currentDepth;
                    }
                }
                return maxDepth + 1;
            }
        }

    }
}

class Branch
{
    public List<Branch> branches;

    public Branch()
    {
        branches = new List<Branch>();
    }
}
