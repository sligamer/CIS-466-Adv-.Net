using System;

namespace Week_4_Homework
{
    /// <summary>
    ///  CIS 466 : Advanced .Net Development with C#
    ///  Author: Justin Freres
    ///  Date: 9/15/2018
    ///  Week 4 Homework 3
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIS 466: Justin Freres Homework Week 3");
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
        /// Modified by: Justin Freres
        /// </summary>
        /// <returns>Return Values</returns>
        public static string DisplayMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Homework 3");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run Debug Exercise.");
            Console.WriteLine("Hit [2] to run Exercise 5_15.");
            Console.WriteLine("Hit [3] to run Exercise 5_16.");
            Console.WriteLine("Hit [4] to run Exercise 5_21.");
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
        /// Modified by: Justin Freres
        /// </summary>
        /// <param name="x">Input Arguments</param>
        /// <returns>Return Values</returns>
        private static bool Run(string x)
        {
            switch (x)
            {

                case "1":
                    Test.DoDebugTest();
                    return true;

                case "2":
                    Exercise_5_14();
                    return true;

                case "3":
                    Exercise_5_16();
                    return true;

                case "4":
                    Exercise_5_21();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        /*
         * Write a class for soccer game scoring. Provide a constructor that starts each team with
         * a score of zero. Include instance variables to keep the score for both teams. Include a
         * method to add 1 to the score of the first team and a method to add 1 to the score of the
         * second team. Include a method that displays the score of both teams, and the Main 
         * method to test, creating two different soccer games. Score points so the first game is 3-2 
         * and the second game is 0-1. Display the scores of each game.
         */
        private static void Exercise_5_14()
        {
            // Game 1      
            SoccerGame gameOne = new SoccerGame();
            // team , score
            gameOne.AddScore(1, 1);
            gameOne.AddScore(1, 1);
            gameOne.AddScore(1, 1);
            gameOne.AddScore(2, 1);
            gameOne.AddScore(2, 1);
            gameOne.DisplayScore();


            // Game 2           
            SoccerGame gameTwo = new SoccerGame();
            // team , score
            gameTwo.AddScore(1, 0);
            gameTwo.AddScore(2, 1);
            gameTwo.DisplayScore();

            // pause after output
            Console.Read();
            Console.Clear();

        }

        /*
         * Write a class for a warehouse that hold radios, televisions, and computers. Provide a 
         * constructor that starts a warehouse with no items. Include instance vairables to store the
         * quantity of each item in the warehouse. Include methods to add to the stock of each
         * item, and a method to display the contents of the warehouse. Test in a Main method, creating
         * two warhouses. Add items to each and display the final contents of each warehouse.
         */
        private static void Exercise_5_16()
        {
            Warehouse warehouse1 = new Warehouse();
            Warehouse warehouse2 = new Warehouse();
            warehouse1.AddRadio(5);
            warehouse1.AddTV(6);
            warehouse1.AddComputer(3);
            warehouse1.AddRadio(4);
            warehouse2.AddComputer(7);
            warehouse2.AddRadio(3);
            Console.WriteLine("Warehouse 1 contents:");
            warehouse1.Display();
            Console.WriteLine("Warehouse 2 contents:");
            warehouse2.Display();

            Console.ReadLine();
            Console.Clear();

        }

        /*
         * For the Warehouse class of Exercise 16, add methods to remove a specified quantity
         * of each item. If the quanity specified is greater than the amount of that item in the wareouse,
         * then no items are removed.  Add tests of the remove methods to the Main method.
         */
        private static void Exercise_5_21()
        {
            Warehouse warehouse1 = new Warehouse();
            Warehouse warehouse2 = new Warehouse(12, 45, 67);

            warehouse1.AddRadio(5);
            warehouse1.AddTV(6);
            warehouse1.AddComputer(3);
            warehouse1.AddRadio(4);
            warehouse2.AddComputer(7);
            warehouse2.AddRadio(3);
            warehouse2.RemoveRadio(7);
            warehouse2.RemoveTV(7);
            warehouse2.RemoveComputer(7);
            Console.WriteLine("Warehouse 1 contents:");
            warehouse1.Display();
            Console.WriteLine("Warehouse 2 contents:");
            warehouse2.Display();
            Console.ReadLine();
            Console.Clear();

        }

        #endregion
    }
 
    /// <summary>
    /// Test Class for Exercise #8
    /// </summary>
    public class Test
    {
        // declare variables
        private static int tally;

        // constructor not a void
        // public void Test(int start)
        public Test(int start)
        {
            tally = start;
        }

        // method ok
        public void AddFive()
        {
            tally += 5;
        }

        // changed to static void
        // private void Display()
        private static void Display()
        {
            Console.WriteLine("the tally is {0}", tally);
        }

        // rename to DoDebugTest
        // change to void due to no return 
        // public static Main()
        public static void DoDebugTest()
        {
            Test myTest = new Test(3);
            myTest.AddFive();
            Display();

            // pause after output
            Console.Read();
            Console.Clear();
        }
    }

    /// <summary>
    /// Class for Exercise 14 SoccerGame
    /// </summary>
    public class SoccerGame
    {      
        private int teamOne;
        public int TeamOne
        {
            get { return teamOne; }
            set { teamOne = value; }
        }
        private int teamTwo;
        public int TeamTwo
        {
            get { return teamTwo; }
            set { teamTwo = value; }
        }        
        private int teamOneScore { get; set; }
        private int teamTwoScore { get; set; }
        private static int gameCount { get; set; }
        

        public SoccerGame()
        {
            teamOne = 1;
            teamTwo = 2;
            teamOneScore = 0;
            teamTwoScore = 0;
            gameCount++;
        }

        public void AddScore(int team, int addScore)
        {
            if(TeamOne == team)
                teamOneScore += addScore;
            if(TeamTwo == team)
                teamTwoScore += addScore;       
        }

        public void DisplayScore()
        {
            Console.WriteLine("The score of game {0} is:", GameCount());
            Console.WriteLine("\t Team {0} is {1}", TeamOne, teamOneScore);
            Console.WriteLine("\t Team {0} is {1}", TeamTwo, teamTwoScore);                      
        }

        public static int GameCount()
        {
            return gameCount;
        }
    }

    /// <summary>
    /// Class for Exercise's 16 & 21
    /// </summary>
    public class Warehouse
    {
        private int radios;
        public int Radios
        {
            get { return radios; }
            set { radios = value; }
        }

        private int tvs;
        public int TVS
        {
            get { return tvs; }
            set { tvs = value; }
        }

        private int computers;
        public int Computers
        {
            get { return computers; }
            set { computers = value; }
        }
                
        public Warehouse(int radios, int tvs, int computers)
        {
            Radios = radios;
            TVS = tvs;
            Computers = computers;
        }

        public Warehouse()
        {
        }

        internal void AddComputer(int v)
        {
            Computers += v;
        }

        internal void AddRadio(int v)
        {
            Radios += v;
        }

        internal void AddTV(int v)
        {
            TVS += v;
        }

        internal void Display()
        {
            Console.WriteLine("\t The number of radios is {0} ", Radios);
            Console.WriteLine("\t The number of tv's is {0} ", TVS);
            Console.WriteLine("\t The number of computers is {0} ", Computers);
        }

        internal void RemoveRadio(int v)
        {
            if(v < Radios)
                Radios -= v;
        }

        internal void RemoveTV(int v)
        {
            if(v < TVS)
                TVS -= v;
        }

        internal void RemoveComputer(int v)
        {
            if(v < Computers)
                Computers -= v;
        }
    }

}
