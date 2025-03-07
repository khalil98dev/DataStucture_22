using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplementation
{
    internal class Program
    {

        class BinaryNode<T>
        {
            public BinaryNode<T> Left { get; set; }

            public BinaryNode<T> Right { get; set; }

            public T Value { get; set; }

            public BinaryNode(T Value)
            {
                this.Value = Value;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree<T>
        {
            public BinaryNode<T> Root { get; set; }

            public BinaryTree()
            {
                Root = null;
            }


            public void Insert(T Node)
            {
                BinaryNode<T> NewNode = new BinaryNode<T>(Node);

                if (Root == null)
                {
                    Root = NewNode;
                    return;
                }
                    

                Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();

                queue.Enqueue(Root);

                while (queue.Count > 0)
                {
                    BinaryNode<T> CurrentNode = queue.Dequeue();

                    if (CurrentNode.Left == null)
                    {
                        CurrentNode.Left = NewNode;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(CurrentNode.Left);
                    }


                    if (CurrentNode.Right == null)
                    {
                        CurrentNode.Right = NewNode;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(CurrentNode.Right);
                    }


                }

            }

            public void PrintTree()
            {
                PrintTree(Root, 0);
            }


            private void PrintTree(BinaryNode<T> root, int space)
            {
                int COUNT = 8;  // Distance between levels to adjust the visual representation
               
                if (root == null)
                    return;


                space += COUNT;
                PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


                Console.WriteLine();
                for (int i = COUNT; i < space; i++)
                    Console.Write(" ");
                Console.WriteLine(root.Value); // Print the current node after space


                PrintTree(root.Left, space); // Recur on the left child
            }

        }


        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }


        }
        static void Main(string[] args)
        {

            BinaryTree<Person> tree = new BinaryTree<Person>();

            tree.Insert(new Person(1, "khalil"));
            tree.Insert(new Person(2, "Oussama"));
            tree.Insert(new Person(3, "Aniss"));
            tree.Insert(new Person(4, "Houssem"));
            tree.Insert(new Person(4, "Yazen"));
            tree.Insert(new Person(4, "Amir"));
            tree.Insert(new Person(4, "Soumia"));



            tree.PrintTree();
            Console.ReadLine();

        }
    }
}
