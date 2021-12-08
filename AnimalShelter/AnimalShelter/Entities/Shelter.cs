using System;
using System.Collections.Generic;
using System.Linq;
namespace AnimalShelter.Entities
{
    public class Shelter
    {
        public Shelter()
        {
        }
        private readonly List<Animal> _animals = new List<Animal>()
        {
        };
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine(animal.name + " added to the shelter");
        }
        public void DeleteAnimal(int id)
        {
            Animal markedAnimal = _animals.Find(e => e.id == id);
            _animals.Remove(markedAnimal);
        }
        public IEnumerable<Animal> GetAnimals()
        {
            return _animals;
        }
        public Animal GetAnimals(int id)
        {
            var animal = _animals.Where(item => item.id == id);
            return animal.SingleOrDefault();
        }
        public void UpdateAnimal(Animal animal, string newName)
        {
            var updatedAnimal = _animals.Find(e => e.name == animal.name);
            animal.name = newName;
        }
    }
}