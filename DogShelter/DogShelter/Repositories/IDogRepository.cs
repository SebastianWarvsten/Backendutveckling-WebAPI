using System.Collections.Generic;
using DogShelter.Entities;

namespace DogShelter.Repositories
{
    public interface IDogRepository
    {
        IEnumerable<Dog> GetDogs();
        Dog GetDog(int id);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);
        void AddDog(Dog dog);
    }
}
