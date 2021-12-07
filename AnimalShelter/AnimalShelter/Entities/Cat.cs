using System;
namespace AnimalShelter.Entities
{
    public class Cat : Animal
    {
        public Cat(string Name, int Id)
        {
            name = Name;
            id = Id;
        }

        public string Name { get; }
        public int Id { get; }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
