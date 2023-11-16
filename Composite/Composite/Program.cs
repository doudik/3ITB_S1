namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Cat cat = new Cat("Žofie");
            Cat cat2 = new Cat("Sheela");

            AnimalGroup catGroup = new AnimalGroup();
            AnimalGroup tigerGroup = new AnimalGroup();
            AnimalGroup allAnimals = new AnimalGroup();

            catGroup.RegisterAnimalToGroup(cat);
            catGroup.RegisterAnimalToGroup(cat2);
            tigerGroup.RegisterAnimalToGroup(tiger);

            allAnimals.RegisterAnimalToGroup(catGroup);
            allAnimals.RegisterAnimalToGroup(tigerGroup);

            allAnimals.MakeSound();


            foreach (var item in allAnimals.animals)
            {
                if(item.Equals(catGroup))
                {
                    Console.WriteLine("Cat group");
                    AnimalGroup tmp = (AnimalGroup)item;
                    foreach (var selectedCat in tmp.animals)
                    {
                        Console.WriteLine(((Cat)selectedCat).name);
                    }
                }
            }

        }
    }
}