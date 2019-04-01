using OrgChart.Bll.Interfaces;
using OrgChart.Bll.Models;
using OrgChart.Data.Pocos;
using OrgChart.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrgChart.Bll
{
    public class OrgChartBll : IOrgChart
    {

        #region [Fields]

        /// <summary>
        /// The utilities unit of work for manipulating utilities data in database.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgChartBll" /> class.
        /// </summary>
        /// <param name="unitOfWork">The utilities unit of work.</param>
        public OrgChartBll(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get Organization Chart.
        /// </summary>
        /// <param name="empNo">The employee number.</param>
        /// <returns></returns>
        public OrgChartModel Get(string empNo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all employee (Testing Method).
        /// </summary>
        /// <returns></returns>
        public List<Hremployee> GetEmployee()
        {
            return _unitOfWork.GetRepository<Hremployee>().GetCache().ToList();
        }

        #endregion


    }
}
