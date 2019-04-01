using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("WorkflowDelegate", Schema = "ds")]
    public partial class WorkflowDelegate
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string FromUser { get; set; }
        [StringLength(100)]
        public string ToUser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
