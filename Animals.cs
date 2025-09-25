using System;
using System.Data.Common;

//Base Class for Animals
public class Animal
{
    public bool HasTail { get; set; }
    public string Species { get; set; }
    public int AmountLegs { get; set; }
    public bool WantsToPlayFetch { get; set; }
    public string Sound { get; set; }
    public string Name { get; set; }

    //Base constructor with defaults, name required
    public Animal(string name)
    {
        HasTail = true;
        Species = "Animal";
        AmountLegs = 4;
        WantsToPlayFetch = true;
        Sound = "Noise";
        Name = name;
    }

    public void MakeNoise()
    {
        Console.WriteLine($"The {Species}, {Name}, goes {Sound}"); 
    }

    public void RunAround()
    {
        Console.WriteLine($"The {Species} runs around on its {AmountLegs} legs");
    }

    public void PlayFetch()
    {
        if (WantsToPlayFetch)
        {
            Console.WriteLine($"{Name}, the {Species}, seems excited to play fetch!"); 
        }
        else
        {
            Console.WriteLine($"{Name}, the {Species}, seems offended you'd even try to play fetch with it"); 
        }
    }
}
