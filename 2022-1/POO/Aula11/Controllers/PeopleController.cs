using System.Collections.Generic;
using Aula11.Models.Domains;
using Aula11.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private IPersonRepository repository;

        public PeopleController(IPersonRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            repository.Create(person);
            return Ok(person);
        }
    }
}