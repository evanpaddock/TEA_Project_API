using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.Roles;
using TEA_Project_API.Models;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        // GET: api/Role
        [HttpGet(Name = "GetRoles")]
        public IEnumerable<Role> Get()
        {
            return ReadRoles.GetAllRoles();
        }

        // GET: api/Role/5
        [HttpGet("{id}", Name = "GetRole")]
        public Role Get(int id)
        {
            return ReadRoles.GetRole(id);
        }

        // POST: api/Role
        [HttpPost(Name = "PostRoles")]
        public void Post([FromBody] Role myRole)
        {
            SaveRoles.NewRole(myRole);
        }

        // PUT: api/Role/5
        [HttpPut( Name = "PutRole")]
        public void Put([FromBody] Role myRole)
        {
            SaveRoles.UpdateRole(myRole);
        }

        // // DELETE: api/Role/5
        // [HttpDelete("{id}", Name = "DeleteRole")]
        // public void Delete(int id)
        // {

        // }
    }
}
