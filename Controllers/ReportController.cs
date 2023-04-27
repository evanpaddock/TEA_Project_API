using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.Reports;
using TEA_Project_API.Models;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        // GET: api/Report
        [HttpGet(Name = "GetReports")]
        public IEnumerable<Report> Get()
        {
            return ReadReports.GetAllReports();
        }

        // GET: api/Report/5
        [HttpGet("{id}", Name = "GetReport")]
        public Report Get(int id)
        {
            return ReadReports.GetReport(id);
        }

        // POST: api/Report
        [HttpPost(Name = "PostReport")]
        public void Post([FromBody] Report myReport)
        {
            SaveReport.NewReport(myReport);
        }

        // PUT: api/Report/5
        [HttpPut(Name = "PutReport")]
        public void Put([FromBody] Report myReport)
        {
            SaveReport.UpdateReport(myReport);
        }
    }
}
