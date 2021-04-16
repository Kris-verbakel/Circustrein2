using Circustrein;
using Circustrein.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircustreinTest
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonAddAnimal_AnimalFit_ReturnsTrue()
        {
            //Arrange
            Animal animal = new Animal(Food.herbivore, Size.medium, "Koe");
            Animal animal2 = new Animal(Food.herbivore, Size.small, " Konijn"); 
            Wagon wagon = new Wagon(animal);

            //Act
            bool result = wagon.AddAnimal(animal2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WagonAddAnimal_AnimalNotFit_ReturnsFalse()
        {
            //Arrange
            Animal animal1 = new Animal(Food.herbivore, Size.medium, "Koe");
            Animal animal2 = new Animal(Food.herbivore, Size.big, "Olifant");
            Animal animal3 = new Animal(Food.herbivore, Size.medium, "Paard");

            Wagon wagon = new Wagon(animal1);
            wagon.AddAnimal(animal2);

            //Act
            bool result = wagon.AddAnimal(animal3);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WagonAddAnimal_AnimalNotSafe_ReturnFalse()
        {
            //Arrange 
            Animal animal1 = new Animal(Food.carnivore, Size.big, "Beer");
            Animal animal2 = new Animal(Food.herbivore, Size.medium, "Koe");

            Wagon wagon = new Wagon(animal1);

            //Act
            bool result = wagon.AddAnimal(animal2);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WagonAddAnimal_WagonNotSafe_ReturnFalse()
        {
            //Arrange
            Animal animal1 = new Animal(Food.herbivore, Size.medium, "Koe");
            Animal animal2 = new Animal(Food.herbivore, Size.small, "Kip");
            Animal animal3 = new Animal(Food.carnivore, Size.medium, "Vos");

            Wagon wagon = new Wagon(animal1);
            wagon.AddAnimal(animal2);

            //Act
            bool result = wagon.AddAnimal(animal3);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WagonAddAnimal_AnimalNotFitAndAnimalNotSafe_ReturnFalse()
        {
            //Arrange
            Animal animal1 = new Animal(Food.carnivore, Size.medium, "Krokodil");
            Animal animal2 = new Animal(Food.herbivore, Size.big, "Olifant");
            Animal animal3 = new Animal(Food.herbivore, Size.medium, "Hert");

            Wagon wagon = new Wagon(animal1);
            wagon.AddAnimal(animal2);

            //Act
            bool result = wagon.AddAnimal(animal3);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
