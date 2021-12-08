using System;
using AnimalShelter.Entities;

namespace AnimalShelter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog("Dog-1", 1);
            Animal dog2 = new Dog("Dog-2", 2);
            Animal anotherDog = new Dog("Doggymanz", 3);
            Animal firstCat = new Cat("Catmanz", 4);
            Animal anotherCat = new Cat("Mrs.Mjaosson", 5);

            Shelter shelter = new Shelter();
            shelter.AddAnimal(dog);
            shelter.AddAnimal(dog2);
            shelter.AddAnimal(firstCat);
            shelter.AddAnimal(anotherCat);
            shelter.AddAnimal(anotherDog);
            shelter.DeleteAnimal(1);
            shelter.DeleteAnimal(2);
            shelter.AddAnimal(dog);
            shelter.UpdateAnimal(dog, "Doggeru");
            Console.WriteLine(shelter.GetAnimals(1).GetName());
            var myshelter = shelter.GetAnimals();
            foreach (Animal animal in myshelter)
            {
                animal.GetName();
                animal.MakeSound();
            }
        }
    }
}
