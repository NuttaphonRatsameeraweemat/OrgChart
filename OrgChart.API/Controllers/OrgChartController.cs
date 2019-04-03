using Microsoft.AspNetCore.Mvc;
using OrgChart.Bll.Interfaces;

namespace OrgChart.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrgChartController : ControllerBase
    {

        #region [Fields]

        /// <summary>
        /// The Org Chart manager provides Org Chart functionality.
        /// </summary>
        private readonly IOrgChart _orgChart;

        #endregion

        #region [Constructors]

        /// <summary>
        ///  Initializes a new instance of the <see cref="OrgChartController" /> class.
        /// </summary>
        /// <param name="hremployee"></param>
        public OrgChartController(IOrgChart orgChart)
        {
            _orgChart = orgChart;
        }

        #endregion

        #region [Methods]

        [HttpGet]
        public IActionResult Get(string empNo)
        {
            return Ok(_orgChart.Get(empNo));
        }

        [HttpGet]
        [Route("GetEmployee")]
        public IActionResult GetEmployee()
        {
            return Ok(_orgChart.GetEmployee());
        }

        #endregion

    }
}