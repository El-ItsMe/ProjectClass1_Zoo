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
            FoodVariants = new List<FoodList>()
            {
                FoodList.Oats,
                FoodList.Mushrooms
            };
            Biom = Options.BiomVariants.Steppes;
            RequiredArea = 8;
            EmittedSound = "grrrrr-grrrrr";
            IsPredator = false;
            Species = "Rabbit";
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
            if (food.Contains(food)) //Не забыть. Contains здесь нужен, чтобы определить входит ли вписанная намиеда в изначальный список животного или нет
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
