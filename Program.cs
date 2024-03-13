using System;

// Define a class called Person with two properties: FirstName and LastName
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Define a method called SayName that writes the person's full name to the console
    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.ReadLine();
    }
}

// Define a class called Employee that inherits from the Person class
public class Employee : Person
{
    // Add a property called Id of type int
    public int Id { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student"
        Employee employee = new Employee
        {
            FirstName = "Andrew",
            LastName = "Campbell"
        };

        // Call the superclass method SayName() on the Employee object
        employee.SayName();

        // Keep the console window open
        Console.ReadLine();
    }
}

