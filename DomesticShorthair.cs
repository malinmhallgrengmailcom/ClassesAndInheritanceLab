using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceZoo
{
    public class DomesticShorthair : Cat
    {
        //Unique property set for Domestic shorthairs
        string FavouriteSnack { get; set; }

        //Constructor with defaults for domestic shorthairs
        //inputtedName sent to parent, Cat, optional param
        public DomesticShorthair(string inputtedName = "Lusse", string snack = "Cardboard") : base(inputtedName)
        {
            Name = inputtedName;
            FavouriteSnack = snack;
        }

        public void EatThingHeShouldNot()
        {
            Console.WriteLine($"You are the best kitty, the cutest, most fantast- But {Name}! Have you been eating {FavouriteSnack} again?!");
        }
    }
}
