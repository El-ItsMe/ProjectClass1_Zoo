using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public abstract class AbstractAnimals
    {
        public string Name { get; set; }
        public string GetName()
        {
            return Name;
        }
        public void SetName()
        {
            if (Name=="")
            {
                throw new ArgumentException();
            }
        }

        public int Age { get; set; }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge()
        {
            if (Age < 0)
            {
                throw new ArgumentException("Given Age < 0");
            }
        }

        public string NameOfAnimalSpecies { get; protected set; } //Название вида 

        public BiomVariants Biom { get; protected set; }//Необходимый биом

        public string RequiredArea { get; protected set; } //Необходимая площадь на особь

        public FoodList food { get; set; } //Чем питается

        public bool IsPredator { get; protected set; } //отряд хищник или травоядное

        public string EmittedSound { get; protected set; } //Издаваемый звук

        public AbstractAnimals(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void DoSound();
        

        public abstract void DoPlay();

        public void DoEat(string food, int kg)
        {
            if (food.Contains(food))
            {
                Console.WriteLine($"{Name} was eat {kg} kg {food}");
            }
        }
    }
}
