using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;


BearAnimals panda = new BearAnimals("Pou", 6);
panda.DoEat("bamboo", 30);
panda.DoPlay();

PenguinAnimals firstPenguin = new PenguinAnimals ("Kovalski", 6);
firstPenguin.DoEat("Fish", 6);
firstPenguin.DoPlay();

Voliers volier = new Voliers("для мишек", BiomVariants.Tundra, 250, "Bear");
BearAnimals bear = new BearAnimals("Pou", 1);

Console.WriteLine(volier.AddAnimal(bear)); //!!!Вопрос. Поясните что происходит внутри скобки
Console.WriteLine(volier.DeleteAnimal("Pou", "Bear"));
