using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CostCenter", Schema = "ds")]
    public partial class CostCenter
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(40)]
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
