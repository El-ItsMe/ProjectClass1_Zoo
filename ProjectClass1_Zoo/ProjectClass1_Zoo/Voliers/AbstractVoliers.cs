using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo.Voliers
{
    public abstract class AbstractVoliers
    {
        public string Name { get; protected set; }

        public BiomVariants Biom { get; protected set; }
        public int Square { get; protected set; }
        public string[] Allanimals { get; protected set; }

        List<string> AllanimalsList = new List<string>();
        public AbstractVoliers(string name)
        {
            Name = name;
            AllanimalsList.Add(AbstractAnimals.BearAnimals);
        }

    }
}
