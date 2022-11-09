using NUnit.Framework;
using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Animals;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Test
{
    public class VolierTests
    {
        [TestCaseSource(typeof(VolierTestsSource))] //Т.к. метод в тест-кейсах вызвать нельзя, кладёт полученные значения из указанного класса

        //Вызываем метод удаления животного и кладём на вход животное, вольер и ожидаемое сообщение
        public void DeleteAnimalTest(AbstractAnimals animal, Voliers volier, Message expectedMessage) 
        {
            Message actualMessage = volier.DeleteAnimal(animal); //Высчитываем фактический результат
            Assert.AreEqual(expectedMessage, actualMessage); //Сравниваем
        }
    }
}








//ИГНОРИРУЙТЕ ЭТО
//public void FindHowMuchAndWhatKindOfFoodLeftInFeeder(Voliers voliers, FoodList foodname, int givenFood, int eatenFood, Message expectedMessage)
//{
//    Message actualMessage = voliers.FindHowMuchAndWhatKindOfFoodLeftInFeeder(foodname, givenFood, eatenFood);

//    Assert.AreEqual(expectedMessage, actualMessage);
//}