using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PreorderBinaryTree
{

    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }


        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }


    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }


        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }


            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);


            while (queue.Count > 0)
            {
                var current = queue.Dequeue();


                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }


                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        // Print the tree visually
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> root, int space)
        {
            int COUNT = 10;  // Distance between levels
            if (root == null)
                return;

            space += COUNT;
            PrintTree(root.Right, space);


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");


            Console.WriteLine(root.Value);


            PrintTree(root.Left, space);
        }

        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            /*
              PreOrder Traversal visits the current node before its child nodes. 
              The process for PreOrder Traversal is as follows:


                 - Visit the current node.
                 - Recursively perform PreOrder Traversal of the left subtree.
                 - Recursively perform PreOrder Traversal of the right subtree.
            */


            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }

        public int Depth = 0; 
        public int Heigth = 0; 

        //PostTravaersal 
        public void Postordertraversal(BinaryTreeNode<T> node,T Value)
        {
            if (node != null)
            {
                Postordertraversal(node.Left, Value);
                Postordertraversal(node.Right, Value);
                Console.Write(node.Value + " ");
                Heigth++;
          
            }
        }

        public void Postordertraversal(T Value)
        {
            Postordertraversal(this.Root,Value);
        }

        //Inordertraversal 

        public void InorderTraversal(BinaryTreeNode<T> RootNode)
        {
            if(RootNode != null) 
            {
                InorderTraversal(RootNode.Left);
                Console.Write(RootNode.Value+" ");
                InorderTraversal(RootNode.Right);
            }
        }

        public void InorderTraversal()
        {
            InorderTraversal(Root); 
            Console.WriteLine();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);

            binaryTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current-Left SubTree - Right SubTree):");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("\nPostOrder Traversal (Current-Left SubTree - Right SubTree):");
            binaryTree.Postordertraversal(4);

            // Console.WriteLine($"Depth is: {binaryTree.Depth}");

            Console.WriteLine("\nInOrderTraversel (Left-Root-Rigth");
            binaryTree.InorderTraversal();

            
            
            
            Console.ReadLine();


        }
    }
}