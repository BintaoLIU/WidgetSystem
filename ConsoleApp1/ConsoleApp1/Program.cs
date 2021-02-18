using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string Firstname = "Bintao";
        static string Lastname = "LIU";
        static int Age = 12;

        static void Main(string[] args)
        {
            //string Firstname = "Bintao";
            //string Lastname = "LIU";
            if (Age == 35)
            {
                Console.WriteLine("My name is " + Firstname + " " + Lastname);
            }
            else
            {
                Console.WriteLine("No name to print");
            }
            Console.WriteLine("My name is:" + Firstname + " " + Lastname);
            Console.WriteLine("Please press enter to exit");
            Console.ReadLine();
        }
    }
}
