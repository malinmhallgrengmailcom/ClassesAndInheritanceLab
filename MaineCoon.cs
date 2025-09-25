using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceZoo
{
    public class MaineCoon : Cat
    {

        int TimeToGroom { get; set; }
        bool FeedingTime { get; set; }

        //Constructor for Main Coons
        //sends inputtedName to parent, Cat, optional param
        public MaineCoon(string inputtedName = "Tortan", bool isFoodTime = false) : base(inputtedName)
        {
            Name = inputtedName;
            TimeToGroom = 30;
            FeedingTime = isFoodTime;
        }

        public void ShouldGroom()
        {
            if (FeedingTime)
            {
                Console.WriteLine($"It usually takes {Name} {TimeToGroom} minutes to groom herself, however, look at the time... {Sound}!! It is food time!");
            }
            else
            {
                Console.WriteLine($"{Name} sits down for {TimeToGroom} minutes and clean her fur.");
            }
        }
    }
}
