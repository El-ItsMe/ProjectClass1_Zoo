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
        public BearAnimals(string name, int age): base(name, age) //это означает вызов базового конструктора из абстракции
        {
            FoodVariants = new List<FoodList>() //В абстракции мы создали метод для хранения переменной листа,
                                                //и здесь вписываем то, какая еда будет хранится для каждого животного отдельн
            {
                FoodList.Bamboo
            };
            Biom = Options.BiomVariants.Tropics; //Из всех типов, вызываем нужный нам Biom. С его помощью вероятность допусить ошибку при написании снижается
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