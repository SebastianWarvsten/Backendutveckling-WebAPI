using System.Collections.Generic;
using System.Linq;
using DogShelter.Entities;

namespace DogShelter.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly List<Dog> _dogsCollection = new List<Dog>()
        {
            new Dog() { Id = 1, Name = "Doggy_1" },
            new Dog() { Id = 2, Name = "Doggy_2" },
            new Dog() { Id = 3, Name = "Doggy_3" },
        };

        public IEnumerable<Dog> GetDogs()
        {
            return _dogsCollection;
        }

        public Dog GetDog(int id)
        {
            var dog = _dogsCollection.Where(e => e.Id == id);
            return dog.SingleOrDefault();
        }

        public void UpdateDog(Dog dog)
        {
            var index = _dogsCollection.FindIndex(e => e.Id == dog.Id);
            _dogsCollection[index] = dog;

        }
        public void DeleteDog(int id)
        {
            Dog index = _dogsCollection.Find(e => e.Id == id);
            _dogsCollection.Remove(index);
        }
        public void AddDog(Dog dog)
        {
            _dogsCollection.Add(dog);
        }
    }
}
