using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("HREmployeeMobile", Schema = "ds")]
    public partial class HremployeeMobile
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string EmpNo { get; set; }
        [StringLength(20)]
        public string MobileNo { get; set; }
        [StringLength(11)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
