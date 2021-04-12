using Circustrein;
using Circustrein.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircustreinTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void AddOneAnimal_ReturnTrue()
        {
            //Een dier word toegevoegd. Het result hoort true te zijn omdat het dier in een wagon past. 
            //Arrange
            Animal animal = new Animal(Food.herbivore, Size.medium, "Koe");
            Train train = new Train();

            //Act
            bool result = train.AddNewAnimal(animal);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddMultipleAnimals_ReturnTrue()
        {
            //Veel dieren worden toegevoegd. De dieren worden door het algoritme verdeeld over verschillende wagonnen. 
            //Het result is hoort hier ook true te zijn. 

            //Arrange
            Animal animal1 = new Animal(Food.herbivore, Size.medium, "1");
            Animal animal2 = new Animal(Food.carnivore, Size.big, "2");
            Animal animal3 = new Animal(Food.herbivore, Size.medium, "3");
            Animal animal4 = new Animal(Food.carnivore, Size.small, "4");
            Animal animal5 = new Animal(Food.herbivore, Size.big, "5");
            Animal animal6 = new Animal(Food.carnivore, Size.small, "6");
            Animal animal7 = new Animal(Food.herbivore, Size.medium, "7");
            Animal animal8 = new Animal(Food.carnivore, Size.big, "8");
            Animal animal9 = new Animal(Food.herbivore, Size.medium, "9");
            Animal animal10 = new Animal(Food.carnivore, Size.small, "10");
            Animal animal11 = new Animal(Food.herbivore, Size.medium, "11");
            Animal animal12 = new Animal(Food.carnivore, Size.big, "12");

            Train train = new Train();

            train.AddNewAnimal(animal1);
            train.AddNewAnimal(animal2);
            train.AddNewAnimal(animal3);
            train.AddNewAnimal(animal4);
            train.AddNewAnimal(animal5);
            train.AddNewAnimal(animal6);
            train.AddNewAnimal(animal7);
            train.AddNewAnimal(animal8);
            train.AddNewAnimal(animal9);
            train.AddNewAnimal(animal10);
            train.AddNewAnimal(animal11);

            //Act
            bool result = train.AddNewAnimal(animal12);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
