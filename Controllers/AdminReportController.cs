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
        // GET: api/AdminReport/5
        [HttpGet]
        [Route("MakeAndTotal")]
        public List<MakeAndTotal> GetMakeAndTotals()
        {
            return MostCommonMake.GetMakeAndTotals();
        }

        [HttpGet]
        [Route("CarCombinations")]
        public List<CarCombinations> GetCarCombinations()
        {
            return MostCommonCarCombinationReports.GetTotalCombinations();
        }

        [HttpGet]
        [Route("UserStateTotals")]
        public List<UserStateTotals> GetUserStateCounts()
        {
            return UserStateCounts.GetUserStateTotals();
        }
    }
}
