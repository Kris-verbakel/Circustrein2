using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circustrein.Classes
{
    public class Wagon
    {
        public int capacity { get { return 10 - animals.Sum(e => (int)e.Size); } }
        private List<Animal> animals = new List<Animal>();


        public Wagon(Animal animal)
        {
            animals.Add(animal);
        }

        public bool AddAnimal(Animal animal)
        {
            if (CheckFit(animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
        }

        private bool CheckFit(Animal animal)
        {
            if (CheckCapacity(animal) && CheckSafe(animal) && CheckWagonSafe(animal))
            {
                return true;
            }
            return false;
        }

        private bool CheckCapacity(Animal animal)
        {
            if ((int)animal.Size <= capacity)
            {
                return true;
            }
            return false;
        }

        private bool CheckSafe(Animal animal)
        {
            foreach (Animal an in animals)
            {
                if (an.Size >= animal.Size)
                {
                    if (an.Food == Food.carnivore)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool CheckWagonSafe(Animal animal)
        {
            if (animal.Food == Food.carnivore)
            {
                foreach (Animal an in animals)
                {
                    if (an.Size <= animal.Size)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
