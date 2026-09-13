using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserCollections
{
    
    class ShelterDescription (string address, string shelterName, int phoneNumber) : IEnumerable<Animal>, ICollection<Animal>, IList<Animal>
    {
        private Animal?[] animals = new Animal[10];
        private int animalCount = -1;

        public string Address { get; init; } = address;
        public string ShelterName { get; init; } = shelterName;
        public int PhoneNumber { get; set; } = phoneNumber;

        public int Count => animalCount + 1;

        public bool IsReadOnly => false;

        Animal IList<Animal>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Animal? this[int index]
        {
            get
            {
                if (index < 0 || index >= animals.Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return animals[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        { 
            return animals.GetEnumerator(); 
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            for (int i = 0; i < animalCount; i++)
            {
                if (animals[i] != null)
                    yield return animals[i];
            }
        }

        private void ResizeArray()
        {
            Animal[] newAnimals = new Animal[animals.Length * 2];
            for (int i = 0; i < animals.Length; i++)
            {
                newAnimals[i] = animals[i];
            }

            animals = newAnimals;
        }

        public void Add(Animal animal)
        {
            if (animalCount == animals.Length / 2)
            {
                ResizeArray();
            }

            animals[++animalCount] = animal;
        }

        public void Clear()
        {
            animals = new Animal[10];
            animalCount = -1;
        }

        public bool Contains(Animal item)
        {
            foreach (var animal in animals)
            {
                if (animal != null && animal.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            for (int i = 0; i <= animalCount; i++)
            {
                if (animals[i] != null)
                {
                    array[arrayIndex++] = animals[i];
                }
            }
        }

        public bool Remove(Animal item)
        {
            for (int i = 0; i <= animalCount; i++)
            {
                if (animals[i] != null && animals[i].Equals(item))
                {
                    animals[i] = null;
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(Animal item)
        {
            for (int i = 0; i <= animalCount; i++)
            {
                if (animals[i] != null && animals[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, Animal item)
        {
            if ((animalCount + 1 <= animals.Length) && (index < animalCount) && (index >= 0))
            {
                animalCount++;

                for (int i = animalCount - 1; i > index; i--)
                {
                    animals[i] = animals[i - 1];
                }
                animals[index] = item;
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < animals.Length; i++)
            {
                animals[i] = null;
            }
        }
    }
}
