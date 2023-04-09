using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/Car
        [HttpGet(Name = "GetCars")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Car/5
        [HttpGet("{id}", Name = "GetCar")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Car
        [HttpPost(Name = "PostCar")]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Car/5
        [HttpPut("{id}", Name = "PutCar")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Car/5
        [HttpDelete("{id}", Name = "DeleteCar")]
        public void Delete(int id)
        {
        }
    }
}
