using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 2

namespace _Milo_Lab1BClass
{
    public class Person
    {
        private string firstName, lastName;


        public Person()
        {
            firstName = "Bob";
            lastName = "Smith";
        }

        public Person(string First, string Last)
        {
            firstName = First;
            lastName = Last;
        }

        public string First
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Last
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public void ToString()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
