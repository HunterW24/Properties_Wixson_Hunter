using System;

// Define a class called Car
public class Car
{
    // Private field to store the model of the car
    private string model;

    // Public property 'Model' with a getter and setter
    public string Model
    {
        // Getter to retrieve the value of the model
        get { return model; }
        // Setter to assign a new value to the model
        set { model = value; }
    }

    // Automatic property for the 'Make' of the car
    public string Make { get; set; }
}
