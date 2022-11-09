using NUnit.Framework;
using ProjectClass1_Zoo;
using ProjectClass1_Zoo.Animals;
using ProjectClass1_Zoo.Options;

namespace ProjectClass1_Zoo.Test
{
    public class VolierTests
    {
        [TestCaseSource(typeof(VolierTestsSource))] //�.�. ����� � ����-������ ������� ������, ����� ���������� �������� �� ���������� ������

        //�������� ����� �������� ��������� � ����� �� ���� ��������, ������ � ��������� ���������
        public void DeleteAnimalTest(AbstractAnimals animal, Voliers volier, Message expectedMessage) 
        {
            Message actualMessage = volier.DeleteAnimal(animal); //����������� ����������� ���������
            Assert.AreEqual(expectedMessage, actualMessage); //����������
        }
    }
}








//����������� ���
//public void FindHowMuchAndWhatKindOfFoodLeftInFeeder(Voliers voliers, FoodList foodname, int givenFood, int eatenFood, Message expectedMessage)
//{
//    Message actualMessage = voliers.FindHowMuchAndWhatKindOfFoodLeftInFeeder(foodname, givenFood, eatenFood);

//    Assert.AreEqual(expectedMessage, actualMessage);
//}