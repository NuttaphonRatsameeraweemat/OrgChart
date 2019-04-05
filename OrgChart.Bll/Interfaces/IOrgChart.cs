using OrgChart.Bll.Models;
using OrgChart.Data.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgChart.Bll.Interfaces
{
    public interface IOrgChart
    {
        List<OrgChartModel> Get(string empNo);
        List<Hremployee> GetEmployee();
    }
}
