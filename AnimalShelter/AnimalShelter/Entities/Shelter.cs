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
            new Animal() { id = 1, name = "Tigerbear"},
            new Animal() { id = 2, name = "WolfCat"},
            new Animal() { id = 3, name = "Dobbermannen"},
        };
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine(animal.name + " added to the shelter");
        }
        public IEnumerable<Animal> GetAnimals()
        {
            return _animals;
        }
        public Animal GetVinyl(int id)
        {
            var animal = _animals.Where(item => item.id == id);
            return animal.SingleOrDefault();
        }
    }
}