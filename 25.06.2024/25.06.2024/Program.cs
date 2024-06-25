using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _25._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Create console application that read string from user and print the same string
            Console.Write("Enter Your Name: ");
            string myName  = Console.ReadLine();
            Console.WriteLine(myName);

            ////////////////
            //2- Define variables with kind of (Double, String, Char, Bool, Int, Const)
            double h  = 1.2545166;
            string n = "Mohammad";
            char c = 'A';
            bool a = true;
            int x = 0;
            const double p = 3.14;

            Console.WriteLine(h);
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(p);

            /////////////////
            //3- Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            string[] car = { "BM", "Benz", "Oudi", "Opel" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car[3]);
            Console.WriteLine(car.Length);


            //////////////////
            ///4-	Write a program in C that reads a first name, surname and year of birth and display the names and the year one after another sequentially
            Console.Write("Input your firstname: ");
            string fName = Console.ReadLine();
            Console.Write("Input your lastname: ");
            string sName = Console.ReadLine();
            Console.Write("Input your year of birth: ");
            string age = Console.ReadLine();
            Console.WriteLine(fName +" "+ sName +" "+ age);

            //////////////////
            ///5-	Write a program in C # to store elements in an array and print it
            int[] elements = new int[10];
            for(int i = 0; i < elements.Length; i++)
            {
                elements[i] = i;
            }
            Console.Write("Elements in array are: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();


            ////////////////////
            ///Write a program in C# to find the sum of all elements of the array.
            int[] arr = { 2, 5, 8 };
            int sum = arr[0] + arr[1] + arr[2];
            Console.WriteLine("Sum of all elements stored in the array is : " + sum);









        }
    }
}
