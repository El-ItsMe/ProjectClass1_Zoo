using ProjectClass1_Zoo.Options;
using ProjectClass1_Zoo.Animals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClass1_Zoo.Test
{
    public class VolierTestsSource : IEnumerable //У него есть свои встроенные методы. Нужен для выводы больше одного return
    {
        public IEnumerator GetEnumerator() //Встроенный метод, создали по конструктору
        {
            Voliers voliers = new Voliers("Volier for Horse", Options.BiomVariants.Tropical_rain_forests, 20, "Horse"); //создаём вольер
            AbstractAnimals animal = new HorseAnimals("Diego", 4); //Лошадку по имени Диего, со всеми составляющими

            //Пишем как должен выглядеть вольер в ожидании
            Voliers expectedVoliers = new Voliers("Volier for Horse", Options.BiomVariants.Tropical_rain_forests, 20, "Horse");
            expectedVoliers.Animals.Remove(new HorseAnimals("Diego", 4)); //После-вызываем метод, который нужно протестить
            Message expectedMessage = new Message() //И наконец какое на входе сообщение должны получить
            {
                Text = $"Из Volier for Horse выселили Horse Diego",
                SenderName = "Volier for Horse",
                SenderType = "Volier",
                MessageType = MessageType.Succses
            };
            yield return new object[] { animal, voliers, expectedMessage };
            //Объяснение к 28-ой строчке, yield- нужен для множественного выводы
            //new object - создание массива и место под него в хранилище, а остальные значения, просто на вывод  
        }
    }
}







//ИГНОРИРУЙТЕ ЭТО
//(для разбора)
//Voliers voliers = new Voliers("Volier for Horse", Options.BiomVariants.Tropical_rain_forests, 20, "Horse");
//FoodList foodname = FoodList.Oats;
//int givenFood = 80;
//int eatenFood = 40;
//Message expectedMessage = new Message()
//{
//    Text = $"В кормушке для Volier for Horse осталось 40 кг Oats",
//    SenderName = "Voliers for Horse",
//    SenderType = "Aviary",
//    MessageType = MessageType.Succses
//};
//yield return new object[] { voliers, foodname, givenFood, eatenFood, expectedMessage };
