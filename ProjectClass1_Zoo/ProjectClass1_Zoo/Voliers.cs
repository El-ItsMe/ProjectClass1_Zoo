using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;

namespace ProjectClass1_Zoo
{
    public class Voliers
    {   //Из чего состоит вольер
        public string Name { get; protected set; } // 1) Имя
        public string DeleteName { get; set; }
        public List<FoodList> FoodVariants { get; protected set; } //Чем питается
        public BiomVariants Biom { get; protected set; } // 2) Биом
        public int Square { get; protected set; } // 3) Площадь вольера
        public string Species { get; protected set; } //Разновидность животных
        public Dictionary<string, int> LeftFood { get; protected set; }
        public List<AbstractAnimals> Animals { get; protected set; } // создан не список, а переменная для его хранения
        //коммент к строчке 12 - модификатор protected, так как лист мы можем читать только в наследниках. 

        public Voliers(string name, BiomVariants biom, int square, string species) //задаём конструктор
        {
            Name = name;
            Biom = biom;
            Square = square;
            Species = species;
            Animals = new List<AbstractAnimals>(); //!!!создание объекта
        }

        //Поселенец (упрощенный вариант)
        public string PoselilsaIliNet(AbstractAnimals animal)
        {
            Animals.Add(animal);
            return $"В вольер {Name} поселился {animal.Species} {animal.Name}";
        }


        //Расписываем функционал
        //Удаление животного из вольера
        public Message DeleteAnimal(AbstractAnimals animal) //Задаем имя животного, которое нужно выселить и его вид
        {
            Animals.Remove(animal);
            return new Message()
            {
                Text = $"Из {Name} выселили {animal.Species} {animal.Name}",
                SenderName = Name,
                SenderType = "Volier",
                MessageType = MessageType.Succses
            };
        }

        //Узнать сколько и какой еды осталось в кормушках
       
        public Message FindHowMuchAndWhatKindOfFoodLeftInFeeder(FoodList foodname, int givenFood, int eatenFood) //Записываем в метод тип еды, сколько еды дали, сколько еды съедено
        {
            if (givenFood == 0) //если еду совсем не дали, выводим сообщение о том, что нужно вывести письмо
            {
                return new Message()
                {
                    Text = "Kormuwka pustaya, nujno dobavit edi",
                    SenderName = Name,
                    SenderType = "Volier",
                    MessageType = MessageType.Failed
                };
            }
            else
            {
                int amount = givenFood - eatenFood; //В ином случае, отнимаем ранее положенную в кормушку еду от съеденной доли и выводим результат

                return new Message
                {
                    Text = $"В кормушке для {Name} осталось {amount} кг {foodname}",
                    SenderName = Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.Succses
                };
            }
        }

        //Может содержать в себе различные типы животных (!!! Нужно доработать)

        public string IsItPossibleToPlaceTheseAnimals(AbstractAnimals animals)
        {
            foreach (AbstractAnimals a in Animals)
            {
                if (!a.IsPredator);
            }
            return $"{animals.Species} {animals.Name} может жить с остальными животными в этом вольере";
        }
    }
}





//Добавление животного/ Не копировка, код взят чисто для разбора
//public Message AddAnimal(AbstractAnimals animal)
//{
//    if (Biom != animal.Biom)
//    {
//        return new Message()
//        {
//            Text = $"В {Name} не поселился {animal.Species} {animal.Name}, не подходит биом",
//            SenderName = Name,
//            SenderType = "Aviary",
//            MessageType = MessageType.FaildAddingToAviary
//        };
//    }
//    else if (!IsPodhodiatSosedi(animal))
//    {
//        return new Message()
//        {
//            Text = $"В {Name} не поселился {animal.Species} {animal.Name}, из-за соседей",
//            SenderName = Name,
//            SenderType = "Aviary",
//            MessageType = MessageType.FaildAddingToAviary
//        };
//    }
//    else
//    {
//        Animals.Add(animal);
//        return new Message()
//        {
//            Text = $"В {Name} поселился {animal.Name}",
//            SenderName = Name,
//            SenderType = "Aviary",
//            MessageType = MessageType.AddingToAviary
//        };
//    }
//}

//private bool IsPodhodiatSosedi(AbstractAnimals animal)
//{
//    foreach (AbstractAnimals a in Animals)
//    {
//        if ((a.IsPredator || animal.IsPredator) && a.Species != animal.Species)
//        {
//            return false;
//        }
//    }
//    return true;
//}

//public override bool Equals(object? obj)
//{
//    return obj is Voliers voliers &&
//           Name == voliers.Name &&
//           Biom == voliers.Biom &&
//           Square == voliers.Square &&
//           Species == voliers.Species;

//}
