using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Codes
{
    internal class Tester
    {
        public static void Main(string [] args)
        {
            // Use this place for calling our designed methods;
            /*Program.IsPalindrome("abba");
            long result = Program.Add(2, 3);
            Console.WriteLine(result);
            result = Program.Add(1, 2, 3);
            Console.WriteLine(result);*/
            
            Person p1 = new Person();// This creates a Person object
            p1.age = 10;
            p1.name = "abc";
            p1.address = "1011 Austin, Texas";
            p1.PrintInfo(p1);
            //Console.WriteLine(p1.age + " , " + p1.name + " , " + p1.address);
            
            Person p2 = new Person();
            p2.age = 20;
            p2.name = "def";
            p2.address = "1011 San Francisco, CA";
            p2.PrintInfo(p2);

            //Console.WriteLine(p2.age + " , " + p2.name + " , " + p2.address);

            Person p3 = new Person("ghi", 30, "Portland, OR");
            //Console.WriteLine(p3.age + " , " + p3.name + " , " + p3.address);
            p3.PrintInfo(p3); // if your method is static
            // non static methods are called using object name
            // static method are called using Class name
            

        }
    }
}
