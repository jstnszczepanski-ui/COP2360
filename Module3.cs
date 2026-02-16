using System;

class Program
{
    static void Main()
    {
        Octopus o = new Octopus();
        o.Name = "Jack";
        o.Age = 5;

        Console.WriteLine("Name: " + o.Name);
        Console.WriteLine("Age: " + o.Age);
        Console.WriteLine("Legs: " + Octopus.Legs);
        Console.WriteLine("Eyes: " + Octopus.Eyes);
    }
}

class Octopus
{
    public string Name;
    public int Age;

    public static readonly int Legs = 8;
    public static readonly int Eyes = 2;
}