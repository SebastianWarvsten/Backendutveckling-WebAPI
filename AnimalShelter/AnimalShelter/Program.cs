using System;
using AnimalShelter.Entities;

namespace AnimalShelter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog("Dog-1", 1); // Ett nytt Dog-objekt skapas
            Animal dog2 = new Dog("Dog-2", 2); // Ett nytt Dog-objekt skapas
            Animal firstDog = new Dog("Doggymanz", 3); // Ett nytt Dog-objekt skapas
            Animal firstCat = new Cat("Catmanz", 4); // Ett nytt Dog-objekt skapas
            Animal anotherCat = new Cat("Mrs.Mjaosson", 5);

            Shelter shelter = new Shelter(); // Ett nytt Shelter-objekt skapas
            shelter.AddAnimal(dog); // Shelter har någon form av datastruktur.
            //När vi kallar på funktionen AddAnimal() kommer objektet vi lägger in som argument att sparas i denna.
            shelter.AddAnimal(dog2);
            shelter.AddAnimal(firstCat);
            shelter.AddAnimal(anotherCat);
            shelter.AddAnimal(firstDog);
            shelter.DeleteAnimal(1); // Shelter har två metoder för att
            //radera en Dog, en baserad på namn, och en baserad på id. (DELEN DÄR MAN BASERAR DELETE PÅ NAMN SKA INTE VARA MÄ)
            shelter.DeleteAnimal(2);
            //shelter.UpdateAnimal(dog, "New name"); // UpdateAnimal() tar in ett
            //Dog - objekt och en sträng, vilket uppdaterar                 namnet på objektet vi skickade med.
            //Console.WriteLine(shelter.GetAnimals(1).GetName()); // "New name"
            var myshelter = shelter.GetAnimals();
            foreach (Animal animal in myshelter)
            {
                animal.MakeSound(); // "Voff!"
            }
        }
    }
}
