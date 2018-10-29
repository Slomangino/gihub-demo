using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace github_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : Controller
    {
        [HttpGet]
        public Person GetWithId(int id)
        {
            var person = People.FirstOrDefault(a => a.Id == id);

            return person;
        }

        [HttpPost]
        public int CreatePerson([FromBody] PersonInputDTO input)
        {
            var random = new Random();

            People.Add(new Person
            {
                Id = random.Next(2, 200),
                Name = input.Name,
                Age = input.Age ?? 25
            });

            return People.Last().Id;
        }

        public List<Person> People = new List<Person>(new List<Person>
        { 
            new Person()
            {
                    Id = 1,
                    Name = "Stephen",
                    Age = 26
            }
        });
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonInputDTO
    {
        public string Name { get; set; } 

        public int? Age { get; set; }
    }
}
