using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.Report_Cars;
using TEA_Project_API.Models;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportCarsController : ControllerBase
    {
        // GET: api/CarReports
        [HttpGet]
        public IEnumerable<CarReport> GetAllCarReports()
        {
            return ReadReportCars.GetAllCarReports();
        }

        // GET: api/CarReports/5
        [HttpGet("{Report_ID}", Name = "GetCarReport")]
        public CarReport GetCarReport(int Report_ID)
        {
            return ReadReportCars.GetCarReport(Report_ID);
        }

        // POST: api/CarReports
        [HttpPost]
        public void Post([FromBody] CarReport myCarReport)
        {
            SaveReportCars.NewCarReport(myCarReport);
        }
    }
}
