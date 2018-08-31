using System;

namespace Week_2_Homework
{
    /// <summary>
    ///  CIS 466 : Advanced .Net Development with C#
    ///  Author: Justin Freres
    ///  Date: 8/30/2018
    ///  Week 2 Homework
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIS 466: Justin Freres Homework Week 1");
            string result;

            do
            {
                result = DisplayMenu();
                Program.Run(result);

            } while (result != "5");

            Console.WriteLine(" Good Bye...");
        }

        #region menu application

        /// <summary>
        /// Menu Code
        /// By: James Bateman
        /// </summary>
        /// <returns>Return Values</returns>
        public static string DisplayMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Homework 1");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run ConvertDegrees.");
            Console.WriteLine("Hit [2] to run ComputePolyOne.");
            Console.WriteLine("Hit [3] to run ComputePolyTwo.");
            Console.WriteLine("Hit [4] to run ConvertSeconds.");
            Console.WriteLine("");
            Console.WriteLine("Hit [5]: Exit;");
            Console.WriteLine("");
            Console.WriteLine("");

            string result = Console.ReadLine();

            return result;
        }

        /// <summary>
        /// Run Static Method
        /// By: James Bateman
        /// </summary>
        /// <param name="x">Input Arguments</param>
        /// <returns>Return Values</returns>
        private static bool Run(string x)
        {
            int input;
            switch (x)
            {

                case "1":
                    ConvertDegrees();
                    return true;

                case "2":
                    // accept input
                    Console.Write("Enter a value for x: ");                    
                    input = Convert.ToInt32(Console.ReadLine());
                    ComputePolyOne(input);
                    return true;

                case "3":
                    // accept input
                    Console.Write("Enter a value for x: ");
                    input = Convert.ToInt32(Console.ReadLine());                    
                    ComputePolyTwo(input);                  
                    return true;

                case "4":
                    ConvertSeconds();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        #endregion

        #region static methods
        /*  
         *  Write a static method to convert degrees Fahrenheit to degrees Celsius. 
         *  Input an integer Fahrenheit temperature and convert to an integer Celsius 
         *  using the formula Celsius = 5(Fahrenheit -32)/9. 
         *  Output the result and format the output to 2 decimal places (i.e. 5.55) 
         */

        /// <summary>
        /// static method to convert degrees Fahrenheit to degrees Celsius
        /// </summary>
        private static void ConvertDegrees()
        {
            
            // declare variables
            double fahrenheit;

            // accept input
            Console.Write("Enter a Fahrenheit temperature ");
            string input = Console.ReadLine();

            // parse input as double
            fahrenheit = double.Parse(input);            

            // convert input to celsuis
            var output = (5.0 * (fahrenheit - 32)) / 9;

            // output results
            Console.WriteLine("The temperature in Celsius is {0:F2} Degrees", output);

            // pause after output
            Console.WriteLine("Hit any key to continue..");
            Console.Read();
        }

        /*
         	Write a static method with one integer parameter, x , 
            that returns the value of the polynomial 3x2 – 7x + 2. 
            Call this method twice and each time reading the value of x 
            and displaying the result.
        */

        /// <summary>
        /// static method with one integer parameter
        /// </summary>
        /// <param name="x">returns the value of the polynomial</param>
        private static void ComputePolyOne(int x)
        {
            // declare variables 
            int answer;                        
        
            // calulate polynomial 3x^2 - 7x + 2            
            answer = (3 * Convert.ToInt32(Math.Pow(x, 2))) - (7 * x) + 2;

            // output results
            Console.WriteLine("The value of the polynomial is {0}", answer);

            // pause after output
            Console.WriteLine("Hit any key to continue..");
            Console.Read();

        }

        /*
            Write a static method with one integer parameter, x , 
            that returns the value of the polynomial 4x2  + 3x - 5. 
            Call this method three times and each time reading the value of x 
            and displaying the result.
        */
        /// <summary>
        /// static method with one integer parameter
        /// </summary>
        /// <param name="x">returns the value of the polynomial</param>
        private static void ComputePolyTwo(int x)
        {
            // declare variables 
            int answer;    

            // calulate polynomial 4x^2 + 3x - 5
            answer = (4 * Convert.ToInt32(Math.Pow(x, 2))) + (3 * x) - 5;           

            // output results
            Console.WriteLine(string.Format("The value of the polynomial is {0}", answer));

            // pause after output
            Console.WriteLine("Hit any key to continue..");
            Console.Read();
        }

        /*
         	Write a static method to convert an integer number of seconds 
            to an equivalent number of hours, minutes, and seconds. 
            For example, an input of 52,400 should give 14 hours, 33 minutes, and 20 seconds.
        */

        /// <summary>
        /// static method to convert an integer number 
        /// </summary>
        private static void ConvertSeconds()
        {
            // declare variables
            int input, hours, minutes, seconds;

            // accept input            
            Console.Write("Enter the number of seconds: ");
            input = Convert.ToInt32(Console.ReadLine());

            // convert input to hours
            hours = input / 3600;
            
            // convert input to minutes
            seconds = (input % 60);

            // convert input to seconds
            minutes = (input % 3600) / 60;

            // output results
            Console.WriteLine("{0} seconds converts to {1} hours {2} minutes {3} seconds", 
                input,
                hours,
                minutes,
                seconds);

            // pause after output
            Console.WriteLine("Hit any key to continue..");
            Console.Read();
        }
        #endregion
    }
}
