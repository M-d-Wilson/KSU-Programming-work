using System;

namespace _Lab_102
{
    class Stock
    {
        private string Symbol, Name;
        private double previousClosingPrice, currentPrice;

        public Stock(string N, string S, double PCP, double CP)
        {
            Name = N;
            Symbol = S;
            previousClosingPrice = PCP;
            currentPrice = CP;
        }

        public string getName()
        {
            return Name;
        }

        public string getSymbol()
        {
            return Symbol;
        }

        public double getCloseingPrice()
        {
            return previousClosingPrice;
        }

        public double getCurrentPrice()
        {
            return currentPrice;
        }

        public void setClosingPrice(double X)
        {
            X = previousClosingPrice;
        }

        public void setCurrentPrice(double X)
        {
            X = currentPrice;
        }

        public double getChangePercent()
        {
            double Per;
            Per = (getCurrentPrice() - getCloseingPrice()) / currentPrice * 100;
            Per = Math.Round(Convert.ToDouble(Per), 2);
            return Per;
        }
        public void ToString()
        {
            Console.WriteLine(getName() + " stock’s closing price is $" + getCurrentPrice());
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Name, Sym;
            double ClosPri, CurPri;
            Console.Write("What is your compony's name:                   ");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("What is your compony's Symbol:                 ");
            Sym = Convert.ToString(Console.ReadLine());
            Console.Write("What is your compony's preveus closeing price: ");
            ClosPri = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your compony's curent closeing price:  ");
            CurPri = Convert.ToDouble(Console.ReadLine());
            Stock Stock1 = new Stock(Name, Sym, ClosPri, CurPri);
            Console.Write(Stock1.getName() + " stock:\n" +
                "   Closing price:    " + Stock1.getCloseingPrice() + "\n" +
                "   Current price: 	  " + Stock1.getCurrentPrice() + "\n" +
                "   Change percent:   " + Stock1.getChangePercent() + "\n   ");
            Stock1.ToString();
        }
    }
}
