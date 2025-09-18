namespace InheritanceZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.MakeNoise();
            dog.CallGoodDog();

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
            
        }

    }
}
