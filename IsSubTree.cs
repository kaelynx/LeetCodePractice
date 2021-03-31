
// Definition for a binary tree node.
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
    public bool IsSubtree(TreeNode s, TreeNode t)
    {
        return Traverse(s, t);
    }

    public bool AreEqual(TreeNode s, TreeNode t)
    {
        if (s == null && t == null) return true;
        if (s == null || t == null) return false;
        if (s.val == t.val
           && AreEqual(s.left, t.left)
           && AreEqual(s.right, t.right)) return true;
        else return false;
    }

    public bool Traverse(TreeNode s, TreeNode t)
    {
        if (s != null)
        {
            return AreEqual(s, t) || Traverse(s.left, t) || Traverse(s.right, t);
        }
        else return false;
    }
}