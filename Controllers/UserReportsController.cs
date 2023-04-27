using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.User_Reports;
using TEA_Project_API.Models;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserReportsController : ControllerBase
    {
        // GET: api/UserReports
        [HttpGet]
        public IEnumerable<UserReport> Get()
        {
            return ReadUserReports.GetAllUserReports();
        }

        // GET: api/UserReports/5
        [HttpGet("{User_ID}", Name = "GetUserReport")]
        public UserReport Get(int User_ID)
        {
            return ReadUserReports.GetUserReport(User_ID);
        }

        // POST: api/UserReports
        [HttpPost]
        public void Post([FromBody] UserReport myUserReport)
        {
            SaveUserReports.NewUserReport(myUserReport);
        }
    }
}
