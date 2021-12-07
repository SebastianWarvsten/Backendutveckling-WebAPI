using System;
namespace AnimalShelter.Entities
{
    public class Animal
    {
        public virtual string name { get; set; }
        public virtual int id { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Makes a sound");
        }
    }
}
