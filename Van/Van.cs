using System;

public class Van : IDrivable
    {
        public Van() { }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating cautiously");
        }

        public void Decelerate()
        {
            Console.WriteLine("Decelerating gradually");
        }

        public void Start()
        {
            Console.WriteLine("Starting like a van");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping like a van");
        }

        public void Turn(string directions)
        {
            Console.WriteLine("Turning {0} like a van", directions);
        }
    }

