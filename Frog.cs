using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceZoo
{
    class Frog : Animal
    {
        //Unique property set in Frog
        string FavouriteSpot { get; set; }

        //Constructor with defaults for frogs
        //inputtedName sent to parent, optional param
        public Frog(string inputtedName = "Kermit", string inputtedFavouriteSpot = "pond") : base(inputtedName)
        {
            Name = inputtedName;
            HasTail = false;
            WantsToPlayFetch = false;
            Sound = "Croak";
            FavouriteSpot = inputtedFavouriteSpot;
            Species = "Frog";
        }

        public void EnjoySpot()
        {
            Console.WriteLine($"The frog {Name} sits at it's favourite spot, the {FavouriteSpot}, it emitts a content {Sound}.");
        }
    }
}
