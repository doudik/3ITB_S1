using Composite2;

class Program {
    static void Main(string[] args) { 
        
        //Vytvořit instanci objektu
        Elephant elephant = new Elephant();
        Giraffe giraffe = new Giraffe();

        //vytvořit instanci objektu animalgroup
        AnimalGroup elephantGroup = new AnimalGroup();
        AnimalGroup giraffeGroup = new AnimalGroup();
        AnimalGroup allAnimals = new AnimalGroup();

        //přidat objekty do group
        elephantGroup.Add(elephant);
        giraffeGroup.Add(giraffe);

        //přidám groupy do allAnimals
        allAnimals.Add(giraffe);
        allAnimals.Add(elephant);

        allAnimals.Output();
    }
}