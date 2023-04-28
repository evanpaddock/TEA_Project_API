using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.GenInfo;
using TEA_Project_API.Models;

namespace TEA_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenInfoController : ControllerBase
    {
        // GET: api/GenInfo
        [HttpGet]
        public Models.GenInfo Get()
        {
            return ReadInfo.GetInfoPageData();
        }

        // PUT: api/GenInfo/5
        [HttpPut]
        public void Put([FromBody] Models.GenInfo newPageInfo)
        {
            SaveInfo.SaveGenInfo(newPageInfo);
        }
    }
}
