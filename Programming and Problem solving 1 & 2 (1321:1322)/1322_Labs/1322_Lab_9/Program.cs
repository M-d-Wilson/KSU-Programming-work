using System;

namespace _Lab_9
{ 

    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList NodeList = new LinkedList();
            bool run = true;
            int temp;
            string userInput;
            Console.WriteLine("Array List Portion: ");
            Console.Write("Enter a number: ");
            temp = Convert.ToInt32(Console.ReadLine());
            ArrayList arrList = new ArrayList(temp);
            Console.Write("Are you done entering numbers (y/n)? ");
            userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "Y")
            {
                run = false;
            }
            while (run)
            {
                Console.Write("Enter a number: ");
                temp = Convert.ToInt32(Console.ReadLine());
                arrList.Add(temp);
                Console.Write("Are you done entering numbers (y/n)? ");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    run = false;
                }
            }
            Console.WriteLine();

            Console.WriteLine(arrList.PrintArray());
            Console.Write("Please enter another number to add: ");
            temp = Convert.ToInt32(Console.ReadLine());
            arrList.Add(temp);
            Console.WriteLine(arrList.PrintArray());
            Console.WriteLine();

            Console.WriteLine(arrList.PrintArray());
            Console.Write("Please enter the index of the element to remove: ");
            temp = Convert.ToInt32(Console.ReadLine());
            arrList.Remove(temp);
            Console.WriteLine(arrList.PrintArray());
            Console.WriteLine();

            Console.WriteLine(arrList.PrintArray());
            Console.Write("Please enter the index of the element to retrieve: ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element at position " + temp + " is: " + arrList.Retreve(temp));
            Console.WriteLine(arrList.PrintArray());
            Console.WriteLine();

            Console.WriteLine("=================================================");
            run = true;
            Console.WriteLine("Linked List Portion: ");
            Console.Write("Enter a number: ");
            temp = Convert.ToInt32(Console.ReadLine());
            NodeList.AddNode(temp);
            Console.Write("Are you done entering numbers (y/n)? ");
            userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "Y")
            {
                run = false;
            }
            while (run)
            {
                Console.Write("Enter a number: ");
                temp = Convert.ToInt32(Console.ReadLine());
                NodeList.AddNode(temp);
                Console.Write("Are you done entering numbers (y/n)? ");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    run = false;
                }
            }
            Console.WriteLine();

            Console.WriteLine(NodeList.AllNodes());
            Console.Write("Please enter another number to add: ");
            temp = Convert.ToInt32(Console.ReadLine());
            NodeList.AddNode(temp);
            Console.WriteLine(NodeList.AllNodes());
            Console.WriteLine();

            Console.WriteLine(NodeList.AllNodes());
            Console.Write("Please enter an index to remove: ");
            temp = Convert.ToInt32(Console.ReadLine());
            NodeList.RemoveNode(temp);
            Console.WriteLine(NodeList.AllNodes());
            Console.WriteLine();

            Console.WriteLine(NodeList.AllNodes());
            Console.Write("Please enter an index to retrieve: ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element at position " + temp + " is: " + NodeList.ReturnVlaue(temp));
            Console.WriteLine(NodeList.AllNodes());
            Console.WriteLine();
        }
    }
}
