namespace InheritanceZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();

            cat.MakeNoise();

            var lusse = new DomesticShorthair();
            lusse.EatThingHeShouldNot();
            lusse.MakeNoise();

            var tortan = new MaineCoon(true);
            tortan.MakeBiscuits();
            tortan.MakeNoise();
        }

    }
}
