using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserCollections
{
    
    class AnimalCollection (string address, string shelterName, int phoneNumber) : IEnumerable<Animal>, ICollection<Animal>, IList<Animal>
    {
        private Animal?[] animals = new Animal[10];
        private int animalCounter = -1;

        public string Address { get; init; } = address;
        public string ShelterName { get; init; } = shelterName;
        public int PhoneNumber { get; set; } = phoneNumber;

        public int Count => animalCounter + 1;

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
            for (int i = 0; i < Count; i++)
            {
                if (animals[i] != null)
                    yield return animals[i];
            }
        }

        private void ResizeArray()
        {
            Animal[] newAnimals = new Animal[animals.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newAnimals[i] = animals[i];
            }

            animals = newAnimals;
        }

        public void Add(Animal animal)
        {
            if (Count == animals.Length / 2)
            {
                ResizeArray();
            }

            animals[++animalCounter] = animal;
        }

        public void Clear()
        {
            animals = new Animal[10];
            animalCounter = -1;
        }

        public bool Contains(Animal item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }

            return false;
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            for (int i = 0; i <= animalCounter; i++)
            {
                if (animals[i] != null)
                {
                    array[arrayIndex++] = animals[i];
                }
            }
        }

        public bool Remove(Animal item)
        {
            int index = IndexOf(item);

            if (index != -1)
            {
                animals[index] = null;
                return true;
            }

            animalCounter--;
            return false;
        }

        public int IndexOf(Animal item)
        {
            for (int i = 0; i <= animalCounter; i++)
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
            if ((animalCounter + 1 <= animals.Length) && (index < animalCounter) && (index >= 0))
            {
                animalCounter++;

                for (int i = animalCounter - 1; i > index; i--)
                {
                    animals[i] = animals[i - 1];
                }
                animals[index] = item;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > animalCounter)
                throw new ArgumentOutOfRangeException(nameof(index));

            for (int i = index; i < animalCounter; i++)
            {
                animals[i] = animals[i + 1];
            }

            animals[animalCounter] = null;
            animalCounter--;
        }
    }
}
