using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class LynxAnimals : AbstractAnimals
    {
        public LynxAnimals(string name, int age) : base(name, age)
        {
            FoodVariants = new List<FoodList>()
            {
                FoodList.Meat
            };
            Biom = Options.BiomVariants.Сoniferous_forests;
            RequiredArea = 25;
            EmittedSound = "agressive MYAU-MYAU";
            IsPredator = true;
            Species = "Lynx";
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} running");
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
