using System;
using static System.IO.Stream;

namespace Week_3_Homework
{
    /// <summary>
    ///  CIS 466 : Advanced .Net Development with C#
    ///  Author: Justin Freres
    ///  Date: 9/8/2018
    ///  Week 3 Homework 2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIS 466: Justin Freres Homework Week 2");
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
            Console.WriteLine("Homework 2");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run Exercise 21.");
            Console.WriteLine("Hit [2] to run Exercise 25.");
            Console.WriteLine("Hit [3] to run Exercise 27.");    
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
                    Exercise21();
                    return true;

                case "2":
                    Exercise25();
                    return true;

                case "3":
                    Exercise27();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }


        #endregion

        #region static methods
        
        /*
         * Write a C# program to perform geometric calculations.  Let the use choose whether
         * to find the area of a cirle, the circumference of a circle, or the volume of a 
         * cylinder. Allow the user to repeat as often as desired.
         */

        /// <summary>
        /// static method to execute exercise21
        /// Find the area of a circle
        /// Find the circumference of a circle
        /// Find the volume of a cyliner
        /// </summary>
        private static void Exercise21()
        {
            string result;
            do
            {

                // declare variables             
                double radius, height;

                // micro menu for exercise 21
                Console.WriteLine("Choose from the following list");
                Console.WriteLine("1. Find the area of a circle");
                Console.WriteLine("2. Find the circumference of a circle");
                Console.WriteLine("3. Find the volume of a cyliner");
                Console.WriteLine("4. Quit");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice, 1, 2, 3, or 4: ");

                result = Console.ReadLine();

                switch (result)
                {
                    case "1":
                        // find the area of a circle              
                        Console.Write("Enter a radius: ");

                        // accept input    
                        radius = double.Parse(Console.ReadLine());

                        // output results
                        Console.WriteLine("The Area of your circle is: {0:F2}", CalcArea(radius));

                        // pause after output
                        Console.WriteLine("Hit any key to continue..");
                        Console.Read();
                        break;

                    case "2":
                        // find the circumference of a circle
                        Console.Write("Enter a radius: ");

                        // accept input    
                        radius = double.Parse(Console.ReadLine());

                        // output results
                        Console.WriteLine("The Circumfernce of your circle is: {0:F2}", CalcCircumference(radius));

                        // pause after output
                        Console.WriteLine("Hit any key to continue..");
                        Console.Read();
                        break;

                    case "3":
                        // find the volume of a cyliner
                        Console.Write("Enter a radius: ");

                        // accept input    
                        radius = double.Parse(Console.ReadLine());

                        Console.Write("Enter a height: ");

                        // accept input    
                        height = double.Parse(Console.ReadLine());
                        
                        // output results
                        Console.WriteLine("The Volume of your cylinder is: {0:F2}", CalcVolume(radius, height));

                        // pause after output
                        Console.WriteLine("Hit any key to continue..");
                        Console.Read();
                        break;

                    default:
                        break;
                }


            } while (result != "4");
        }

        /*
         * The Sturdy company is evaluating an inbestment that will return $400000 at the end of
         * five years. The company wants to earn an interest rate of 20% compounded annually.
         * How much shoud they pay for this investment? Use the formula: P = V / (1 + r/100)^n
         */

        /// <summary>
        /// static method to execute exercise25 
        /// Fint teh amount paid for investment
        /// </summary>
        private static void Exercise25()
        {
            // output results
            Console.WriteLine("The present value is : {0:C2}", CalcInvestment());

            // pause after output
            Console.WriteLine("Hit any key to continue..");
            Console.Read();
        }


        /*
         * Compute e^x where
         * e^x = 1 + x/1! + x^2/2! + x^3/3! + ...    ... x^n/n! + ...
         * and n! = n(n-1 (n-2) ...    ...1, the product of the integers from 1 to n. (We pro-
         * nounce the expression n! as "n factorial.")  Let the user input the value of x, of type double.
         * Countinue adding terms until the difference of successive terms in less than 1.0
         * E-6. Compare your answer witht the C# method Math.Exp(x). 
         *
         */

        /// <summary>
        /// static method to execute exercise27
        /// </summary>
        private static void Exercise27()
        {
            string repeat = "N";
            do
            {
                // clear console to accept new input value
                Console.Clear();
                Console.Write("Enter x: ");

                // accept input    
                double x = double.Parse(Console.ReadLine());

                // output results
                Console.WriteLine("E to the {0} is about : {1:N6}", x, CalcExp(x));
                                
                // output results
                Console.WriteLine("The library value is : {0:N6}", MathExp(x));
           
                // pause to allow repeat of exercise27
                Console.WriteLine("Repeat? y or n:");
                repeat = Console.ReadKey(false).KeyChar.ToString().ToUpper();         
            }            
            while (repeat == "Y");            
        }

        #endregion

        #region calculation methods
        /// <summary>
        /// calulate area
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns>Area</returns>
        private static double CalcArea(double radius)
        {        
            // math calulate for area
            double area = Math.PI * (Math.Pow(radius, 2));
            return area;
        }
        /// <summary>
        /// calculate circumference
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns>Circumference</returns>
        private static double CalcCircumference(double radius)
        {
            // math calulate for circumference
            double circumference = ((2 * Math.PI) * radius);
            return circumference;
        }
        /// <summary>
        /// calculate volume
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <param name="height">Height</param>
        /// <returns>Volume</returns>
        private static double CalcVolume(double radius, double height)
        {
            // math calulate for volume
            double volume = Math.PI * (Math.Pow(radius, 2) * height);
            return volume;
        }

        /// <summary>
        /// calculate investment defaulting variables V n r
        /// V = value of 400000
        /// n = years
        /// r = interest rate 
        /// </summary>
        /// <returns>Pay</returns>
        private static double CalcInvestment(double V = 400000, double n = 5, double r = .20)
        {                      
            // math calulate pay investment
            double investment = V / Math.Pow((double)(1 + r), (double)n);
            return investment;
        }

        /// <summary>
        /// calculate e^x using Math.Exp
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>MathExp Calculation</returns>
        private static double MathExp(double x)
        {            
            return Math.Exp(x);
        }

        /// <summary>
        /// calculate e^x using difference of successive terms
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>Results</returns>
        static double CalcExp(double x)
        {
            double position = 0, exFinal = 0; // current position, and last calculated value of e^x
            double ex = 1, cFactorial = 1; // current value the factorial, and current value of e^x

            while (!(ex == exFinal)) //continue until the difference less that 1.0
            {
                exFinal = ex;
                cFactorial *= x; //increase the power
                position += 1;
                cFactorial /= position; // increase the factorial
                ex += cFactorial; //add new successive term
            }
            return ex;
        }

        // This way of caclulating factorials is much more readable
        // https://gist.github.com/AndrewBarfield/2557117
        /// <summary>
        /// calculate e^x using difference of successive terms
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>Results</returns>
        static double CalcExpAB(double x)
        {
            // final answer
            double answer = 0;

            // previous answer and is used to stop
            double oldanswer = 0;

            // Sum index variable
            double n = 0;

            while (true)
            {
                answer += Math.Pow(x, n) / Factorial(n);

                if (answer == oldanswer)
                {
                    // Stop when the answer is less than 1.0
                    break;
                }
                else
                {
                    oldanswer = answer;
                    n++;
                }
            }

            // Return calculation
            return answer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Factorial(double x)
        {

            double answer = 1;
            double counter = 1;

            while (counter <= x)
            {
                Console.WriteLine("counter: {0} answer {1}", counter, answer);
                answer = answer * counter;
                counter++;

            }

            return answer;
        }


        #endregion
    }
}
