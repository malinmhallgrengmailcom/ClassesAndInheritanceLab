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
    int calledGoodDog;
    public Dog(string inputtedName = "Lassie")
    {
        name = inputtedName;
        calledGoodDog = 0;
        species = "Dog";
    }

    public void CallGoodDog()
    {
        calledGoodDog++;
        Console.WriteLine($"{name} has been called a Good Dog {calledGoodDog} time! Their tail is wagging and they let out a content {sound}");
    }
}

class Frog : Animal
{
    string favouriteSpot;
    public Frog(string inputtedName = "Kermit", string inputtedFavouriteSpot = "pond")
    {
        name = inputtedName;
        hasTail = false;
        wantsToPlayFetch = false;
        sound = "Croak";
        favouriteSpot = inputtedFavouriteSpot;
        species = "Frog";
    }

    public void EnjoySpot()
    {
        Console.WriteLine($"The frog {name} sits at it's favourite spot, the {favouriteSpot}, it emitts a content {sound}.");
    }
}

class Cat : Animal
{
    string happyNoise = "";

    public Cat(string inputtedName = "Gustaf")
    {
        name = inputtedName;
        happyNoise = "purr";
        sound = "Meow";
        species = "Cat";
    }
    
    
    public void MakeBiscuits()
    {
        Console.WriteLine($"{name} the cat is so comfy it is making biscuits on the ground. It sounds like {happyNoise}{happyNoise}{happyNoise}");
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
        Console.WriteLine($"You are the best kitty, the cutest, most fantast- But {name}! Have you been eating {favouriteSnack} again?!"); 
    }
}
