using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Models;
using TEA_Project_API.Database;
using TEA_Project_API.Database.Cars;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/Car
        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> Get()
        {
            return ReadCars.GetAllCars();
        }

        // GET: api/Car/5
        [HttpGet("{id}", Name = "GetCar")]
        public Car Get(int id)
        {
            return ReadCars.GetCar(id);
        }

        // POST: api/Car
        [HttpPost(Name = "PostCar")]
        public void Post([FromBody] Car myCar)
        {
            SaveCars.NewCar(myCar);
        }

        // PUT: api/Car/5
        [HttpPut(Name = "PutCar")]
        public void Put([FromBody] Car myCar)
        {
            SaveCars.UpdateCar(myCar);
        }

        // // DELETE: api/Car/5
        // [HttpDelete("{id}", Name = "DeleteCar")]
        // public void Delete(int id)
        // {
        // }
    }
}
