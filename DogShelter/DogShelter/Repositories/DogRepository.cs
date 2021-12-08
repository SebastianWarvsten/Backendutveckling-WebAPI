using System;
using System.Collections.Generic;
using DogShelter.Entities;

namespace DogShelter.Repositories
{
    public class DogRepository
    {
        private readonly List<Dog> _dogsCollection = new List<Dog>()
        {
            new Dog() { id = 1, name = "Doggy_1" },
            new Dog() { id = 2, name = "Doggy_2" },
            new Dog() { id = 3, name = "Doggy_3" },
        };

        public IEnumerable<Dog> GetDogs()
        {
            return _dogsCollection;
        }
    }
}
