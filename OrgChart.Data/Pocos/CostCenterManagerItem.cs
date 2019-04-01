using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("CostCenterManagerItem", Schema = "ds")]
    public partial class CostCenterManagerItem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CostCenterManagerID")]
        public int? CostCenterManagerId { get; set; }
        [StringLength(11)]
        public string Manager { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
