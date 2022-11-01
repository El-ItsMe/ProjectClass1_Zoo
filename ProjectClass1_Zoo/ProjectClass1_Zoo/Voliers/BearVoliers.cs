using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Voliers;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo
{
    public class BearVoliers : AbstractVoliers
    {
        public BearVoliers(string name) : base(name)
        {
            Biom = Options.BiomVariants.Tropics;
            Square = 100;
        }

 
    }
}

