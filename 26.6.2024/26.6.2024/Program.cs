using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////Task 1
              Console.WriteLine("Enter the first integer:");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter the second integer:");
                string input2 = Console.ReadLine();

                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                int[] num = new int[2];
                num[0] = num1;
                num[1] = num2;
                Array.Sort(num);
                Console.WriteLine($"The smaller number is:  {num[0]} ");

                Console.WriteLine();
                //////////Task 2
                //Console.WriteLine("Enter a number:");
                //int number = int.Parse(Console.ReadLine());
                //if (number < 0)
                //{
                //    Console.WriteLine("The sign is -");
                //}
                //else 
                //{ 
                //    Console.WriteLine("The sign is +");
                //}
           

                int num3 = 7;
                int num4 = -24;
                string sign3 = num3.ToString("+#;-#;0");
                string sign4 = num4.ToString("+#;-#;0");
                Console.WriteLine("the sign of 7 is " + sign3[0]);
                Console.WriteLine("the sign of -24 is " + sign4[0]);

            
            Console.WriteLine();
                ///////Task 3
                ///
                Console.WriteLine("Enter three numbers9" +
                    ":");
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int number3 = int.Parse(Console.ReadLine());
                int[] arr =  { number1, number2, number3 };
                Array.Sort(arr);
                Console.WriteLine($"{arr[2]}, {arr[1]}, {arr[0]}");


                Console.WriteLine();
                ///////Task 4
                ///
                int[] ints = { 1, 2, 3, 4, 5 };
                Array.Sort(ints);
                Console.WriteLine($"The maximum number is :{ints[4]}");


                Console.WriteLine();
                ///////Task 5
                ///
                Console.WriteLine("Input kilometers per hour: ");
                int km = int.Parse(Console.ReadLine());
                double m = km * 0.625;
                Console.WriteLine($"{m} miles per hour");


                Console.WriteLine();
                ///////Task 6
                Console.WriteLine("Enter the number of hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of minutes:");
                int minutes = int.Parse(Console.ReadLine());


                int totalMinutes = (hours * 60) + minutes;
                Console.WriteLine("The total number of minutes is: " + totalMinutes);



                Console.WriteLine();
                ///////Task 7
                ///
                Console.WriteLine("Enter the number of minutes:");
                int minute = int.Parse(Console.ReadLine());
                int hour = minute / 60;
                int seconds = (minute % 60);
                Console.WriteLine($"{hour} Hours, {seconds} Minutes");


                Console.WriteLine();
                ////////Task 8
                ///
                string[] sentence = { "hello world", "Orang Academy", "Mohammad algharibeh", "wwwwwwwwwww", "nnnnnnnnnnnnnn" };
                Console.WriteLine($"the sentence {sentence[0]} his length {sentence[0].Length}");
                Console.WriteLine($"the sentence {sentence[1]} his length {sentence[1].Length}");
                Console.WriteLine($"the sentence {sentence[2]} his length {sentence[2].Length}");
                Console.WriteLine($"the sentence {sentence[3]} his length {sentence[3].Length}");
                Console.WriteLine($"the sentence {sentence[4]} his length {sentence[4].Length}");
            

        }
    }
}
