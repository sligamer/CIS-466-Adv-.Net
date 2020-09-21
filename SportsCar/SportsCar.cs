using System;

public class SportsCar : IDrivable
{
    public SportsCar() { }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating quickly");
    }

    public void Decelerate()
    {
        Console.WriteLine("Decelerating rapidly");
    }

    public void Start()
    {
        Console.WriteLine("Starting like a sports car");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping like a sports car");
    }

    public void Turn(string directions)
    {
        Console.WriteLine("Turning {0} like a sports car", directions);
    }
}

