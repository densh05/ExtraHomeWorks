using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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

        public Animal this[int index] 
        {
            get
            {
                if (index < 0 || index >= animals.Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return animals[index];
            }

            set
            {
                if (index < 0 || index >= animals.Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                animals[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        { 
            return GetEnumerator(); 
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new Enumarator(this);
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
            return IndexOf(item) != -1;
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            for (int i = 0; i <= animalCounter; i++)
            {
                if (animals[i] != null)
                    array[arrayIndex++] = animals[i];
            }
        }

        public bool Remove(Animal item)
        {
            int index = IndexOf(item);

            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }

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

                for (int i = animalCounter; i > index; i--)
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

        struct Enumarator : IEnumerator<Animal>  //My personal implementation of IEnumerator<Animal> interface
        {
            private readonly AnimalCollection collection;
            private int index = -1;

            public Enumarator(AnimalCollection collection)
            {
                this.collection = collection;
            }

            public Animal Current => collection[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                index++;
                return index < collection.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
