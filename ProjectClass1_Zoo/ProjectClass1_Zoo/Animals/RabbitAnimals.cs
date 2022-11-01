using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class Rabbit : AbstractAnimals
    {
        public Rabbit(string name, int age) : base(name, age)
        {
            food = Options.FoodList.Mushrooms;
            food = Options.FoodList.Oats;
            Biom = Options.BiomVariants.Steppes;
            NameOfAnimalSpecies = "Rabbit";
            RequiredArea = 8;
            EmittedSound = "grrrrr-grrrrr";
            IsPredator = false;
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} jumping and running");
        }

        public virtual void DoEat(string food, int kg)
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
