using System;
using System.Collections.Generic;
using System.Text;

namespace OrgChart.Bll.Models
{
    public class OrgChartModel
    {
        public int? Id { get; set; }
        public int? Pid { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public string Position { get; set; }
        
    }
}
