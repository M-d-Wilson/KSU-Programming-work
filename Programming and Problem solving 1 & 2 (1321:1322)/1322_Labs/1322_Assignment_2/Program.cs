using System;
using System.Collections;
using System.Collections.Generic;

namespace _Assignment_2
{
    abstract class Vacation
    {
        protected int buget;
        protected string destination;

        public abstract int WithinBuget();

        public virtual new void ToString()
        {
            Console.WriteLine("Vacation: \n" +
                              "Buget:  $" + buget + "\n" +
                              "Destination:  " + destination);
        }
    }

    class AllInclusive : Vacation
    {
        protected int price, rating;
        protected string brand;

        public AllInclusive(int buget, string destination, int price, int rating, string brand)
        {
            this.buget = buget;
            this.destination = destination;
            this.price = price;
            this.rating = rating;
            this.brand = brand;
        }

        public override int WithinBuget()
        {
            int sum = buget - price;
            return sum;
        }

        public override void ToString()
        {
            Console.WriteLine("All Inclusive: \n" +
                              "Buget:  $" + buget + "\n" +
                              "Destination:  " + destination + "\n" +
                              "Price:  $" + price + "\n" +
                              "Rating:  " + rating + "\n" +
                              "Brand:  " + brand);
        }
    }

    class PiecemealVacation : Vacation
    {

        protected ArrayList vacaItems;
        protected int[] itemCost;

        public PiecemealVacation(int buget, string destination, ArrayList Items, List<int> Cost)
        {
            this.buget = buget;
            this.destination = destination;
            vacaItems = new ArrayList(Items);
            itemCost = Cost.ToArray();
        }

        public override int WithinBuget()
        {
            int price = 0, sum;
            for (int i = 0; i < itemCost.Length; i++)
            {
                price += itemCost[i];
            }
            sum = buget - price;
            return sum;
        }

        public override void ToString()
        {
            Console.WriteLine("Piecemeal Vacation: \n" +
                              "Buget:  $" + buget + "\n" +
                              "Destination: " + destination + "\n" +
                              "Vacation Items: ");
            for(int i = 0;i < vacaItems.Count;i++)
            {
                Console.WriteLine(vacaItems[i] + "-$" + itemCost[i] + "\n");
            }
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            int buget, price, rating, temp;
            string destination, brand, name;
            bool more = true;
            ArrayList items = new ArrayList();
            List<int> piecePrice = new List<int>();

            Console.Write("Please enter All-Inclusive Vacation's budget: ");
            buget = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter All-Inclusive Vacation's destination: ");
            destination = Console.ReadLine();
            Console.Write("Please enter All-Inclusive Vacation's brand: ");
            brand = Console.ReadLine();
            Console.Write("Please enter All-Inclusive Vacation's rating: ");
            rating = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter All-Inclusive Vacation's price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Vacation Vaca1 = new AllInclusive(buget, destination, price, rating, brand);
            Vaca1.ToString();
            temp = Vaca1.WithinBuget();
            if(temp < 0)
            {
                temp *= -1;
                Console.WriteLine("This vacation was $" + temp + " over budget.");
            }
            else
            {
                Console.WriteLine("This vacation was $" + temp + " under budget.");
            }

            Console.Write("Please enter Piecemeal Vacation's budget: ");
            buget = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Piecemeal Vacation's destination: ");
            destination = Console.ReadLine();
            while (more)
            {
                Console.Write("Please enter Piecemeal Vacation's items: ");
                name = Console.ReadLine();
                Console.Write("Please enter " + name + " cost: ");
                temp = Convert.ToInt32(Console.ReadLine());
                items.Add(name);
                piecePrice.Add(temp);
                Console.Write("Have you finished entering all items? ");
                name = Console.ReadLine();
                if (name == "Yes" || name == "yes")
                {
                    more = false;
                }
            }
            Vacation Vaca2 = new PiecemealVacation(buget, destination, items, piecePrice);
            Vaca2.ToString();
            temp = Vaca2.WithinBuget();
            if (temp < 0)
            {
                temp *= -1;
                Console.WriteLine("This vacation was $" + temp + " over budget.");
            }
            else
            {
                Console.WriteLine("This vacation was $" + temp + " under budget.");
            }
        }
    }
}
