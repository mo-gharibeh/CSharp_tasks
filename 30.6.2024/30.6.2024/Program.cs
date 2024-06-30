using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[] numbers = new double[10]; 
            //Console.WriteLine("Enter 10 numbers: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //sumAvarage(numbers);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------0");
            Console.WriteLine();

            Console.WriteLine("Enter number of terms : ");
            int nTerms = Convert.ToInt32(Console.ReadLine());
            cube(nTerms);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------0");
            Console.WriteLine();

            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //int[] newYear = getYears(years);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------0");
            Console.WriteLine();

            Console.WriteLine("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            //int ageDay = (ageInDay(age));
            Console.WriteLine($"Your age in day is : {ageInDay(age)}");

            Console.WriteLine();
            Console.WriteLine("-------------------------------------0");
            Console.WriteLine();

            Employee person = new Employee(25,"male","mohammad","@gmail.com",379328,0787598738 );
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Gender: {person.Gender}");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"ID: {person.ID}");
            Console.WriteLine($"Phone: {person.Phone}");
        }

        //T1
        public static void sumAvarage(double[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i]);
            }
            double ava = (double)sum / 10;
            Console.WriteLine($"the sum of numbers = {sum} and the avarage = {ava}");

        }

        //T2
        public static void cube(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int con = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {con}");
            }
        }

        //T3
        public static int getYears(int[] years)
        {
            int count = 0;
            foreach (int year in years)
            {
                if (year > 1950) { count++; }
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    result[index++] = year;
                }
            }
            return result[count];

        }

        //T4
        public static int ageInDay(int year)
        {
            int day = year * 365;
            return day;
        }
    }
    //T5
    public class Employee
    {
        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public int ID;
        public int Phone;


        public Employee(int age, string gender, string name, string email, int iD, int phone)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Email = email;
            ID = iD;
            Phone = phone;
        }
    }
}
