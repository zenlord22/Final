using System;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        if (Root == null)
        {
            Root = new TreeNode(value);
        }
        else
        {
            InsertRec(Root, new TreeNode(value));
        }
    }

    private void InsertRec(TreeNode root, TreeNode newNode)
    {
        if (newNode.Value < root.Value)
        {
            if (root.Left == null)
            {
                root.Left = newNode;
            }
            else
            {
                InsertRec(root.Left, newNode);
            }
        }
        else
        {
            if (root.Right == null)
            {
                root.Right = newNode;
            }
            else
            {
                InsertRec(root.Right, newNode);
            }
        }
    }

    public void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("In-order traversal of the binary tree:");
        tree.InOrderTraversal(tree.Root);
    }
}
