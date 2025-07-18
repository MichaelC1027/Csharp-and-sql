using System.Runtime.Intrinsics.X86;

namespace CrashCourse;

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    protected Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

public class Sedan : Vehicle
{
    public string Color { get; set; }
    public int NumberOfWheels { get; private set; }
    public int NumberOfSeats { get; private set; }
    public int NumberOfDoors { get; private set; }
    
    public bool Convertible { get; private set; }

    public Sedan(string make, string model, int year, string color) : base(make, model, year)
    {
        Color = color;
        NumberOfWheels = 4;
        NumberOfSeats = 5;
        NumberOfDoors = 4;
    }
    
    public void isConvertible(bool convertible)
    {
        Convertible = convertible;
        if (Convertible)
        {
            NumberOfDoors = 2;
            NumberOfSeats = 4;
        }
        else
        {
            NumberOfDoors = 4;
            NumberOfSeats = 5;
        }
    }
}

public class Motorcycle : Vehicle
{
    public string Color { get; set; }
    public int NumberOfWheels { get; private set; }
    public int NumberOfSeats { get; private set; }
    public int NumberOfDoors { get; private set; }
    public bool Pillion { get; private set; }
    
    public Motorcycle(string make, string model, int year, string color) : base(make, model, year)
    {
        Color = color;
        NumberOfSeats = 2;
        NumberOfDoors = 0;
        NumberOfWheels = 2;
    }
    
    /*method*/
    public void addPillion(bool pillion)
    {
        Pillion = pillion;
        if (Pillion)
        {
            NumberOfWheels++;
            NumberOfSeats++;
        }
    }

    public void removePillon(bool pillion)
    {
        Pillion = pillion;
        if (!Pillion)
        {
            NumberOfWheels--;
            NumberOfSeats--;
        }
    }
}
