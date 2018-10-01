using System;

namespace StrukturePodataka
{
    class BinaryTree
    {
        private BinaryTreeNode root = null;


        public void Add(int value)
        {
            if (root == null)
            {
                root = new BinaryTreeNode(value);
            }
            else
            {
                AddTo(root, value);
            }
        }

        private void AddTo(BinaryTreeNode node, int value)
        {
            // left child < parent, right child >= parent

            // ako je value <
            if (value < node.Value)
            {
                if (node.LeftChild == null)
                    node.LeftChild = new BinaryTreeNode(value);
                else
                {
                    AddTo(node.LeftChild, value);
                }
            }

            // ako je value >= 
            else
            {
                if (node.RightChild == null)
                    node.RightChild = new BinaryTreeNode(value);
                else
                    AddTo(node.RightChild, value);
            }
        }

        public void Clear()
        {
            root = null;
        }

        // parent -> left -> right
        public void Preorder()
        {
            Console.WriteLine("\nPreorder:");
            PreorderTraverse(root);
        }
        private void PreorderTraverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.Value + " ");
            PreorderTraverse(root.LeftChild);
            PreorderTraverse(root.RightChild);
        }
        // left -> parent -> right
        public void InOrder()
        {
            Console.WriteLine("\nInorder:");
            InOrderTraverse(root);
        }
        private void InOrderTraverse(BinaryTreeNode root)
        {
            if (root == null)
                return;
            InOrderTraverse(root.LeftChild);
            Console.Write(root.Value + " ");
            InOrderTraverse(root.RightChild);
        }

        // left -> right -> parent
        public void PostOrder()
        {
            Console.WriteLine("\nPostOrder:");
            PostOrderTraverse(root);
        }
        private void PostOrderTraverse(BinaryTreeNode root)
        {
            if (root == null)
                return;
            PostOrderTraverse(root.LeftChild);
            PostOrderTraverse(root.RightChild);
            Console.Write(root.Value + " ");
        }



    }

    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode LeftChild { get; set; }
        public BinaryTreeNode RightChild { get; set; }
        public int Value { get; set; }


    }
}
