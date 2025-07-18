namespace CrashCourse;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email {get; set;}
    public string Phone{get; set;}
    public int Age{get; set;}
    public License License { get; set; }
    public Vehicle Vehicle { get; set; }

    public Person(string firstName, string lastName, string email, string phone, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Age = age;
    }

    /*not really needed but incase I do need it*/
    public void setLicense(License license)
    {
        License = license;
    }

    public void setVehicle(Vehicle vehicle)
    {
        Vehicle = vehicle;
    }
}