using System;
namespace _Lab_9
{
    public class ArrayList
    {
        private int[] myList;

        public ArrayList()
        {
            int[] myList = new int[1];
        }

        public ArrayList(int x)
        {
            myList = new int[1];
            myList[0] = x;
        }

        public void Add(int x)
        {
            int[] tempList = new int[myList.Length + 1];

            for (int i = 0; i < myList.Length; i++)
            {
                tempList[i] = myList[i];
            }
            tempList[tempList.Length - 1] = x;
            myList = tempList;
        }

        public void Remove(int x)
        {
            int[] tempList = new int[myList.Length - 1];

            for (int i = 0; i < myList.Length; i++)
            {
                if (i < x)
                {
                    tempList[i] = myList[i];
                }
                else if (i == x)
                {

                }
                else
                {
                    tempList[i - 1] = myList[i];
                }
            }
            myList = tempList;
        }

        public int Retreve(int x)
        {
            return myList[x];
        }

        public string PrintArray()
        {
            string output = "Contents of array list: ";
            for (int i = 0; i < myList.Length; i++)
            {
                output += myList[i] + " ";
            }
            return output;
        }
    }

    public class Node
    {
        public int data;

        public Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int numb)
        {
            data = numb;
            next = null;
        }
    }

    public class LinkedList
    {
        private Node headNode;

        public LinkedList()
        {
            headNode = null;
        }

        public void AddNode(int x)
        {
            if (headNode == null)
            {
                headNode = new Node(x);
            }
            else
            {
                Node temp = new Node(x);
                Node curent = headNode;

                while (curent.next != null)
                {
                    curent = curent.next;
                }
                curent.next = temp;
            }
        }

        public void RemoveNode(int x)
        {
            Node curent = headNode;
            Node prev = headNode;

            if (x == 0)
            {
                headNode = headNode.next;
            }

            for (int i = 0; i < x; i++)
            {
                prev = curent;
                curent = curent.next;
            }
            prev.next = curent.next;
        }

        public int ReturnVlaue(int x)
        {
            Node curent = headNode;

            for (int i = 0; i < x; i++)
            {
                curent = curent.next;
            }
            return curent.data;
        }

        public string AllNodes()
        {
            string output = "Contents in Linked List: ";
            Node curent = headNode;

            while(curent.next != null)
            {
                output += curent.data + " "; 
                curent = curent.next;
            }
            output += curent.data + " ";
            return output;
        }
    }
}
