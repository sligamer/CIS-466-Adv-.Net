using System;

namespace Week_6_Homework
{
    /// <summary>
    ///  CIS 466 : Advanced .Net Development with C#
    ///  Author: Justin Freres
    ///  Date: 9/20/2018
    ///  Week 6 Homework 4
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIS 466: Justin Freres Homework Week 6");
            string result;

            do
            {
                result = DisplayMenu();
                Program.Run(result);

            } while (result != "4");

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
            Console.WriteLine("Homework 4");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run Example 8.");
            Console.WriteLine("Hit [2] to run Example 9.");
            Console.WriteLine("Hit [3] to run Exercise 12.");  
            Console.WriteLine("");
            Console.WriteLine("Hit [4]: Exit;");
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
                    Example_8();
                    return true;

                case "2":
                    Example_9();
                    return true;

                case "3":
                    Example_12();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        #endregion

        #region static methods
        /*
         * The following IsEqual method, for the Name class of Example 6.3, 
         * attempts to check two Name objects for equality. 
         * They should be equal if they have the same first name, middle initial, 
         * and last name. Find and correct any errors in IsEqual.
         */

        private static void Example_8()
        {
            // test is equal
            Name.testIsEqual();
        }

        /*
         * Add a CompareTo method to the Name class (above). 
         * The CompareTo method should return – 1 when the object is less than 
         * the argument, 0 when they are equal, and 1 when the object is greater. 
         * Compare last names first. If the last names are equal, compare the 
         * first names. If the first names are equal, compare the middle initial. 
         */

        private static void Example_9()
        {
            // test compare to
            Name.testCompareTo();
        }

        /*
         * Write a C# class that contains an IDrivable object. 
         * Include an AroundTheBlock method that used IDrivable methods 
         * to drive the IDrivable object around a rectangular block. 
         * Test AoundTheBlock with a Van and a SportsCar. 
         * Your output should look something like the screenshot below.
         */

        private static void Example_12()
        {
            // init van
            Van van = new Van();
            
            // init sportscar
            SportsCar sportsCar = new SportsCar();
            
            // execute TestDrivable methods
            TestDrivable.AroundTheBlock(van);
            TestDrivable.AroundTheBlock(sportsCar);

            // pause after output
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

    }

    #region classes
    /// <summary>
    /// Name class for IsEqual and CompareTo tests
    /// </summary>
    public class Name
    {
        private String first;
        private char initial;
        private String last;

        public Name(String f, String l)
        {
            first = f;
            last = l;
        }
        public Name(String f, char i, String l) : this(f, l)
        {
            initial = i;
        }
        public override String ToString()
        {
            if (initial == '\u0000')
                return first + " " + last;
            else
                return first + " " + initial + " " + last;
        }

        public bool IsEqual(Name name)
        {
            if (first != name.first)
                return false;
            else if (initial != name.initial)
                return false;
            else return last == name.last;
        }

        public int CompareTo(Name name)
        {
            int result;
            result = last.CompareTo(name.last);
            if (result == 0)
                result = first.CompareTo(name.first);
            if (result == 0)
                result = initial.CompareTo(name.initial);
            return result;
        }

        /// <summary>
        /// Name Test Method for IsEqual
        /// </summary>
        public static void testIsEqual()
        {
            String s1 = "Wolfgang";
            String s2 = "Wolfgang";
            Name n1 = new Name(s1, 'A', "Mozart");
            Name n2 = n1;
            Name n3 = new Name(s2, 'A', "Mozart");
            Name n4 = new Name("Abraham", "Lincoln");
            Name n5 = new Name("Abraham", "Lincoln");

            Console.WriteLine("N1 = {0}", n1.ToString());
            Console.WriteLine("N2 = {0}", n2.ToString());
            Console.WriteLine("N3 = {0}", n3.ToString());
            Console.WriteLine("N4 = {0}", n4.ToString());
            Console.WriteLine("N5 = {0}", n5.ToString());
            Console.WriteLine();

            Console.WriteLine(n1.IsEqual(n2));
            Console.WriteLine(n1.IsEqual(n3));
            Console.WriteLine(n1.IsEqual(n4));
            Console.WriteLine(n1.IsEqual(n1));
            Console.WriteLine(n4.IsEqual(n5));

            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Name Test Method for CompareTo
        /// </summary>
        public static void testCompareTo()
        {
            Name n1 = new Name("Alfred", 'E', "Newman");
            Name n2 = new Name("John", 'Q', "Adams");
            Name n3 = new Name("Sam", "Spade");
            Name n4 = new Name("Alfred", 'E', "Newman");
            Console.WriteLine("N1 = {0}", n1.ToString());
            Console.WriteLine("N2 = {0}", n2.ToString());
            Console.WriteLine("N3 = {0}", n3.ToString());
            Console.WriteLine("N4 = {0}", n4.ToString());
            Console.WriteLine(n1.CompareTo(n2));
            Console.WriteLine(n1.CompareTo(n3));
            Console.WriteLine(n1.CompareTo(n4));

            Console.ReadLine();
            Console.Clear();

        }


    }

    /// <summary>
    /// TestDriveable Class for Interface Testing
    /// </summary>
    public class TestDrivable{
        /// <summary>
        /// Test Method Driving Van and Car AroundTheBlock
        /// </summary>
        /// <param name="d">IDrivable</param>
        public static void AroundTheBlock(IDrivable d)
        {
            d.Start();
            d.Accelerate();
            d.Turn("Right");
            d.Turn("Right");
            d.Turn("Right");
            d.Turn("Right");
            d.Decelerate();
            d.Stop();
        }
    }
    #endregion
}
