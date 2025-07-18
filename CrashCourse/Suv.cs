namespace CrashCourse;

public class Suv : Vehicle
{
    public string Color { get; set; }
    public int NumberOfWheels { get; private set; }
    public int NumberOfSeats { get; private set; }
    public int NumberOfDoors { get; private set; }
    public bool Trailer { get; private set; }
    
    public Suv(string make, string model, int year, string color) : base(make, model, year)
    {
        Color = color;
        NumberOfWheels = 4;
        NumberOfSeats = 5;
        NumberOfDoors = 4;
    }
    
    /*method*/
    public void AddTrailer(bool trailer)
    {
        Trailer = trailer;
        if (Trailer)
        {
            NumberOfDoors++;
            NumberOfWheels += 2;
        }
    }

    public void RemoveTrailer(bool trailer)
    {
        Trailer = trailer;
        if (!Trailer)
        {
            NumberOfDoors--;
            NumberOfWheels -= 2;
        }
    }
}