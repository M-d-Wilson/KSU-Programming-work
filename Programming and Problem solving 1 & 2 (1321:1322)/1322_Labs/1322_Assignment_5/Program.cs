using System;

namespace _Assignment_5
{
    public class BirdSpecies
    {
        private string Name;
        private int numbOfBirds;

        public BirdSpecies(string str)
        {
            Name = str;
            numbOfBirds = 1;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string str)
        {
            Name = str;
        }

        public void AddBird()
        {
            numbOfBirds++;
        }

        public int GetNumb()
        {
            return numbOfBirds;
        }
    }

    public class Node
    {
        private BirdSpecies Bird;

        public int index;
        public Node next;

        public Node()
        {
            Bird = new BirdSpecies("Bird Bird");
            index = 0;
            next = null;
        }

        public Node(int numb, string str)
        {
            Bird = new BirdSpecies(str);
            index = numb;
            next = null;
        }

        public void AddNode(Node node)
        {
            next = node;
        }

        public void RemoveNode()
        {
            next = null;
        }

        public string GetBirdName()
        {
            return Bird.GetName();
        }

        public void SetBirdName(string str)
        {
            Bird.SetName(str);
        }

        public void AddBirdNumb()
        {
            Bird.AddBird();
        }

        public int GetBirdNumb()
        {
            return Bird.GetNumb();
        }
    }

    public class LinkedList
    {
        private Node headNode;

        public LinkedList()
        {
            headNode = null;
        }

        public void AddBird(string str)
        {
            int i = 1;
            bool checkForDup = true;
            Node curent = headNode;

            while (checkForDup)
            {
                if (headNode == null )
                {
                    checkForDup = false;
                }
                else
                {
                    if (curent.GetBirdName() == str)
                    {
                        curent.AddBirdNumb();
                        Console.WriteLine("Entered bird species: " + str + ", count increased to" + curent.GetBirdNumb() + ".");
                        return;
                    }

                    if (curent.next == null)
                    {
                        checkForDup = false;
                    }
                    curent = curent.next;
                }
            }

            if (headNode == null)
            {
                headNode = new Node(0, str);
                Console.WriteLine("Entered bird species: " + str + " at position "+ headNode.index +".");
                return;
            }
            else
            {
                curent = headNode;

                while (curent.next != null)
                {
                    curent = curent.next;
                    i++;
                }
                curent.next = new Node(i, str);
            }
            Console.WriteLine("Entered bird species: " + str + " at position " + curent.next.index + ".");
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

        public string AllNodes()
        {
            string output = "Contents in Linked List: ";
            Node curent = headNode;

            while (curent.next != null)
            {
                output += "\n" + curent.GetBirdName() + " with count " + curent.GetBirdNumb();
                curent = curent.next;
            }
            output += "\n" + curent.GetBirdName() + " with count " + curent.GetBirdNumb();
            return output;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;
            LinkedList NodeList = new LinkedList();
            bool run = true;
            string userInput;
            Console.Write("Enter a bird species: ");
            userInput = Console.ReadLine();
            NodeList.AddBird(userInput);
            Console.Write("Are you done entering birds? ");
            userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == "done")
            {
                run = false;
            }
            while (run)
            {
                count++;
                Console.Write("Enter a bird species: ");
                userInput = Console.ReadLine();
                NodeList.AddBird(userInput);
                Console.Write("Are you done entering birds? ");
                userInput = Console.ReadLine();
                userInput.ToLower();
                if (userInput == "done")
                {
                    run = false;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Contents of the list:");
            Console.WriteLine(NodeList.AllNodes());
        }
    }
}
