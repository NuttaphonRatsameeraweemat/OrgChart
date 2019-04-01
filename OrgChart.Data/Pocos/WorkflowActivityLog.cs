using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("WorkflowActivityLog", Schema = "ds")]
    public partial class WorkflowActivityLog
    {
        [Column("ProcessInstanceID")]
        public int ProcessInstanceId { get; set; }
        public int? Step { get; set; }
        [StringLength(100)]
        public string SerialNo { get; set; }
        [StringLength(100)]
        public string ActionUser { get; set; }
        public DateTime? ActionDate { get; set; }
        [StringLength(100)]
        public string Action { get; set; }
        public string Comment { get; set; }
        [StringLength(100)]
        public string AllocatedUser { get; set; }
        [StringLength(11)]
        public string ActionUserCode { get; set; }
        [StringLength(9)]
        public string ActionUserPosition { get; set; }
        [StringLength(9)]
        public string ActionUserOrg { get; set; }
    }
}
