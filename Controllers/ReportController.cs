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
    public class ReportController : ControllerBase
    {
        // GET: api/Report
        [HttpGet(Name = "GetReports")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Report/5
        [HttpGet("{id}", Name = "GetReport")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Report
        [HttpPost(Name = "PostReport")]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Report/5
        [HttpPut("{id}",Name = "PutReport")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // // DELETE: api/Report/5
        // [HttpDelete("{id}", Name = "DeleteReport")]
        // public void Delete(int id)
        // {
        // }
    }
}
