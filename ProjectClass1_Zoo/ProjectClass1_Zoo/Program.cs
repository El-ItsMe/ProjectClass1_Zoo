using ProjectClass1_Zoo;
using System;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;


//BearAnimals panda = new BearAnimals("Pou", 6);
//panda.DoEat("bamboo", 30);
//panda.DoPlay();

//PenguinAnimals firstPenguin = new PenguinAnimals ("Kovalski", 6);
//firstPenguin.DoEat("Fish", 6);
//firstPenguin.DoPlay();

//Voliers volier = new Voliers("для мишек", BiomVariants.Tundra, 250, "Bear");
//BearAnimals bear = new BearAnimals("Pou", 1);

//Console.WriteLine(volier.AddAnimal(bear)); //!!!Вопрос. Поясните что происходит внутри скобки
//Console.WriteLine(volier.DeleteAnimal("Pou", "Bear"));

//List<string> voliersname = new List<string>();
//voliersname.Add("Volier dlya medveda");
//voliersname.Add("Volier dlya lowadi");
//voliersname.Add("Volier dlya RIsi");
//voliersname.Add("Volier dlya Pengvina");
//voliersname.Add("Volier dlya zaycev");
//Dictionary<string, int> skolkoIkakoyediostalos = new Dictionary<string, int>();

//skolkoIkakoyediostalos.Add("Volier dlya medveda", 12);
//skolkoIkakoyediostalos.Add("Volier dlya lowadi", 10);
//skolkoIkakoyediostalos.Add("Volier dlya RIsi", 9);
//skolkoIkakoyediostalos.Add("Volier dlya Pengvina", 3);
//skolkoIkakoyediostalos.Add("Volier dlya zaycev", 1);
//Console.WriteLine(skolkoIkakoyediostalos["Volier dlya medveda"]);

//Voliers volier = new Voliers("для мишек", BiomVariants.Tundra, 250, "Bear");
//Console.WriteLine(volier.GetKakoyISkoloEdiOstalos(80, 50));

Voliers volier = new Voliers("Для пингвинов", BiomVariants.Taiga, 250, "Penguin");
PenguinAnimals penguin = new PenguinAnimals("Denki", 3);
Console.WriteLine(volier.PoselilsaIliNet(penguin));
//HorseAnimals horse1 = new HorseAnimals("Bingo", 10);
//Console.WriteLine(volier.NasipaemEdu());
Console.WriteLine();
Voliers volier1 = new Voliers("Вольер для травоядных", BiomVariants.Tropics, 300,"Horse");
Console.WriteLine(volier1.FindHowMuchAndWhatKindOfFoodLeftInFeeder(FoodList.Oats, 80, 50));
PenguinAnimals penguin2 = new PenguinAnimals("Kovalski", 3);
Console.WriteLine(volier1.IsItPossibleToPlaceTheseAnimals(penguin2));
