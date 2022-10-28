using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class Penguin : AbstractAnimals
    {
        public Penguin(string name, int age) : base(name, age)
        {    
            food = Options.FoodList.Fish;
            Biom = Options.BiomVariants.Taiga;
            NameOfAnimalSpecies = "Penguin";
            RequiredArea = "108 m^2";
            EmittedSound = "Piu-piu-piu";
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} dancing");
        }
    }
}
