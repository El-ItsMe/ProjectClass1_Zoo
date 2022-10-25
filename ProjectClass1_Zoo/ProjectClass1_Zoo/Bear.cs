using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass1_Zoo
{
    public class Bear
    {
        public string Name { get; set; }
        private string _name;
        
        public string NameOfAnimalSpecies { get; set; } //Название вида 

        private string _nameOfAnimalSpecies;
        public string Biom { get; set; }//Необходимый биом

        private string _biom;
        public string RequiredArea { get; set; } //Необходимая площадь на особь

        private string _requiredArea;
        public string WhatDoesItEating { get; set; } //Чем питается

        private string _eating;
        public string Squars { get; set; } //отряд хищник или травоядное

        private string _squars;
        public string EmittedSound { get; set; } //Издаваемый звук
        private string _sounds;
        public Bear(string name, string biom, string requiredArea, string whatDoesItEating, string eating, string squars, string sounds)
        {
            Name = _name;
            NameOfAnimalSpecies = _nameOfAnimalSpecies;
            Biom = biom;
            RequiredArea = requiredArea;
            WhatDoesItEating = _eating;
            Squars = _squars;
            EmittedSound = _sounds;

        }

        public void DoGrowl() 
        {
            Console.WriteLine("Grrr-grrr");
        }

        public void DoPlay()
        {
            Console.WriteLine("Play");
        }

        public void DoEating()
        {
            Console.WriteLine("Eating");
        }

    }
}
