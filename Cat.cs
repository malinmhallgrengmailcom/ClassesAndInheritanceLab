using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceZoo
{
    public class Cat : Animal
    {
        //Unique Property set for Cats
        string HappyNoise { get; set; }

        //Constructor with defaults for cats
        //inputtedName sent to parent, optional param
        public Cat(string inputtedName = "Gustaf") : base(inputtedName)
        {
            Name = inputtedName;
            WantsToPlayFetch = false;
            HappyNoise = "purr";
            Sound = "Meow";
            Species = "Cat";
        }


        public void MakeBiscuits()
        {
            Console.WriteLine($"{Name} the cat is so comfy it is making biscuits on the ground. It sounds like {HappyNoise}{HappyNoise}{HappyNoise}");
        }
    }
}
