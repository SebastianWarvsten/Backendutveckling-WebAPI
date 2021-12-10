using DogShelter.Entities;
using DogShelter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly IDogRepository _dogRepository;

        public DogsController(IDogRepository repo)
        {
            _dogRepository = repo;
        }

        [HttpGet]

        public IEnumerable<Dog> GetDogs()
        {
            var dogs = _dogRepository.GetDogs();
            return dogs;
        }

        [HttpGet("{id}")]

        public ActionResult<Dog> GetDog(int id)
        {
            var dog = _dogRepository.GetDog(id);

            if(dog == null)
            {
                return NotFound();
            }
            return Ok(dog);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDog(Dog dog, int id)
        {
            var selectedDog = _dogRepository.GetDog(id);
            if(selectedDog == null)
            {
                return NotFound();
            }
            selectedDog.Name = dog.Name;
            _dogRepository.UpdateDog(selectedDog);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDog(int id)
        {
            _dogRepository.DeleteDog(id);
            return NoContent();
        }

        [HttpPost]
        public ActionResult<Dog> AddDog(Dog dog)
        {
            Dog nDog = new Dog()
            {
                Id = dog.Id,
                Name = dog.Name,
            };
            _dogRepository.AddDog(dog);
            return CreatedAtAction(nameof(GetDog), new { id = dog.Id }, dog);
        }
    }
}