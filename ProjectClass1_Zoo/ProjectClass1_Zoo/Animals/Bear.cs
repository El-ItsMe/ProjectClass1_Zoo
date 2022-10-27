using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class Bear: AbstractAnimals
    {
        public Bear(string name, int age): base(name, age)
        {
            food = Options.FoodList.Bamboo;
            Biom = Options.BiomVariants.Tropics;
            NameOfAnimalSpecies = "Panda";
            RequiredArea = "108 m^2";
            EmittedSound = "Grrrrr-Grrrr";
        }

        public override void DoSound()
        {
            base.DoSound();
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} eating bamboo");
        }

    }
}
