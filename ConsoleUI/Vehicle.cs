using System;
public abstract class Vehicle
{
    public string Year {get; set;} = "Default";
    public string Make {get; set;}  = "Default";
    public string Model {get; set;} = "Default";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Yes");
    }
}