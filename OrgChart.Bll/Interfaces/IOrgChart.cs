using OrgChart.Bll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgChart.Bll.Interfaces
{
    public interface IOrgChart
    {
        OrgChartModel Get(string empNo);
    }
}
