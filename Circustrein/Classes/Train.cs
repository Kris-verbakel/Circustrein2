using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Classes
{
    public class Train
    {
        public List<Wagon> wagons = new List<Wagon>();

        public Train()
        {

        }

        public bool AddNewAnimal(Animal animal)
        {
            if (CheckWagonAvailable(animal))
            {
                return true;
            }

            else
            {
                wagons.Add(new Wagon(animal));
                return true;
            }
        }

        private bool CheckWagonAvailable(Animal animal)
        {
            foreach (Wagon w in wagons)
            {
                if (w.AddAnimal(animal))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
