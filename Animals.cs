using System;
using System.Data.Common;

public class Animal
{
    public bool hasTail;
    public string species;
    public int amountLegs;
    public bool wantsToPlayFetch;
    public string sound;
    public string name;

    public Animal()
    {
        hasTail = true;
        species = "Undefined Animal";
        amountLegs = 4;
        wantsToPlayFetch = true;
        sound = "woof";
        name = "";
    }

    public void MakeNoise()
    {
        Console.WriteLine($"The {species} goes {sound}"); 
    }

    public void RunAround()
    {
        Console.WriteLine($"The {species} runs around on its {amountLegs} legs");
    }

    public string PlayFetch()
    {
        if (wantsToPlayFetch)
        {
            return $"The {species} seems excited to play fetch!";
        }
        else
        {
            return $"The {species} seems offended you'd even try to play fetch with it";
        }
    }
}

class Dog : Animal
{
    public Dog()
    {
        name = "Lassie";
    }
}

class Frog : Animal
{

}

class Cat : Animal
{
    string happyNoise = "";

    public Cat()
    {
        happyNoise = "purr";
        sound = "Meow";
        species = "Cat";
    }
    
    
    public void MakeBiscuits()
    {
        Console.WriteLine($"The cat is so comfy it is making biscuits on the ground. It sounds like {happyNoise}{happyNoise}{happyNoise}");
    }
}

class MaineCoon : Cat
{
    int timeToGroom;
    bool feedingTime;

    public MaineCoon(string inputtedName = "Tortan", bool isFoodTime = false)
    {
        name = inputtedName;
        timeToGroom = 30;
        feedingTime = isFoodTime;
    }

    public void ShouldGroom()
    {
        if (feedingTime)
        {
            Console.WriteLine($"It usually takes {name} {timeToGroom} minutes to groom herself, however, look at the time... {sound}!! It is food time!");
        }
        else
        {
            Console.WriteLine($"{name} sits down for {timeToGroom} minutes and clean her fur.");
        }
    }
}

class DomesticShorthair : Cat
{
    string favouriteSnack;

    public DomesticShorthair(string inputtedName = "Lusse", string snack = "Cardboard")
    {
        name = inputtedName;
        favouriteSnack = snack;
    }

    public void EatThingHeShouldNot()
    {
        Console.WriteLine($"You are the best kitty, the cutest, most fantast- Have you been eating {favouriteSnack} again?!"); 
    }
}
