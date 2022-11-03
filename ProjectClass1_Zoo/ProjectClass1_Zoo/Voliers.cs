using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo
{
    public class Voliers
    {   //Из чего состоит вольер
        public string Name { get; protected set; } // 1) Имя
        public string DeleteName { get; set; }
        public BiomVariants Biom { get; protected set; } // 2) Биом
        public int Square { get; protected set; } // 3) Площадь вольера
        public string Species { get; protected set; } //Разновидность животных
        public List<AbstractAnimals> Animals { get; protected set; } // 4) Животное (-ые) которoe(-ые) там будет (-ут) жить
        //коммент к строчке 12 - модификатор protected, так как лист мы можем только читать, но не переопределять

        public Voliers(string name, BiomVariants biom, int square, string species) //задаём конструктор
        {
            Name = name;
            Biom = biom;
            Square = square;
            Species = species;
            Animals = new List<AbstractAnimals>(); //!!!Вопрос, поясните, зачем добавили эту строчку
            //коммент к 20 строчке - возможно, чтобы задать какое животное(-ые) там уже живёт(-ут)
        }

        public string AddAnimal(AbstractAnimals animal) //функционал: добавляем животное
        {
            if (Biom == animal.Biom)
            {
                Animals.Add(animal);
            }
            return $"В {Name} поселилось {animal.Name}";
        }

        public string DeleteAnimal(string deleteName, string species) //Задаем имя животного, которое нужно выселить и его вид
        {
            foreach (AbstractAnimals animal in Animals)
            {
                if (species == animal.Species && deleteName == animal.Name) //перебираем цикл до тех пор, пока не найдём нужное имя и вид
                {
                    Animals.Remove(animal);
                }
            }
            return $"Из вольера {Name} выселили {deleteName}";
        }


    }
}
