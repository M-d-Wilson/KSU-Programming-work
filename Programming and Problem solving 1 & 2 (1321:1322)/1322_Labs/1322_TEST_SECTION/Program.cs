
\using System;

namespace _TEST_SECTION
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(27%5 == 2%5);
        }
            //public class BinaryTreE
            //{
            //    public Node root;

            //    public void AddNode(int value, string name)
            //    {
            //        Node nodeToAdd = new Node(value, name);
            //        Node curentNode = root;
            //        bool placeing = true;
            //        if (root == null)
            //        {
            //            root = nodeToAdd;
            //        }
            //        else
            //        {
            //            while (placeing)
            //            {
            //                if (curentNode.value > nodeToAdd.value)
            //                {
            //                    if (curentNode.rhNode == null)
            //                    {
            //                        curentNode.rhNode = nodeToAdd;
            //                        placeing = false;
            //                    }
            //                    else
            //                    {
            //                        curentNode = curentNode.rhNode;
            //                    }
            //                }
            //                else
            //                {
            //                    if (curentNode.lhNode == null)
            //                    {
            //                        curentNode.lhNode = nodeToAdd;
            //                        placeing = false;
            //                    }
            //                    else
            //                    {
            //                        curentNode = curentNode.lhNode;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    public void InOrderTraversal(Node parent)
            //    {
            //        if (parent.lhNode != null)
            //        {
            //            InOrderTraversal(parent.lhNode);
            //        }

            //        Console.WriteLine(parent);

            //        if (parent.rhNode != null)
            //        {
            //            InOrderTraversal(parent.rhNode);
            //        }
            //    }

            //    public void PreOrderTraversal(Node parent)
            //    {
            //        Console.WriteLine(parent);

            //        if (parent.lhNode != null)
            //        {
            //            PreOrderTraversal(parent.lhNode);
            //        }

            //        if (parent.rhNode != null)
            //        {
            //            PreOrderTraversal(parent.rhNode);
            //        }
            //    }

            //    public void PostOrderTraversal(Node parent)
            //    {
            //        if (parent.lhNode != null)
            //        {
            //            PostOrderTraversal(parent.lhNode);
            //        }

            //        if (parent.rhNode != null)
            //        {
            //            PostOrderTraversal(parent.rhNode);
            //        }

            //        Console.WriteLine(parent);
            //    }
            //}

            //public class Node
            //{
            //    public int value;
            //    public string name;
            //    public Node rhNode, lhNode;

            //    public Node(int value, string name)
            //    {
            //        this.value = value;
            //        this.name = name;
            //    }

            //    public void AssignRhNode(Node toSet)
            //    {
            //        rhNode = toSet;
            //    }

            //    public void AssignLhNode(Node toSet)
            //    {
            //        lhNode = toSet;
            //    }

            //    public string ToString()
            //    {
            //        return name + "has value" + value;
            //    }
            //}
        }
}

