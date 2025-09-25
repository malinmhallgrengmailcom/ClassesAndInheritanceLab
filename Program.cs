namespace InheritanceZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sets up objects for all classes
            //Three objects are created for different cat subclasses

            var dog = new Dog("Fido");
            dog.MakeNoise();
            dog.CallGoodDog();
            dog.PlayFetch();

            var frog = new Frog();
            frog.MakeNoise();
            frog.EnjoySpot();

            var cat = new Cat();
            cat.MakeNoise();
            cat.MakeBiscuits();

            var lusse = new DomesticShorthair();
            lusse.MakeNoise();
            lusse.EatThingHeShouldNot();
            

            var tortan = new MaineCoon("Tortan", true);
            tortan.MakeNoise();
            tortan.ShouldGroom();
            tortan.PlayFetch();
            
        }

    }
}
