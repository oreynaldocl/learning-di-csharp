using PeopleViewer.Common;
using Microsoft.AspNetCore.Mvc;
using People.Service.Models;
using System.Collections.Generic;
using System.Linq;

namespace People.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        readonly IPeopleProvider provider;

        public PeopleController(IPeopleProvider provider)
        {
            this.provider = provider;
        }

        // GET api/people
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return provider.GetPeople();
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return provider.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}
