using System;
public interface IDrivable
{
    void Start();
    void Stop();
    void Accelerate();
    void Decelerate();
    void Turn(String directions);
}
