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

        public string Species { get; protected set; } //разновидность животных

        public BiomVariants Biom { get; protected set; }//Необходимый биом (В options создаем переменную enum и расписываем перечень biom ов)

        public int RequiredArea { get; protected set; } //Необходимая площадь на особь

        public List<FoodList> FoodVariants { get; protected set; } //Чем питается

        public bool IsPredator { get; protected set; } //отряд хищник или травоядное

        public string EmittedSound { get; protected set; } //Издаваемый звук

        public AbstractAnimals(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DoSound() //Все должны издать звук
        {
            Console.WriteLine($"{Name} makes a sound like {EmittedSound}");
        }
        

        public abstract void DoPlay(); //должны поиграть (в каждом наследнике нужно сделать override)

        public virtual void DoEat(string food, int kg) //по сценарию кушают
        {
            if (food.Contains(food))
            {
                Console.WriteLine($"{Name} was eat {kg} kg/gr {food}");
            }
            else 
            {
                Console.WriteLine($"{Name} doesn't eat {food}");
            }
        }
    }
}
