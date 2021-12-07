using System;
namespace AnimalShelter.Entities
{
    public class Dog : Animal
    {
        public Dog(string Name, int Id)
        {
            name = Name;
            id = Id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int age { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Woff");
        }
    }
}