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
        public Person Get()
        {
            // create local object
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
