using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEA_Project_API.Database.GenInfo;

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
        public void Put(string title, string text)
        {
            SaveInfo.SaveGenInfo(title, text);
        }
    }
}
