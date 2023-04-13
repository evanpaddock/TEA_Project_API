using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Models;
using TEA_Project_API.Database;
using TEA_Project_API.Database.Users;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return ReadUsers.GetAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public User Get(int id)
        {
            return ReadUsers.GetUser(id);
        }

        // POST: api/User
        [HttpPost(Name = "PostUser")]
        public void Post([FromBody] User myUser)
        {
            SaveUser.NewUser(myUser);
        }

        // PUT: api/User/5
        [HttpPut("{id}", Name = "PutUser")]
        public void Put([FromBody] User myUser)
        {
            SaveUser.UpdateUser(myUser);
        }

        // // DELETE: api/User/5
        // [HttpDelete("{id}", Name = "DeleteUser")]
        // public void Delete(int id)
        // {
        // }
    }
}
