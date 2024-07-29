namespace LeetCode._226._Invert_Binary_Tree;


//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root != null)
        {
            var tmp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(tmp);
        }

        return root;
    }
}