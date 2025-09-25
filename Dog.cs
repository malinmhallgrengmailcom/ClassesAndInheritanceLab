using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceZoo
{
    public class Dog : Animal
    {
        //Unique property set for Dogs
        int CalledGoodDog { get; set; }

        //Constructor with defaults for dogs
        //inputtedName sent to parent, optional param
        public Dog(string inputtedName = "Lassie") : base(inputtedName)
        {
            Name = inputtedName;
            CalledGoodDog = 0;
            Species = "Dog";
            Sound = "Woof";
        }

        public void CallGoodDog()
        {
            CalledGoodDog++;
            Console.WriteLine($"{Name} has been called a Good Dog {CalledGoodDog} time! Their tail is wagging and they let out a content {Sound}");
        }
    }
}
