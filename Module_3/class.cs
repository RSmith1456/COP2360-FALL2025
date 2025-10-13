using System;

public class Octopus
{
    public string Name { get; set; }
    public int Age { get; set; }
    private bool isHealthy;
    public bool IsHealthy
    {
        get { return isHealthy; }
    }

    public Octopus(string name, int age, bool isHealthy)
    {
        this.Name = name;
        this.Age = age;
        this.isHealthy = isHealthy;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Octopus - Name: {this.Name}, Age: {this.Age}, Health Status: {this.IsHealthy}\n");
    }
}

public class Program
{
    public static void Main()
    {
        Octopus o1 = new Octopus("Jerry", 10, true);
        Console.WriteLine("Information about this organism:\n");
        o1.DisplayStatus();

        Console.WriteLine($"So far, {o1.Name} has been quite satisfied.");
    }
}