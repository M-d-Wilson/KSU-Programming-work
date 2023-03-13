using System;

namespace _Lab_10
{
    public class Stack
    {
        public string[] myStack;

        public Stack()
        {
            myStack = new string[1];
        }

        public Stack(string str)
        {
            myStack = new string[1];
            myStack[0] = str;
        }

        public void Push(string x)
        {
            Console.WriteLine(myStack[0]);
            string[] tempList = new string[myStack.Length + 1];

            for (int i = 0; i < myStack.Length; i++)
            {
                tempList[i] = myStack[i];
            }
            tempList[tempList.Length - 1] = x;
            myStack = tempList;
        }

        public void Pop()
        {
            string[] tempList = new string[myStack.Length - 1];

            for (int i = 0; i < tempList.Length; i++)
            {
                tempList[i] = myStack[i];

            }
            myStack = tempList;
        }

        public string Peek()
        {
            return "\"" + myStack[myStack.Length - 1] + "\"";
        }

        public string PrintStack()
        {
            string output = "Contents of stack: ";
            for (int i = 0; i < myStack.Length; i++)
            {
                output += "\"" + myStack[i] + "\"";
            }
            return output;
        }
    }

    public class Queue
    {
        private string[] myQueue;

        public Queue()
        {
            myQueue = new string[1];
        }

        public Queue(string str)
        {
            myQueue = new string[1];
            myQueue[0] = str;
        }

        public void Push(string x)
        {
            string[] tempList = new string[myQueue.Length + 1];

            for (int i = 0; i < myQueue.Length; i++)
            {
                tempList[i] = myQueue[i];
            }
            tempList[tempList.Length - 1] = x;
            myQueue = tempList;
        }

        public void Dequeue()
        {
            string[] tempList = new string[myQueue.Length - 1];

            for (int i = 0; i < tempList.Length; i++)
            {
                tempList[i] = myQueue[i + 1];

            }
            myQueue = tempList;
        }

        public string Peek()
        {
            return myQueue[0];
        }

        public string PrintQueue()
        {
            string output = "Contents of stack: ";
            for (int i = 0; i < myQueue.Length; i++)
            {
                output += "\"" + myQueue[i] + "\" ";
            }
            return output;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            bool run = true;
            string userInput;
            Console.WriteLine("Stack Portion:");
            Console.Write("Add to Stack:");
            userInput = Console.ReadLine();
            Stack myStack = new Stack(userInput);
            Console.Write("Are you done entering (y/n)? ");
            userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "Y")
            {
                run = false;
            }
            while (run)
            {
                Console.Write("Enter something: ");
                userInput = Console.ReadLine();
                myStack.Push(userInput);
                Console.Write("Are you done entering (y/n)? ");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    run = false;
                }
            }
            Console.WriteLine("Initial contents of the stack: " + myStack.PrintStack());
            Console.WriteLine();

            Console.WriteLine("Contents before adding another item: " + myStack.PrintStack());
            Console.Write("Enter something to add to stack: ");
            userInput = Console.ReadLine();
            myStack.Push(userInput);
            Console.WriteLine("Contents after adding another item: " + myStack.PrintStack());
            Console.WriteLine();

            Console.WriteLine("Contents before removing an item: " + myStack.PrintStack());
            Console.WriteLine("Removeing: " + myStack.Peek());
            myStack.Pop();
            Console.WriteLine("Contents after removing an item: " + myStack.PrintStack());
            Console.WriteLine();

            Console.WriteLine("Contents before peeking a value from the stack: " + myStack.PrintStack());
            Console.WriteLine("Peeking: " + myStack.Peek());
            Console.WriteLine("Contents after peeking a value from the stack: " + myStack.PrintStack());
            Console.WriteLine();

            Console.WriteLine("=================================================");
            run = true;

            Console.WriteLine("Queue Portion:");
            Console.Write("Add to Queue:");
            userInput = Console.ReadLine();
            Queue myQueue = new Queue(userInput);
            Console.Write("Are you done entering (y/n)? ");
            userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "Y")
            {
                run = false;
            }
            while (run)
            {
                Console.Write("Enter something: ");
                userInput = Console.ReadLine();
                myQueue.Push(userInput);
                Console.Write("Are you done entering (y/n)? ");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    run = false;
                }
            }
            Console.WriteLine("Initial contents of the queue: " + myQueue.PrintQueue());
            Console.WriteLine();

            Console.WriteLine("Contents before adding another item: " + myQueue.PrintQueue());
            Console.Write("Enter something to add to queue: ");
            userInput = Console.ReadLine();
            myQueue.Push(userInput);
            Console.WriteLine("Contents after adding another item: " + myQueue.PrintQueue());
            Console.WriteLine();

            Console.WriteLine("Contents before removing an item: " + myQueue.PrintQueue());
            Console.WriteLine("Dequeue: " + myQueue.Peek());
            myQueue.Dequeue();
            Console.WriteLine("Contents after removing an item: " + myQueue.PrintQueue());
            Console.WriteLine();

            Console.WriteLine("Contents before peeking a value from the stack: " + myQueue.PrintQueue());
            Console.WriteLine("Peeking: " + myQueue.Peek());
            Console.WriteLine("Contents after peeking a value from the stack: " + myQueue.PrintQueue());
            Console.WriteLine();
        }
    }
}
