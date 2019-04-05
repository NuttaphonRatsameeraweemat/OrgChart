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
        public List<OrgChartModel> Get(string empNo)
        {
            List<OrgChartModel> model = new List<OrgChartModel>();
            try
            {
                if (empNo != null)
                {
                    //Get ManagerLine + himself
                    var managerList = GetEmployeeLine(empNo,true);
                    model.AddRange(managerList);

                    var belowEmpList = GetBelowEmpLine(empNo);
                    model.AddRange(belowEmpList);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return model;
        }

        /// <summary>
        /// Get all employee (Testing Method).
        /// </summary>
        /// <returns></returns>
        public List<Hremployee> GetEmployee()
        {
            return _unitOfWork.GetRepository<Hremployee>().GetCache().ToList();
        }

        public List<OrgChartModel> GetEmployeeLine (string empNo, bool includeHimself = false)
        {

            List<OrgChartModel> reportLineList = new List<OrgChartModel>();

            try
            {
                var empList = _unitOfWork.GetRepository<Hremployee>().GetCache().ToList();
                var posList = _unitOfWork.GetRepository<Hrposition>().GetCache().ToList();
                var orgList = _unitOfWork.GetRepository<Hrorg>().GetCache().ToList();
                string nextEmpNo = empNo;
                int maxLoop  = 20;
                int countLoop = includeHimself ? 1 : 0;
                while (!string.IsNullOrEmpty(nextEmpNo) && countLoop < maxLoop)
                {
                    var emp = empList.Where(m => m.EmpNo == nextEmpNo).FirstOrDefault();
                    if (emp != null)
                    {
                        if (countLoop != 0)
                        {
                            var pos = posList.Where(m => m.PosId == emp.PositionId).FirstOrDefault();
                            var org = orgList.Where(m => m.OrgId == emp.OrgId).FirstOrDefault();

                            int? id = null;
                            int? pid = null;
                            if (emp.EmpNo != null)
                            {
                                id = Convert.ToInt32(emp.EmpNo);
                            }
                            if (emp.ManagerEmpNo != null)
                            {
                                pid = Convert.ToInt32(emp.ManagerEmpNo);
                            }



                            reportLineList.Add(new OrgChartModel
                            {
                                Id = id,
                                Pid = pid,
                                Name = emp.FirstnameTh + " " + emp.LastnameTh,
                                Position = pos != null ? pos.PosName : string.Empty,
                                Tags = org != null ? org.OrgName : string.Empty
                            });
                        }
                        nextEmpNo = emp.ManagerEmpNo;
                    }
                    else
                    {
                        nextEmpNo = "";
                    }

                    countLoop++;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return reportLineList;   
        }

        public List<OrgChartModel> GetBelowEmpLine(string empNo)
        {
            List<OrgChartModel> reportLineList = new List<OrgChartModel>();
            try
            {
                var belowEmpList = _unitOfWork.GetRepository<Hremployee>().GetCache().Where(x => x.ManagerEmpNo == empNo).ToList();
                foreach (var below in belowEmpList)
                {
                    var empList = RecursiveTree(below.EmpNo);
                    reportLineList.AddRange(empList);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return reportLineList;
        }

        public List<OrgChartModel> RecursiveTree(string empNo)
        {
            List<OrgChartModel> result = new List<OrgChartModel>();

            var empList = _unitOfWork.GetRepository<Hremployee>().GetCache().ToList();
            var emp = empList.FirstOrDefault(x => x.EmpNo == empNo);
            var empLineList = empList.Where(x => x.ManagerEmpNo == emp.EmpNo).ToList();
            var pos = _unitOfWork.GetRepository<Hrposition>().GetCache().FirstOrDefault(x => x.PosId == emp.PositionId);
            var org = _unitOfWork.GetRepository<Hrorg>().GetCache().FirstOrDefault(x => x.OrgId == emp.OrgId);

            if (emp != null)
            {
                int? id = null;
                int? pid = null;
                if (emp.EmpNo != null)
                {
                    id = Convert.ToInt32(emp.EmpNo);
                }
                if (emp.ManagerEmpNo != null)
                {
                    pid = Convert.ToInt32(emp.ManagerEmpNo);
                }

                result.Add(new OrgChartModel{
                    Id = id,
                    Pid = pid,
                    Name = emp.FirstnameTh + " " + emp.LastnameTh,
                    Position = pos != null ? pos.PosName : string.Empty,
                    Tags = org != null ? org.OrgName : string.Empty
                });
            }

            if (empLineList != null)
            {
                foreach (var item in empLineList)
                {
                    var a = RecursiveTree(item.EmpNo);
                    result.AddRange(a);
                }
            }


            return result;
        }
        #endregion

    }
}
