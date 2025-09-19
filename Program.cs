namespace InheritanceZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates an object from the Dog child of Animal and calls method for
            //making noise, playing fetch and dog specific calling the doog a good dog
            var dog = new Dog();
            dog.MakeNoise();
            dog.PlayFetch();
            dog.CallGoodDog();
            dog.CallGoodDog();

            //Creates an object from the Frog child of Animal, calling methods for
            //making noise, playing fetch and enjoying the spot
            var frog = new Frog();
            frog.MakeNoise();
            frog.PlayFetch();
            frog.EnjoySpot();

            //Creates an object from the Cat child of Animal, calling methods for
            //making noise, running around, and making biscuits
            var cat = new Cat();
            cat.MakeNoise();
            cat.RunAround();
            cat.MakeBiscuits();

            //Creates an object from the DomesticShorthair, based on Cat, based on Animal,
            //Calls methods for making noise, and eating things he shouldn't
            var lusse = new DomesticShorthair();
            lusse.MakeNoise();
            lusse.EatThingHeShouldNot();

            //Creates an object from the MaineCoon, based on Cat, based on Animal,
            //Calls methods for making noise, and should groom
            var tortan = new MaineCoon("Tortan", true);
            tortan.MakeNoise();
            tortan.ShouldGroom();
            
        }

    }
}
