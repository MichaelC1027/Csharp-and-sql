using CrashCourse;

    /* creating and setting up people objects */
    Person p1 = new Person("Mike", "Castillo", "Macastillo1027@gmail.com", "9172837546", 30);
    Person p2 = new Person("Jane", "Doe", "JaneDoe@gmail.com", "(098) 765-4321", 25);
    Person p3 = new Person("John", "Doe", "JohnDoe@gmail.com", "123-456-7890", 20);
    
    /* giving licenses to 2 of the people objects) */
    p1.setLicense(new License(123456789, "D", "Male"));
    p2.License = new License(987654321, "C", "Female");
    
    /* giving vehicles to 3 of the people objects */
    p1.setVehicle(new Suv("Jeep", "Cherokee", 2020, "Black"));
    p2.setVehicle(new Sedan("Honda", "Accord", 2010, "White")); 
    p3.Vehicle = new Motorcycle("Honda", "CBR300", 2018, "Red");
    
    /*adding more vehicles for testing reasons*/
    Sedan s = p2.Vehicle as Sedan;
    Suv su = p1.Vehicle as Suv;
    Motorcycle m = p3.Vehicle as Motorcycle;
    
    /* testing methods */
    /*testing motorcycle methods*/
    Console.WriteLine("Default Settings:\nPillion attached: "+ m.Pillion + "\nNumber of Wheels: " + m.NumberOfWheels + "\nNumber Of Seats: " + m.NumberOfSeats + "\nNumber of Doors: " + m.NumberOfDoors);
    Console.WriteLine();
    m.addPillion(true);
    Console.WriteLine("Pillion attached: "+ m.Pillion + "\nNumber of Wheels: " + m.NumberOfWheels + "\nNumber Of Seats: " + m.NumberOfSeats);
    Console.WriteLine();
    m.removePillon(false);
    Console.WriteLine("Pillion attached: "+ m.Pillion + "\nNumber of Wheels: " + m.NumberOfWheels + "\nNumber Of Seats: " + m.NumberOfSeats);
    Console.WriteLine();
    
    /*testing Sedan methods*/
    Console.WriteLine("Default Settings:\nIs Convertible: " + s.Convertible + "\nNumber of Doors: " + s.NumberOfDoors + "\nNumber of Wheels: " + s.NumberOfWheels + "\nNumber of Seats: " + s.NumberOfSeats);
    Console.WriteLine();
    s.isConvertible(true);
    Console.WriteLine("Is Convertible: " + s.Convertible + "\nNumber of Doors: " + s.NumberOfDoors + "\nNumber of Wheels: " + s.NumberOfWheels + "\nNumber of Seats: " + s.NumberOfSeats);
    Console.WriteLine();
    s.isConvertible(false);
    Console.WriteLine("Is Convertible: " + s.Convertible + "\nNumber of Doors: " + s.NumberOfDoors + "\nNumber of Wheels: " + s.NumberOfWheels + "\nNumber of Seats: " + s.NumberOfSeats);
    Console.WriteLine();
    
    /*testing SUV methods*/
    Console.WriteLine("Default Settings:\nTrailer attached: "+ su.Trailer +"\nNumber of Doors: " + su.NumberOfDoors + "\nNumber of Wheels: " + su.NumberOfWheels + "\nNumber of Seats: " + su.NumberOfSeats);
    Console.WriteLine();
    su.AddTrailer(true);
    Console.WriteLine("Trailer attached: "+ su.Trailer +"\nNumber of Doors: " + su.NumberOfDoors + "\nNumber of Wheels: " + su.NumberOfWheels + "\nNumber of Seats: " + su.NumberOfSeats);
    Console.WriteLine();
    su.RemoveTrailer(false);
    Console.WriteLine("Trailer attached: "+ su.Trailer +"\nNumber of Doors: " + su.NumberOfDoors + "\nNumber of Wheels: " + su.NumberOfWheels + "\nNumber of Seats: " + su.NumberOfSeats);
    Console.WriteLine();
    
    /* printing out the information of the people objects */
    Console.WriteLine(p2.License.LicenseNumber);
    Console.WriteLine(p3.Vehicle);
    