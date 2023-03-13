using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 3

namespace _Lab_3
{
    public class Person
    {
        protected string name, address, phoneNumber, emailAddress;

        public Person(string nam, string adr, string   pho, string eml)
        {
            name = nam;
            address = adr;
            phoneNumber = pho;
            emailAddress = eml;

        }

        public virtual new void ToString()
        {
            Console.WriteLine("Person:          " + name);
            Console.WriteLine("Address:         " + address);
            Console.WriteLine("Phone Number:    " + phoneNumber);
            Console.WriteLine("Email Address:   " + emailAddress);
            Console.WriteLine();
        }
    }

    public class Student : Person
    {
        protected string classStatus;

        public Student(string nam, string adr, string   pho, string eml, string C) : base(nam, adr, pho, eml)
        {
            classStatus = C;
        }

        public override void ToString()
        {
                Console.WriteLine("Student:         " + name);
                Console.WriteLine("Address:         " + address);
                Console.WriteLine("Phone Number:    " + phoneNumber);
                Console.WriteLine("Email Address:   " + emailAddress);
                Console.WriteLine("Class Status:    " + classStatus);
                Console.WriteLine();
        }
    }

    public class Employee : Person
    {
        protected string office;
        protected int salary, year, month, day;

        public Employee(string nam, string adr, string pho, string eml, string off, int sal, int yer, int mon, int day) : base(nam, adr,   pho, eml)
        {
            office = off;
            salary = sal;
            year = yer;
            month = mon;
            this.day = day;
        }

        public override void ToString()
        {
            Console.WriteLine("Employee:        " + name);
            Console.WriteLine("Address:         " + address);
            Console.WriteLine("Phone Number:    " + phoneNumber);
            Console.WriteLine("Email Address:   " + emailAddress);
            Console.WriteLine("Office:          " + office);
            Console.WriteLine("Salary:          " + salary);
            Console.WriteLine("Day Hired: Year: " + year + " | Month: " + month + " | Day: " + day);
            Console.WriteLine();
        }
    }

    public class Faculty : Employee
    {
        protected string officeHours, rank;

        public Faculty(string nam, string adr, string pho, string eml, string off, int sal, int yer, int mon, int day, string  offHr, string rnk) : base(nam, adr,   pho, eml, off, sal, yer, mon, day)
        {
            officeHours = offHr;
            rank = rnk;
        }

        public override void ToString()
        {
            Console.WriteLine("Faculty:         " + name);
            Console.WriteLine("Address:         " + address);
            Console.WriteLine("Phone Number:    " + phoneNumber);
            Console.WriteLine("Email Address:   " + emailAddress);
            Console.WriteLine("Office:          " + office);
            Console.WriteLine("Salary:          " + salary);
            Console.WriteLine("Day Hired: Year: " + year + " | Month: " + month + " | Day: " + day);
            Console.WriteLine("Office Hours     " + officeHours);
            Console.WriteLine("Rank:            " + rank);
            Console.WriteLine();
        }
    }

    public class Staff : Employee
    {
        protected string title;

        public Staff(string nam, string adr, string pho, string eml, string off, int sal, int yer, int mon, int day, string til) : base(nam, adr, pho, eml, off, sal, yer, mon, day)
        {
            title = til;
        }

        public override void ToString()
        {
            Console.WriteLine("Staff:           " + name);
            Console.WriteLine("Address:         " + address);
            Console.WriteLine("Phone Number:    " + phoneNumber);
            Console.WriteLine("Email Address:   " + emailAddress);
            Console.WriteLine("Office:          " + office);
            Console.WriteLine("Salary:          " + salary);
            Console.WriteLine("Day Hired: Year: " + year + " | Month: " + month + " | Day: " + day);
            Console.WriteLine("Title:           " + title);
            Console.WriteLine();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            int i, In1, In2, In3, In4;
            string Str1, Str2, Str3, Str4, Str5, Str6, Str7;

            Str1 = "Rey Skywalker";
            Str2 = "4123 Moisture Farm, Outer Rim, Tatooine";
            Str3 = "444-444-4444";
            Str4 = "ReyOfHope@students.kennesaw.edu";
            Person Person = new Person(Str1, Str2, Str3, Str4);

            Str1 = "Ben Solo";
            Str2 = "78 Jedi Temple, Outer Rim";
            Str3 = "444-444-5673";
            Str4 = "BSolo@students.kennesaw.edu";
            Str5 = "Freshman";
            Person Student = new Student(Str1, Str2, Str3, Str4, Str5);

            Str1 = "Han Solo";
            Str2 = "Captain’s Quarters, Millennium Falcon";
            Str3 = "456-123-7892";
            Str4 = "HSolo@students.kennesaw.edu";
            Str5 = "Cockpit of Millennium Falcon Pilot’s Chair";
            In1 = 10000000;
            In2 = 1975;
            In3 = 12;
            In4 = 5;
            Person Employee = new Employee(Str1, Str2, Str3, Str4, Str5, In1, In2, In3, In4);

            Str1 = "Luke Skywalker";
            Str2 = "789 Hermit’s Retreat, Ahch-To";
            Str3 = "456-123-7891";
            Str4 = "LSkywalk@students.kennesaw.edu";
            Str5 = "Penthouse room in Temple";
            In1 = 5000000;
            In2 = 1975;
            In3 = 12;
            In4 = 5;
            Str6 = "5 hours";
            Str7 = "Senior";
            Person Faculty = new Faculty(Str1, Str2, Str3, Str4, Str5, In1, In2, In3, In4, Str6, Str7);

            Str1 = "Leia Organa-Solo";
            Str2 = "789 Resistance base, Outer Rim, D’Qar";
            Str3 = "456-123-7890";
            Str4 = "LOrgana@students.kennesaw.edu";
            Str5 = "Resistance Camp";
            In1 = 5500000;
            In2 = 1975;
            In3 = 12;
            In4 = 5;
            Str6 = "General";
            Person Staff = new Staff(Str1, Str2, Str3, Str4, Str5, In1, In2, In3, In4, Str6);

            Person.ToString();
            Student.ToString();
            Employee.ToString();
            Faculty.ToString();
            Staff.ToString();
        }
    }
}