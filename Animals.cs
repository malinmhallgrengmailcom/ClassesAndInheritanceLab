using System;
using System.Data.Common;

<<<<<<< HEAD
//Base Class for Animals
=======

>>>>>>> e40b78dce968dddfdbc9a333be10bbd00e47b5f4
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
<<<<<<< HEAD
            Console.WriteLine($"{Name}, the {Species}, seems excited to play fetch!"); 
        }
        else
        {
            Console.WriteLine($"{Name}, the {Species}, seems offended you'd even try to play fetch with it"); 
        }
    }
}
=======
            Console.WriteLine($"The {species} seems excited to play fetch!"); 
        }
        else
        {
            Console.WriteLine($"The {species} seems offended you'd even try to play fetch with it"); 
        }
    }
}


//Defines Dog child with unique constructor and methods
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

//Defines Frog child with unique constructor and method
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

//Defines Cat child with unique constructor and method
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

//Defines MaineCoon, a sub-child of Cat and defines unique constructor and methods
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

//Defines DomessticShorthair, a sub-child of Cat and defines unique constructor and methods
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
>>>>>>> e40b78dce968dddfdbc9a333be10bbd00e47b5f4
