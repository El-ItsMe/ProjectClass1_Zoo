using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo.Animals
{
    public class BearAnimals: AbstractAnimals
    {
        public BearAnimals(string name, int age): base(name, age)
        {
            FoodVariants = new List<FoodList>()
            {
                FoodList.Bamboo
            };
            Biom = Options.BiomVariants.Tropics;
            RequiredArea =  30;
            EmittedSound = "Grrrrr-Grrrr";
            IsPredator = true;
            Species = "Bear";
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }
        
        public override void DoPlay()
        {
            Console.WriteLine($"{Name} eating bamboo");
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