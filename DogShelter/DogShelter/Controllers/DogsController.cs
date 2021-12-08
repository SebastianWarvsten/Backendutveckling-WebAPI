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
        private readonly DogRepository _dogRepository = new DogRepository();

        [HttpGet]

        public IEnumerable<Dog> GetDogs()
        {
            return _dogRepository.GetDogs();
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
    }
}
