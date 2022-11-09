using NUnit.Framework;
using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Animals;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Test
{
    public class VolierTests
    {
        [TestCaseSource()]
        public void FindHowMuchAndWhatKindOfFoodLeftInFeeder(Voliers voliers, FoodList foodname, int givenFood, int eatenFood, Message expectedMessage)
        {
            Message actualMessage = Voliers.FindHowMuchAndWhatKindOfFoodLeftInFeeder(foodname, givenFood, eatenFood);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}