using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Car object
        Car car1 = new Car();

        // Assign model and make to the car object
        car1.Model = "Toyota Camry";
        car1.Make = "Toyota";

        // Display the model and make of the car
        Console.WriteLine("Car 1 - Model: " + car1.Model + ", Make: " + car1.Make);

        // Create another Car object
        Car car2 = new Car();

        // Assign a different model and make to the second car object
        car2.Model = "Honda Accord";
        car2.Make = "Honda";

        // Display the model and make of the second car
        Console.WriteLine("Car 2 - Model: " + car2.Model + ", Make: " + car2.Make);
    }
}
