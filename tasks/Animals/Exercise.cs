using System;

namespace Animals;

public class Exercise
{
  public List<int> numberOfAnimalLegs()
  {
    var lion = new Lion();
    var tiger = new Tiger();
    var duck = new Duck();
    var spider = new Spider();

    var animalsList = new List<Animal> { lion, tiger, duck, spider };
    var result = new List<int>();

    foreach (var animal in animalsList)
    {
      result.Add(animal.NumberOfLegs());
    }

    return result;
  }
  public int CalculateTotalLegs()
  {
    int sumOfLegs = 0;

    foreach (int leg in numberOfAnimalLegs())
    {
      sumOfLegs += leg;
    }
    return sumOfLegs;
  }


}
