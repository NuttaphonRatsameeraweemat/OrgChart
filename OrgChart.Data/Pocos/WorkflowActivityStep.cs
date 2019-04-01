using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgChart.Data.Pocos
{
    [Table("WorkflowActivityStep", Schema = "ds")]
    public partial class WorkflowActivityStep
    {
        [Column("ProcessInstanceID")]
        public int ProcessInstanceId { get; set; }
        public int Step { get; set; }
        [StringLength(40)]
        public string ActionUser { get; set; }
        [StringLength(20)]
        public string Activity { get; set; }
        [StringLength(20)]
        public string FormState { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(11)]
        public string ActionUserCode { get; set; }
        [StringLength(9)]
        public string ActionUserPosition { get; set; }
        [StringLength(9)]
        public string ActionUserOrg { get; set; }
    }
}
