using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Codes
{
    internal class Program
    {
        // C# Methods <=> Functions
        // Structured, Reusable, Organized, Readable etc

        // Method: Name, Return Type, Parameters
        // Below is Mehod Definition
        
        // Method Overloading: Change number of parameters OR type of parameters
        
        // Pass By Value OR Pass by Reference
        
        public static long Add(int a, int b)
        {
            long sum = a + b;
            return sum;
          
        }
        static float Add(float a, float b)
        {
            float sum = a + b;
            return sum;
        }
        internal static long Add(int a, int b, int c)
        {
            long result = 0;
            result = a + b + c;
            return result;
        }
        
        static long Add(int [] arr)
        {
            // This method will add all the number in this array.
            long result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                result = result + arr[i];
            }
            return result;
        }
        static int[] Input()
        {
            Console.WriteLine("Enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 1");
            int b = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = { a, b };
            int[] numbers = new int[2];
            numbers[0] = a;
            numbers[1] = b;

            return numbers;
        }

        public static void IsPalindrome(string str)
        {
            string reverse = ""; 
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            if (str == reverse)
            {
                Console.WriteLine("This is a Palindrome string");
            }
            else
                Console.WriteLine("This is NOT a Palindrome string");
        }

        static void PassByVal(int num)
        {
            num = 100; 
            Console.WriteLine("From PassByVal Method : " + num);
        }
        static void PassByRef(int [] arr)
        {
            arr[0] = 200;
            Console.WriteLine("From PassByRef Method: " + arr[0]);  
        }
        /*static void Main(string[] args) // caller
        {
            // Call Input Method here;
            //int [] data = Input();
            // Call Method here.
            //long s = Add(data[0] , data[1]); // A method call for Add method
            //long s = Add(11,12);
            //Console.WriteLine(" Sum is : " + s);

            /*int[] count = { 10,20, 30 };
            float sum = Add(10.3f,20.5f);
            Console.WriteLine("Result of summing Array is : " + sum);

            IsPalindrome("ABBCBBA");
            IsPalindrome("Abc");*/

            // Value Types: int, float, char, double, long etc
            // Reference Types: Arrays...

          /*  int num = 11; // a seperate box containing 11
            Console.WriteLine("Before Call : " + num);// 11
            PassByVal(num);// pass by reference
            Console.WriteLine("After Call : " + num); // ?

            int [] arr = new int[2];
            arr[0] = 0;
            // arr[1] = 1;
            Console.WriteLine("Before Call : " + arr[0]);// 0
            PassByRef(arr);
            Console.WriteLine("After Call : " + arr[0]); // ?
        }*/

    }
}
