using System;
using System.Collections.Generic;
using System.Linq;
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

        public Dog GetDog(int id)
        {
            var dog = _dogsCollection.Where(e => e.id == id);
            return dog.SingleOrDefault();
        }
    }
}
