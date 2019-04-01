using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("RespGroupEmp", Schema = "ds")]
    public partial class RespGroupEmp
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("RespGroupID")]
        public int? RespGroupId { get; set; }
        [StringLength(11)]
        public string EmpNo { get; set; }
    }
}
