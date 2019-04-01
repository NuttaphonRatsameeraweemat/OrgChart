using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("RespGroup", Schema = "ds")]
    public partial class RespGroup
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public string Remark { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool BudgetGroup { get; set; }
        [StringLength(20)]
        public string GroupType { get; set; }
    }
}
