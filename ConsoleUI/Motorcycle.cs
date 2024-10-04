using System;
public class Motorcycle : Vehicle
{
    public bool hasSideCar {get; set;}

    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is driving.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Yes the motorcycle can drive.");
    }
}