﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Animals
{
    public class HorseAnimals: AbstractAnimals
    {
        public HorseAnimals(string name, int age) : base(name, age)
        {
            food = Options.FoodList.Grain_feed;
            food = Options.FoodList.Legume_feed;
            Biom = Options.BiomVariants.Steppes;
            RequiredArea = 25;
            EmittedSound = "Igo-go-go";
            IsPredator = false;
            Species = "Horse";
        }

        public override void DoSound()
        {
            Console.WriteLine(EmittedSound);
        }

        public override void DoPlay()
        {
            Console.WriteLine($"{Name} eating hay"); //ест сено
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