using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        String _firstname;
        String _lastname;
        public Customer(String firstname, String lastname)
        {
            this._firstname = firstname;
            this._lastname = lastname;
        }
        public void printFullName()
        {
            Console.WriteLine("Full name is = {0} ",this._firstname+" "+this._lastname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic input and Output
            /*
            Console.WriteLine("Hellow World");
            Console.WriteLine("My First C# Program");
            */
            /*
            // Basic input and Output
            Console.WriteLine("Hellow World");
            Console.WriteLine("My First C# Program");
            Console.ReadLine():
            */
            /*
            // Data Types in C#      
            int a = 10;     // Integer-->4bytes
            long b = 54;    // Long--> 8bytes
            float c = 35.12F;   // floating points number-->4bytes
            double d = 24.32; //  Double--8bytes
            char E = 'a';    // For Characters-->2bytes
            String f = "Hope for the best"; //For String Values-->2bytes per chracter
            bool isGreat = true;   //For Boolean values true or false
            Console.WriteLine("It was a Great Learning");
            Console.ReadLine();
             */
            // Type Casting
            // 2Types of Casting
            // 1.Implicit Casting
            // char to int to long to double to float
            /*
            int x = 3;
            double y = x;
            float z = 'y';
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();
            */
            // 2.Explicit Casting
            /*
            double x = 3.5;
            int x1 = (int) x; 
            Console.WriteLine(x);
            Console.WriteLine(x1);
            Console.ReadLine();
            */
            // Casting by Using Builtin Methods
            /*
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            Console.ReadLine();
            */
            // User Input
            /*
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("User name is " + name);
            Console.WriteLine("Enter your age");
            int age =Convert.ToInt32 (Console.ReadLine());   //Typecasting with Convert.To Method
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();
            */
            // Maths Functions
            /*
            int a = Math.Max(344,50);
            Console.WriteLine(a);
            int b = Math.Min(44, 897);
            Console.WriteLine(b);
            double s = Math.Sqrt(36);
            Console.WriteLine(s);
            Console.WriteLine(Math.Sqrt(64));
            Console.ReadLine();
            */
            // Strings
            /*
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            string txte = "Hello World";
            Console.WriteLine(txte.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txte.ToLower());   // Outputs "hello world"
            Console.ReadLine();
            */
            // String Concatination
            /*
            string firstname = "Awais";
            string lastname = "Zafar";
            string name = string.Concat("Your Name is " + firstname, lastname);
            Console.WriteLine(name);""
            Console.ReadLine();
            */
            //string Interpolation
            /*
            Console.WriteLine("Enter Your firstname");
            string firstname= Console.ReadLine();
            Console.WriteLine("Enter Your secondname");
            string secondname= Console.ReadLine();
            Console.WriteLine($"Your FirstName is {firstname}, Your LastName is {secondname} ");
            Console.ReadLine();
            */
            //Access of Strings
            /*
            string check = "Hello";
            Console.WriteLine(check[0]);  // Outputs "H"
            Console.ReadLine();
            */
            // Index position of a specific character in a string
            /*
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
            Console.ReadLine();
            */
            /*
            ring myString = "Hello";
            Console.WriteLine(myString[1]);  // Outputs "e
            Console.ReadLine();
            */
            //substring method
            /*
            string name = "My name is Awais Zafar ";
            Console.WriteLine(name.IndexOf("is"));
            Console.WriteLine(name.Substring(3));
            //Console.WriteLine(name);
            Console.ReadLine();
            */
            // if else statement
            /*
            int time = 15;
            if (time < 10)
            {
                Console.WriteLine("Good morning");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good day."
            */
            //Switch case
            /*
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.ReadLine();
            */
            Customer c1 = new Customer("Muhammad", "Awais");
            c1.printFullName();
            //Console.ReadLine();
        }
    }
}