using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo
{
    public class Voliers
    {   //Из чего состоит вольер
        //Примечание. Вольер создаю с расчетом того, что изначально в нём живут животные одного и того же вида
        public string Name { get; protected set; } // 1) Имя
        public string DeleteName { get; set; }
        public List<FoodList> FoodVariants { get; protected set; } //Чем питается
        public BiomVariants Biom { get; protected set; } // 2) Биом
        public int Square { get; protected set; } // 3) Площадь вольера
        public string Species { get; protected set; } //Разновидность животных
        public Dictionary<string, int> LeftFood { get; protected set; }
        public List<AbstractAnimals> Animals { get; protected set; } // создан не список, а переменная для его хранения
        //коммент к строчке 12 - модификатор protected, так как лист мы можем читать только в наследниках. 

        public Voliers(string name, BiomVariants biom, int square, string species) //задаём конструктор
        {
            Name = name;
            Biom = biom;
            Square = square;
            Species = species;
            Animals = new List<AbstractAnimals>(); //!!!создание объекта
            //коммент к 20 строчке - возможно, чтобы задать какое животное(-ые) там уже живёт(-ут)
        }

        //Поселенец
        public string PoselilsaIliNet(AbstractAnimals animal)
        {
            Animals.Add(animal);
            return $"В вольер {Name} поселился {animal.Species} {animal.Name}";
        }


        //Расписываем функционал
        //Удаление животного из вольера
        public string DeleteAnimal(string DeleteName, string species) //Задаем имя животного, которое нужно выселить и его вид
        {
            foreach (AbstractAnimals animal in Animals)
            {
                if (species == animal.Species && DeleteName == animal.Name) //перебираем цикл до тех пор, пока не найдём нужное имя и вид
                {
                    Animals.Remove(animal);
                }
            }
            return $"Из вольера {Name} выселили {species} {DeleteName}";
        }

        //Узнать сколько и какой еды осталось в кормушках
       
        public string FindHowMuchAndWhatKindOfFoodLeftInFeeder(FoodList name, int givenFood, int eatenFood)
        { 
            int amount = givenFood - eatenFood;
            return $"В кормушке для {name} осталось {amount} кг {name}";
        }

        //Может содержать в себе различные типы животных

        public string IsItPossibleToPlaceTheseAnimals(AbstractAnimals animals)
        {
            foreach (AbstractAnimals a in Animals)
            {
                if (!a.IsPredator);
            }
            return $"{animals.Species} {animals.Name} может жить с остальными животными в этом вольере";
        }
    }
}
