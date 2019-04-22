using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrgChart.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ValueModel Values()
        {
            return new ValueModel { Name = "Test Angular" };
        }
    }

    public class ValueModel
    {
        public string Name { get; set; }
    }

}