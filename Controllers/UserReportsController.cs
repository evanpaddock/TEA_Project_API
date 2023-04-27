// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace TEA_Project_API.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class UserReportsController : ControllerBase
//     {
//         // GET: api/UserReports
//         [HttpGet]
//         public IEnumerable<string> Get()
//         {
//             return new string[] { "value1", "value2" };
//         }

//         // GET: api/UserReports/5
//         [HttpGet("{id}", Name = "Get")]
//         public string Get(int id)
//         {
//             return "value";
//         }

//         // POST: api/UserReports
//         [HttpPost]
//         public void Post([FromBody] string value)
//         {
//         }

//         // PUT: api/UserReports/5
//         [HttpPut("{id}")]
//         public void Put(int id, [FromBody] string value)
//         {
//         }
//     }
// }
