using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class PenguinAnimals : AbstractAnimals
    {
        public PenguinAnimals(string name, int age) : base(name, age)
        {
            FoodVariants = new List<FoodList>()
            {
                FoodList.Fish
            };
            Biom = Options.BiomVariants.Taiga;
            RequiredArea = 15;
            EmittedSound = "Piu-piu-piu";
            IsPredator = true;
            Species = "Penguin";
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} dancing");
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
