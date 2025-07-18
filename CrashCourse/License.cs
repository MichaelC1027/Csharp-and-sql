namespace CrashCourse;

public class License
{
    public int LicenseNumber { get; set; }
    public string LicenseType { get; set; }
    public string Gender { get; set; }

    public License(int licenseNumber, string licenseType, string gender)
    {
        LicenseNumber = licenseNumber;
        LicenseType = licenseType;
        Gender = gender;
    }
}