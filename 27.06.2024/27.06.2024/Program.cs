using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _27._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Correct the syntax error:

            //	string[] ARR = [1, 7  9  45,]
            //	int arr2 = ["Str" "alex","moh"
            //	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            //	
            int[] ARR = { 1, 7, 9, 45 }; //Changed data type to integer, Change braces to curly braces, adding commas and semicolons.

            string[] arr2 = { "Str", "alex", "moh" }; //Changed data type to string and definition of array, Change braces to curly braces, adding commas and semicolons.

            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };//Changed data type to string and definition of array, Change braces to curly braces and change single quotaion to double quotaion.



            //2- What the index of "Banana","Tomato"?

            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            int indexBanana = Array.IndexOf(fruits, "Banana");
            int indexTomato = Array.IndexOf(fruits, "Tomato");

            Console.WriteLine("Index of Banana: " + indexBanana);
            Console.WriteLine("Index of Tomato: " + indexTomato);


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            //3-	Create an multiple arrays that represents your:
            //        	Favorite Food(5 item)
            //        	Favorite Sport(3 item)
            //        	Favorite Movie(4 item)
            //         Then, print each array using foreach, and Loop Through an Array

            string[] favoriteFood = { "Pizza", "Shawarma", "Lazania", "Burger", "Mansaf" };
            string[] favoriteSport = { "Footboll", "Fifa", "Playstation" };
            string[] favoriteMovie = { "Black Panther", "interstaler", "Joker", "One piece" };

            foreach (string food in favoriteFood)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine();
            foreach (string sport in favoriteSport)
            {
                Console.WriteLine(sport);
            }
            Console.WriteLine();
            foreach (string movie in favoriteMovie)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
            Console.WriteLine("using loop:");
            int i = 0;
            while (i < favoriteFood.Length)
            {
                Console.WriteLine(favoriteFood[i]);
                i++;
            }
            Console.WriteLine();
            int j = 0;
            while (j < favoriteSport.Length)
            {
                Console.WriteLine(favoriteSport[j]);
                j++;
            }
            Console.WriteLine();
            int h = 0;
            while (h < favoriteMovie.Length)
            {
                Console.WriteLine(favoriteMovie[h]);
                h++;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            ////////////4-	Write a program in C# to calculate the sum of three numbers with getting 
            ///input in one line separated by a comma
            ///
            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            int sum = num1 + num2 + num3;

            Console.WriteLine($"The sum of three numbers: {sum}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            ///5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            ///
            string s = "";
            int sums = 0;
            for (int n = 0; n < 100; n++)
            {
                if (n % 2 != 0)
                {
                    s += $" {n}";
                    sums += n;
                }
            }
            Console.WriteLine($"The odd numbers are {s}");
            Console.WriteLine($"The Sum of odd Numbers is: {sums}");

             //6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //
            for (int q = 1; q <= 4; q++)
            {
                for (int w = 1; w <= q; w++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            ////- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            /////
            int v = 1;
            for (int q = 1; q <= 4; q++)
            {
                for (int w = 1; w <= q; w++)
                {
                    Console.Write(v);
                    v++;
                }
                Console.WriteLine();
            }
            









        }
    }
}
