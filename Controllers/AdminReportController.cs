using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Models;
using TEA_Project_API.Database.Data_For_Reports;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminReportController : ControllerBase
    {
        // GET: api/AdminReport
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/AdminReport/5
        [HttpGet]
        public List<MakeAndTotal> Get()
        {
            return MostCommonMake.GetMakeAndTotals();
        }

        // POST: api/AdminReport
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // PUT: api/AdminReport/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE: api/AdminReport/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
