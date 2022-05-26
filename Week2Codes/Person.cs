using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Codes
{
    internal class Person
    {
        // Object: 1) Properties/Attributes, 2) Methods/Behaviors
        public string name;
        public int age;
        public string address;

        // Create Constructor
        public Person() // Default Constructor 
        {
            name = "";
            age = 0;
            address = "";
        }

        // Parameterized Constructor
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void PrintInfo(Person p) // non-static method
        {
            Console.WriteLine("Name : " + p.name + "  Age:  " + p.age
                + "  Address" + p.address);
        }
        public static void ErrorMessage()
        {

        }
    }
}
