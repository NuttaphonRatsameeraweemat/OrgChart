using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CostCenterManager", Schema = "ds")]
    public partial class CostCenterManager
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(11)]
        public string CostCenter { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
    }
}
