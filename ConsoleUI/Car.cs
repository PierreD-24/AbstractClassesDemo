using System;
public class Car : Vehicle
{
    public bool HasTrunk {get; set;}

    public override void DriveAbstract()
    {
        Console.WriteLine("The car is driving.");
    }
}