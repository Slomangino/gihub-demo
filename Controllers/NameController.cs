using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace github_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public Person Get()
        {
            var me = new Person()
            {
                Name = "Stephen",
                Age = 26,
            };

            return me;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
