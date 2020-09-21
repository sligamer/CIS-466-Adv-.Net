using System;
using System.Collections.Generic;

namespace Week_7_Homework
{
    /// <summary>
    ///  CIS 466 : Advanced .Net Development with C#
    ///  Author: Justin Freres
    ///  Date: 10/23/2018
    ///  Week 7 Homework 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIS 466: Justin Freres Homework Week 7");
            string result;
            
            do
            {
                result = DisplayMenu();
                Program.Run(result);

            } while (result != "6");

            Console.WriteLine(" Good Bye...");
        }

        #region menu application

        /// <summary>
        /// Menu Code
        /// By: James Bateman
        /// Modified by: Justin Freres
        /// </summary>
        /// <returns>Return Values</returns>
        public static string DisplayMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Homework 5");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run Exercise_7_8.");
            Console.WriteLine("Hit [2] to run Exercise_7_11.");
            Console.WriteLine("Hit [3] to run Exercise_7_23.");
            Console.WriteLine("Hit [4] to run Exercise_7_19a.");
            Console.WriteLine("Hit [5] to run Exercise_7_19b.");
            Console.WriteLine("");
            Console.WriteLine("Hit [6]: Exit;");
            Console.WriteLine("");
            Console.WriteLine("");

            string result = Console.ReadLine();

            return result;
        }

        /// <summary>
        /// Run Static Method
        /// By: James Bateman
        /// Modified by: Justin Freres
        /// </summary>
        /// <param name="x">Input Arguments</param>
        /// <returns>Return Values</returns>
        private static bool Run(string x)
        {
            switch (x)
            {

                case "1":
                    Exercise_7_8();
                    return true;

                case "2":
                    Exercise_7_11();
                    return true;

                case "3":
                    Exercise_7_23();
                    return true;

                case "4":
                    Exercise_7_19a();
                    return true;

                case "5":
                    Exercise_7_19b();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

      
        /*
         * A word is a palindrome if it reads the same backwards and forwards. 
         * For example, dad and otto are palindromes but hat and boat are not. 
         * The follow program attempts to find whether a word is a palindrome. 
         * The user enters the number of characters in the word, and then enters 
         * each character, using only lowercase characters. 
         * Find and correct any errors in this program. 
         */

        private static void Exercise_7_8()
        {
            // Test Palindrome
            Pal.Test_Palindrome();
        }


        /*
         * Do Exercise 11 on page 290 of your text. 
         * Use the method below to test your work. 
         * Example 7.7 (StudentScoreMulti.cs) is attached for reference. 
         * The Class, Method, and variable names can be changed to suite your 
         * implementation.
         */

        private static void Exercise_7_11()
        {
            /* Uses a multidimensional array.
            * Computes the average score of 
            * each student.
            */

            int[,] student = { { 52, 76, 65 }, { 98, 87, 93 }, { 43, 77, 62 }, { 72, 73, 74 } };

            Exercise_7_11 s = new Exercise_7_11(student);

            double[] averages = new double[student.GetLength(0)];
            for (int i = 0; i < student.GetLength(0); i++)
                averages[i] = s.computeAverage(i);
            s.Display(averages);


            Console.ReadLine();
            Console.Clear();

        }

        /*
         * A company has three regions, with five stores in the first region, 
         * three in the second, and two in the third. 
         * Input the weekly sales for each store. 
         * Find the average weekly sales for each region and for the whole company.
         */

        private static void Exercise_7_23()
        {
            int[][] stores = new int[3][];
            stores[0] = new int[] { 100, 100, 100, 100, 100 };
            stores[1] = new int[] { 200, 200, 200 };
            stores[2] = new int[] { 300, 300 };

            //int[,] stores = { {  }, {  }, {  } };

            Exercise_7_23 s = new Exercise_7_23(stores);

            double[] averages = new double[stores.GetLength(0)];
            for (int i = 0; i < stores.GetLength(0); i++)
                averages[i] = s.computeAverage(i);
            s.Display(averages);


            Console.ReadLine();
            Console.Clear();
        }

		/*
         * Generate an array of 20 random integers from zero to nine. Search for the first
         * occurence, if any, of the number 7, and report its position in the array.
         */
		private static void Exercise_7_19a()
		{
			int result;
			int[] array = new int[20];
			RandomOCa r = new RandomOCa(array);
			int x = 7;
			array = r.GenRandomTwenty(array);
			result = r.GetFirstOc(array, x);

			if (result != -1)
				Console.WriteLine("The first seven occurs at index {0}", result);
			for (int i = 0; i < array.Length; i++)
				Console.Write("{0}{1}{2},", "",  array[i].ToString(), "" );

		}

        /*
         * Repeat the computation of part a 1000 times, and for each position in the array, report
         * the number of times that the first occurence of a 7 in the array is at that position.
         */
        private static void Exercise_7_19b()
        {
            int result;
            List<int> Occurences = new List<int>();
            for (int i = 0; i <= 1000; i++)
            {
                int[] array = new int[20];
                RandomOCb r = new RandomOCb(array);
                int x = 7;
                array = r.GenRandomTwenty(array);
                result = r.GetFirstOc(array, x);

                if (result != -1)
                    Occurences.Add(result);                

            }
            foreach (var item in Occurences)
            {
                Console.WriteLine("{0}", item);
            }
        }

        #endregion

    }

	internal class Exercise_7_11
    {
        private int[,] student;

        public Exercise_7_11(int[,] student)
        {
            this.student = student;
        }

        internal double computeAverage(int i)
        {            
            double sum = 0;
            for (int j = 0; j < student.GetLength(1); j++)
            {
                sum += student[i, j];
            }
            return sum / student.GetLength(1);
        }

        internal void Display(double[] averages)
        {
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine("The average score for student {0} is {1:F1}", i, averages[i]);
            }
        }
    }   
    internal class Exercise_7_23
    {
        private int[][] stores;

        public Exercise_7_23(int[][] stores)
        {
            this.stores = stores;
        }

        internal double computeAverage(int i)
        {
            double sum = 0;
            for (int j = 0; j < stores[i].GetLength(0); j++)
            {
                sum += stores[i][j];
            }
            return sum / stores.GetLength(0);
        }

        internal void Display(double[] averages)
        {
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine("{1:F1} is the average at store {0}", i, averages[i]);
            }
        }
    }
    internal class RandomOCa
    {
        private int[] array;

        public RandomOCa(int[] array)
        {
            this.array = array;
        }

        internal int[] GenRandomTwenty(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 9);
            }
            return array;
        }

        internal int GetFirstOc(int[] array, int x)
        {
            return Array.IndexOf(array, x);
        }
    }
    internal class RandomOCb
    {
        private int[] array;

        public RandomOCb(int[] array)
        {
            this.array = array;
        }

        internal int[] GenRandomTwenty(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }

        internal int GetFirstOc(int[] array, int x)
        {
            return Array.IndexOf(array, x);
        }
    }
    internal class Pal
    {
        public static void Test_Palindrome()
        {
            Console.Write("How many characters? ");
            int size= int.Parse(Console.ReadLine());
            char[] a = new char[size];            
            // for (int i = 0; i < a.length; i++) - array Length is uppercase L
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter next character: ");
                //a[i] = int.Parse(Console.ReadLine());// - cannot convert int to char
                a[i] = char.Parse(Console.ReadLine());
            }
            Console.Write("The word ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]);
            for (int i = 0, b = a.Length - 1; b !=0;)
            {            
                if (a[i] != a[b])
                {
                    Console.WriteLine(" is not a palindrome");
                    //Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine(" is a palindrome");
                    break;
                }
            }
        }
    }


}
